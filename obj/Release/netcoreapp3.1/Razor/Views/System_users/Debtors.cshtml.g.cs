#pragma checksum "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad865e655d7e84de23da7b6b5bf3e6cdb110732f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_System_users_Debtors), @"mvc.1.0.view", @"/Views/System_users/Debtors.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad865e655d7e84de23da7b6b5bf3e6cdb110732f", @"/Views/System_users/Debtors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d15a9e523eca5a17a857e4df62f700c509088df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_System_users_Debtors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm w3-card bg-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Creditor_fuel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "System_users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete_account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/users.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sell"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add_debtor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/sell.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/fuel_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-6"">


        <div class=""image-flip"">
            <div class=""mainflip flip-0"">
                <div class=""frontside"">
                    <div class=""card w3-card side_custome"">
                        <div class=""card-body text-left"">
                            <div class=""row"">


                                <div class=""col-lg-12 col-12"">
                                    <h1 class=""card-title"">");
#nullable restore
#line 18 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                                      Write(ViewBag.count_debtors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n\r\n                            <p class=\"card-text\">Client accounts </p>\r\n\r\n                        </div>\r\n");
            WriteLiteral(@"
                    </div>
                </div>
            </div>

        </div>
    </div>  <div class=""col-lg-6"">


        <div class=""image-flip"">
            <div class=""mainflip flip-0"">
                <div class=""frontside"">
                    <div class=""card w3-card side_custome"">
                        <div class=""card-body text-left"">
                            <div class=""row"">

                                <div class=""col-lg-12 col-12"">
                                    <h1 class=""card-title"">");
#nullable restore
#line 51 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                                      Write(ViewBag.sum_of_debts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n\r\n\r\n                            <p class=\"card-text\">Total cash on credit</p>\r\n\r\n                        </div>\r\n");
            WriteLiteral(@"
                    </div>
                </div>
            </div>

        </div>

    </div>
</div>
<br />
<div class=""card w3-card"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""row"">
                <div class=""col-lg-12"">


                    <div class=""form-inline d-flex justify-content-center md-form form-sm active-pink active-pink-2 mt-2 ml-3 w-100"">
                        <i class=""fa fa-search "" aria-hidden=""true"" style=""color:#68213A ""></i>
                        <input id=""creditors"" class=""form-control form-control-sm ml-3 search_input mb-2"" type=""text"" placeholder=""Search""
                               aria-label=""Search"">
                        &nbsp;
");
            WriteLiteral(@"                        <button class=""btn btn-white btn-sm m-1  w3-card"" id=""creditors_pdf""><i class=""fa fa-file-pdf-o"" aria-hidden=""true""></i>&nbsp;Download PDF</button><br />
                        <button class=""btn btn-white btn-sm m-1 w3-card"" id=""creditors_pdf"" data-dismiss=""modal"" data-toggle=""modal"" data-target=""#add_client""><i class=""fa fa-plus"" aria-hidden=""true""></i>&nbsp;Create new account</button>

                    </div>
                </div>

            </div>
        </div>
    </div>
    <br />
    <br />

    <div class=""row"">
        <div class=""col-lg-12"">
            <table class=""table font_flex"" id=""creditors_table"">
                <tr>
                    <th style=""border:none"">Name</th>
                    <th style=""border:none"">Phone</th>
                    <th style=""border:none"">Action</th>
                </tr>

");
#nullable restore
#line 111 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                 if (@ViewBag.all_debtors != null)
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
     foreach (var item in @ViewBag.all_debtors)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n\r\n    <td class=\"border_none\" style=\"border-top: none\">");
#nullable restore
#line 117 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                                Write(item.Customer_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 118 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                               Write(item.Phone_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n   \r\n    <td class=\"border_none\" style=\"border:none\">\r\n       \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad865e655d7e84de23da7b6b5bf3e6cdb110732f12269", async() => {
                WriteLiteral("Open");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
             WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                             WriteLiteral(ViewBag.station_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["station_id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-station_id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["station_id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a class=\"btn btn-sm w3-card bg-danger text-white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4968, "\"", 4999, 3);
            WriteAttributeValue("", 4978, "delete_func(", 4978, 12, true);
#nullable restore
#line 123 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
WriteAttributeValue("", 4990, item.id, 4990, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4998, ")", 4998, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i></a>\r\n    </td>\r\n\r\n\r\n</tr>");
#nullable restore
#line 127 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div class=""modal fade custome_modal_radius"" id=""delete_mod"">
    <div class=""modal-dialog"">
        <div class=""modal-content border-0 bg-transparent"">

            <!-- Modal Header -->
            <div class=""alert alert-danger  p-2 bg-danger text-white border-0"">
                <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i><br />  Are you sure you want to remove this client from the system?.<br />
                NB: All credit history associated with this client will be lost
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad865e655d7e84de23da7b6b5bf3e6cdb110732f17160", async() => {
                WriteLiteral(@"
                    <table class=""table"">
                        <input name=""id"" id=""delete_id"" type=""text"" hidden />
                        <tr>
                            <td style=""border:0"" class=""text-left"">
                                <button type=""submit"" class=""btn btn-sm bg-white w3-card "">Proceed</button>

                            </td>
                            <td style=""border:0"" class=""text-right"">
                                <a class=""btn btn-sm bg-white w3-card mr-5"" data-dismiss=""modal"">Cancel</a>

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"modal fade custome_modal_radius\" id=\"add_client\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content border-0\">\r\n\r\n            <!-- Modal Header -->\r\n");
            WriteLiteral("\r\n            <!-- Modal body -->\r\n            <div class=\"modal-header  p-2  \" style=\"z-index:1020\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad865e655d7e84de23da7b6b5bf3e6cdb110732f19719", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;<b>ALL DEBTORS</b>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad865e655d7e84de23da7b6b5bf3e6cdb110732f20945", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad865e655d7e84de23da7b6b5bf3e6cdb110732f21224", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 189 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"group\">\r\n                        <input name=\"station_id\" hidden");
                BeginWriteAttribute("value", " value=\"", 7294, "\"", 7321, 1);
#nullable restore
#line 191 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
WriteAttributeValue("", 7302, ViewBag.station_id, 7302, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""text"" required=""required"" />
                        <input name=""Full_name"" class=""custome_input"" type=""text"" required=""required"" />
                        <span class=""highlight""></span>
                        <span class=""bar""></span>
                        <label>Full names</label>
                    </div>
                    <div class=""group"">
                        <input name=""Phone"" class=""custome_input"" value=""07"" type=""number"" maxlength=""10"" required=""required"" />
                        <span class=""highlight""></span>
                        <span class=""bar""></span>
                        <label>Phone</label>
                    </div>
                   






                    <div class=""form-group"">
                        <input type=""submit"" value=""Submit"" class=""btn btn-primary"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>


    </div>
</div>

<div class=""modal fade custome_modal_radius"" id=""all_creditors"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <!-- Modal Header -->
            <div class=""modal-header  p-2  "" style=""z-index:1020"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad865e655d7e84de23da7b6b5bf3e6cdb110732f25854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"&nbsp;<b>ALL DEBTOR</b>
            </div>
            <div class=""modal-body  p-2 w3-card"" style=""z-index:1020"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""row"">
                            <div class=""col-lg-12"">


                                <div class=""form-inline d-flex justify-content-center md-form form-sm active-pink active-pink-2 mt-2 ml-3 w-100"">
                                    <i class=""fa fa-search "" aria-hidden=""true"" style=""color:#68213A ""></i>
                                    <input id=""creditors"" class=""form-control form-control-sm ml-3 search_input mb-2"" type=""text"" placeholder=""Search""
                                           aria-label=""Search"">
                                    &nbsp;
");
            WriteLiteral(@"                                    <button class=""btn btn-primary btn-sm"" id=""creditors_pdf""><i class=""fa fa-file-pdf-o"" aria-hidden=""true""></i>&nbsp;PDF</button>
                                    <button class=""btn btn-primary btn-sm"" id=""creditors_pdf"" data-dismiss=""modal"" data-toggle=""modal"" data-target=""#add_client""><i class=""fa fa-file-pdf-o"" aria-hidden=""true""></i>&nbsp;Add new client</button>

                                </div>

                            </div>

                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <table class=""table font_flex"" id=""creditors_table"">
                                    <tr>
                                        <th style=""border:none"">Name</th>
                                        <th style=""border:none"">Phone</");
            WriteLiteral("th>\r\n                                      \r\n                                    </tr>\r\n\r\n");
#nullable restore
#line 262 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                     if (@ViewBag.all_debtors != null)
                                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 264 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                         foreach (var item in @ViewBag.all_debtors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"border_none\" style=\"border-top: none\">");
#nullable restore
#line 267 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                                        Write(item.Customer_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"border_none\" style=\"border-top:none\">");
#nullable restore
#line 268 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                                                       Write(item.Phone_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("/=</td>\r\n            \r\n            <td>\r\n                <button class=\"btn w3-card p-1\"><i class=\"fa fa-ellipsis-v\" aria-hidden=\"true\"></i></button>\r\n\r\n            </td>\r\n        </tr>");
#nullable restore
#line 274 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 274 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </table>\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("debt", async() => {
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n\r\n\r\n            var msg = \'");
#nullable restore
#line 292 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\System_users\Debtors.cshtml"
                  Write(TempData["popup"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'

            if (msg == ""1"") {
                $(""danger"").show();
                $(""success"").hide();

                $('#positive_results').modal('show');
                setTimeout(function () {
                    $('#positive_results').modal('hide');
                }, 3000);

            }
            else if (msg == ""2"") {
                $(""danger"").show();
                $(""success"").hide();
                $('#negative_results').modal('show');
                setTimeout(function () {
                    $('#negative_results').modal('hide');
                }, 3000);
            }
            else if (msg == ""5"") {

                $(""#add_new_item_to_system"").modal('show');
            }
            else if (msg == ""4"") {

                $(""#filtered_sold"").modal('show');
            }
            else {

            }
        });
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
