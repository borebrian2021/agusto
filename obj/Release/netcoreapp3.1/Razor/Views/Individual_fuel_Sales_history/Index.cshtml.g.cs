#pragma checksum "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b42d2bd4eec720f00af495614c912148a2135e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Individual_fuel_Sales_history_Index), @"mvc.1.0.view", @"/Views/Individual_fuel_Sales_history/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42d2bd4eec720f00af495614c912148a2135e2b", @"/Views/Individual_fuel_Sales_history/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d15a9e523eca5a17a857e4df62f700c509088df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Individual_fuel_Sales_history_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SHOP_DECOMPILED.Models.Individual_fuel_Sales_history>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "sales_per_day", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Fuel_station_reg/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm bg-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/fuel_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style type=\"text/css\" src=\"https://cdn.datatables.net/1.10.25/css/dataTables.bootstrap4.min.css\"></style>\r\n<div class=\"container-fluid w3-card p-3 bg-white\">\r\n    <h5>Sales</h5>\r\n</div>\r\n<p>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b42d2bd4eec720f00af495614c912148a2135e2b5643", async() => {
                WriteLiteral("\r\n        <table>\r\n\r\n            <tr>\r\n                <td>\r\n                    <input class=\"form-control\" name=\"Date\"  type=\"date\" />\r\n                    <input class=\"form-control\" name=\"station_id\"");
                BeginWriteAttribute("value", " value=\"", 625, "\"", 646, 1);
#nullable restore
#line 19 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
WriteAttributeValue("", 633, ViewBag.s_id, 633, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden  />
                </td>
                <td>
                    <button class=""btn btn-sm bg-white w3-card""><i class=""fa fa-search""></i>&nbsp;Search</button>

                </td>
            </tr>
            <tr>
                <td>
                    <a class=""btn btn-sm bg-white w3-card"" id=""download_all_pdf""><i class=""fa fa-download"" aria-hidden=""true""></i>&nbsp;Download Pdf</a>

                </td>
                <td>
                    <a class=""btn btn-sm bg-white w3-card"" data-toggle=""modal"" data-target=""#sell_itemsf""><i class=""fa fa-clock-o""></i>&nbsp;Recent sales</a>

                </td>
            </tr>
        </table>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <br />\r\n");
            WriteLiteral("    <ul class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 42 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                      Write(ViewBag.station_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b42d2bd4eec720f00af495614c912148a2135e2b8865", async() => {
                WriteLiteral("List of fuel stations");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n        <li class=\"breadcrumb-item active\">Fuel sales</li>\r\n    </ul>\r\n\r\n    <table class=\"table\" style=\"z-index:1020\">\r\n        <tr>\r\n            <td class=\"border-0\">\r\n");
            WriteLiteral(@"            </td>

        </tr>
    </table>
    <div class=""container-fluid"" style=""overflow:scroll"">
        Recent meter records
        <table id=""example"" class=""table table-striped table-bordered"" style=""width:100%"">
            <thead>
                <tr>
");
            WriteLiteral(@"                    <th class=""border_none"" style=""border:none"">Date</th>
                    <th class=""border_none"" style=""border:none"">Dispenser</th>
                    <th class=""border_none"" style=""border:none"">Closing meter</th>
                    <th class=""border_none"" style=""border:none"">Previous meter</th>
                    <th class=""border_none"" style=""border:none"">Sold</th>
                    <th class=""border_none"" style=""border:none"">Price</th>
                    <th class=""border_none"" style=""border:none"">Cash made</th>
                    <th class=""border_none"" style=""border:none"">Submitted by</th>
                    <th class=""border_none"" style=""border:none"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 74 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                 foreach (var item in ViewBag.all_submitted_sales)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"w3-card space_tr\">\r\n");
            WriteLiteral("                        <td class=\"border_none\" style=\"border-top: none\"><b>");
#nullable restore
#line 78 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                        <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 79 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                   Write(item.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 80 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                   Write(item.Closing_meter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 81 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                   Write(item.Previous_meter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"border_none litres\" style=\"border-top:none\">");
#nullable restore
#line 82 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                          Write(item.Litres_sold);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 83 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"border_none cash_made\" style=\"border-top:none\">");
#nullable restore
#line 84 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                             Write(item.Cash_made);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"border_none cash_made\" style=\"border-top:none\">");
#nullable restore
#line 85 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                             Write(item.Attendant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"border_none cash_made\" style=\"border-top:none\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b42d2bd4eec720f00af495614c912148a2135e2b15035", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                                                                                                                                       WriteLiteral(item.fuel_id);

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
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 91 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n");
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n                ");
#nullable restore
#line 104 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Individual_fuel_Sales_history\Index.cshtml"
           Write(await Html.PartialAsync("_Pagination", 3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            DefineSection("x", async() => {
                WriteLiteral(@"
        <script>
            $(document).ready(function () {
                $('#example').DataTable({
                    searching: false, paging: true, info: false,
                    ""bPaginate"": false,
                    ""bLengthChange"": false,
                    ""bFilter"": true,
                });
            });

        </script>
        <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js""></script>
        <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.25/js/dataTables.bootstrap4.min.js""></script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SHOP_DECOMPILED.Models.Individual_fuel_Sales_history>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
