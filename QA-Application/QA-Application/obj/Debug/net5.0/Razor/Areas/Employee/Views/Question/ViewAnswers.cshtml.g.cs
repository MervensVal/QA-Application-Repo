#pragma checksum "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e00e9475af30f4c472602c2e6996219702970b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Employee_Views_Question_ViewAnswers), @"mvc.1.0.view", @"/Areas/Employee/Views/Question/ViewAnswers.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\_ViewImports.cshtml"
using QA_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\_ViewImports.cshtml"
using QA_Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
using QA_Application.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e00e9475af30f4c472602c2e6996219702970b9", @"/Areas/Employee/Views/Question/ViewAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c4ea2dbe97280952f3def82891fcbbe1287510", @"/Areas/Employee/Views/_ViewImports.cshtml")]
    public class Areas_Employee_Views_Question_ViewAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewAnswerVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAnswers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
  
    ViewData["Title"] = "ViewAnswers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewAnswers</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e00e9475af30f4c472602c2e6996219702970b94603", async() => {
                WriteLiteral("View Answers");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<label class=\"control-label\">Question</label>\r\n<div class=\"card bg-light mb-2 border-secondary\" width=\"50\"> \r\n    ");
#nullable restore
#line 17 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
Write(ViewData["Question"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 19 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
 if( Model is not null) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card bg-light mb-2 border-secondary\">\r\n        <div style=\"background-color: mediumaquamarine;\">\r\n            Userneame: ");
#nullable restore
#line 24 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
                  Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"m-2\">\r\n            Date Answered:  ");
#nullable restore
#line 27 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n        </div>\r\n        <div class=\"m-2\">\r\n            Answer: ");
#nullable restore
#line 31 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
               Write(item.AnswerBody);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\valme\Source\Repos\MervensVal\QA-Application-Repo\QA-Application\QA-Application\Areas\Employee\Views\Question\ViewAnswers.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e00e9475af30f4c472602c2e6996219702970b98492", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewAnswerVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
