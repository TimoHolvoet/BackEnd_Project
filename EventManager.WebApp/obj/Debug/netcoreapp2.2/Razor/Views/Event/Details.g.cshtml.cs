#pragma checksum "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6525998ecb082506c878907a4396c268ebe47148"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Details), @"mvc.1.0.view", @"/Views/Event/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Details.cshtml", typeof(AspNetCore.Views_Event_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6525998ecb082506c878907a4396c268ebe47148", @"/Views/Event/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e72bdf8130fc56ed99cf14a4b9ef81b322cfe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventManager.WebApp.Models.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 126, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Event</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(260, 40, false);
#line 15 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(300, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(362, 36, false);
#line 18 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(398, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(459, 47, false);
#line 21 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(506, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(568, 43, false);
#line 24 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(611, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(672, 45, false);
#line 27 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(717, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(779, 41, false);
#line 30 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(820, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(881, 43, false);
#line 33 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(924, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(986, 39, false);
#line 36 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1086, 41, false);
#line 39 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1189, 37, false);
#line 42 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1287, 44, false);
#line 45 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1393, 40, false);
#line 48 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1494, 44, false);
#line 51 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1600, 40, false);
#line 54 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Capacity));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1701, 47, false);
#line 57 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoldTickets));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1810, 43, false);
#line 60 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoldTickets));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1914, 44, false);
#line 63 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2020, 46, false);
#line 66 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location.Venue));

#line default
#line hidden
            EndContext();
            BeginContext(2066, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2127, 52, false);
#line 69 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2241, 48, false);
#line 72 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2289, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2350, 49, false);
#line 75 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location.City));

#line default
#line hidden
            EndContext();
            BeginContext(2399, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2461, 45, false);
#line 78 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location.City));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2567, 53, false);
#line 81 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(2620, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2682, 49, false);
#line 84 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2792, 54, false);
#line 87 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(2846, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2908, 50, false);
#line 90 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(2958, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            EndContext();
#line 95 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
 if (User.IsInRole("Administrator"))
{

#line default
#line hidden
            BeginContext(3037, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(3056, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6525998ecb082506c878907a4396c268ebe4714815971", async() => {
                BeginContext(3102, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3110, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(3122, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6525998ecb082506c878907a4396c268ebe4714818309", async() => {
                BeginContext(3144, 16, true);
                WriteLiteral("Terug naar lijst");
                EndContext();
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
            EndContext();
            BeginContext(3164, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 101 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(3190, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(3209, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6525998ecb082506c878907a4396c268ebe4714819973", async() => {
                BeginContext(3231, 16, true);
                WriteLiteral("Terug naar lijst");
                EndContext();
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
            EndContext();
            BeginContext(3251, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 107 "C:\Users\Timo\Documents\BackEnd_Project\EventManager.WebApp\Views\Event\Details.cshtml"
}

#line default
#line hidden
            BeginContext(3268, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventManager.WebApp.Models.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591