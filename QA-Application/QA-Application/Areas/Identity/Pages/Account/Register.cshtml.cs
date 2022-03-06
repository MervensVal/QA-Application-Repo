using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using QA_Application.Data;
using QA_Application.Models;

namespace QA_Application.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Display(Name = "Full Name (Not working)")]
            public string Name { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "Role")]
            public string Role { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public IEnumerable<SelectListItem> RoleList { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            Input = new InputModel()
            {

                RoleList = _roleManager.Roles.Select(n => n.Name).Select(i => new SelectListItem
                {
                    Text = i,
                    Value = i
                })
            };
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {

                //var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var applicationUser = new ApplicationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    Name = Input.Name,
                    Role = Input.Role
                };

                //Creates the user
                var result = await _userManager.CreateAsync(applicationUser, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    //if the role does not exist create it
                    if (!await _roleManager.RoleExistsAsync(Constants.RoleAdmin))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Constants.RoleAdmin));
                    }
                    if (!await _roleManager.RoleExistsAsync(Constants.RoleEmplyee))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Constants.RoleEmplyee));
                    }
                    if (!await _roleManager.RoleExistsAsync(Constants.RoleGeneralUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(Constants.RoleGeneralUser));
                    }

                    if (applicationUser.Role == null)
                    {
                        await _userManager.AddToRoleAsync(applicationUser, Constants.RoleGeneralUser);
                    }
                    else
                    {
                        await _userManager.AddToRoleAsync(applicationUser, applicationUser.Role);
                    }
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(applicationUser);
                    //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { area = "Identity", userId = applicationUser.Id, code = code, returnUrl = returnUrl },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        if (applicationUser.Role == null)
                        {
                            await _signInManager.SignInAsync(applicationUser, isPersistent: false);
                            return LocalRedirect(returnUrl);
                        }
                        else
                        {
                            //Admin is registering user
                            return RedirectToAction("Index", "Users", new { Area = "Admin" });
                        }
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
