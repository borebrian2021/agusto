#pragma checksum "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa1b85b8487fcd4266c574182a1e2488a0c09f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Refill_history_Details), @"mvc.1.0.view", @"/Views/Refill_history/Details.cshtml")]
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
#line 1 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffa1b85b8487fcd4266c574182a1e2488a0c09f4", @"/Views/Refill_history/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d15a9e523eca5a17a857e4df62f700c509088df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Refill_history_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SHOP_DECOMPILED.Models.Refill_history>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Refill_history</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fuel_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fuel_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ammount_refilled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ammount_refilled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date_refilled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date_refilled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.initial_readings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayFor(model => model.initial_readings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.final_readings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayFor(model => model.final_readings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 44 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.agent_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
       Write(Html.DisplayFor(model => model.agent_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffa1b85b8487fcd4266c574182a1e2488a0c09f48069", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 52 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Refill_history\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffa1b85b8487fcd4266c574182a1e2488a0c09f410227", async() => {
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SHOP_DECOMPILED.Models.Refill_history> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591