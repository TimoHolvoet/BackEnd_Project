#pragma checksum "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecfa285b6c422d9c21cb17a41a180b4ecebf2514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_IndexRoles), @"mvc.1.0.view", @"/Views/Admin/IndexRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/IndexRoles.cshtml", typeof(AspNetCore.Views_Admin_IndexRoles))]
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
#line 1 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\_ViewImports.cshtml"
using EventManager.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\_ViewImports.cshtml"
using EventManager.WebApp.Models;

#line default
#line hidden
#line 4 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecfa285b6c422d9c21cb17a41a180b4ecebf2514", @"/Views/Admin/IndexRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e72bdf8130fc56ed99cf14a4b9ef81b322cfe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_IndexRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
  
    ViewData["Title"] = "IndexRoles";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 21, true);
            WriteLiteral("\r\n<h1>Rollen</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(173, 56, true);
            WriteLiteral("    <div>Er zijn nog geen rollen aangemaakt.</div>\r\n    ");
            EndContext();
            BeginContext(229, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfa285b6c422d9c21cb17a41a180b4ecebf25144397", async() => {
                BeginContext(256, 16, true);
                WriteLiteral("Maak een rol aan");
                EndContext();
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
            EndContext();
            BeginContext(276, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(290, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(294, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfa285b6c422d9c21cb17a41a180b4ecebf25146025", async() => {
                BeginContext(321, 20, true);
                WriteLiteral("Nieuwe rol toevoegen");
                EndContext();
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
            EndContext();
            BeginContext(345, 106, true);
            WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <th>Role Id</th>\r\n            <th>Role Name</th>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(500, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(539, 7, false);
#line 26 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(546, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(574, 9, false);
#line 27 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(583, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
        }

#line default
#line hidden
            BeginContext(620, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 31 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Admin\IndexRoles.cshtml"
}

#line default
#line hidden
            BeginContext(637, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
