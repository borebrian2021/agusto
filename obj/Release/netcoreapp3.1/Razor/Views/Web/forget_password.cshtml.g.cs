#pragma checksum "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Web\forget_password.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e633ee9893b72fcacf28bb4d842c194afdca4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Web_forget_password), @"mvc.1.0.view", @"/Views/Web/forget_password.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e633ee9893b72fcacf28bb4d842c194afdca4f", @"/Views/Web/forget_password.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d15a9e523eca5a17a857e4df62f700c509088df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Web_forget_password : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("getin_form border-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ResetPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Brians\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Web\forget_password.cshtml"
   ViewData["Title"] = "Forget password";
    Layout = "~/Views/Shared/_Layout_website.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e633ee9893b72fcacf28bb4d842c194afdca4f4499", async() => {
                WriteLiteral(@"
    <!--PreLoader-->
    <div class=""loader"">
        <div class=""loader-inner"">
            <div class=""cssload-loader""></div>
        </div>
    </div>

    <section id=""main-banner-page"" class=""position-relative page-header reset-header parallax section-nav-smooth"">
        <div class=""overlay overlay-dark opacity-8 z-index-1""></div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 offset-lg-3"">
                    <div class=""page-titles whitecolor text-center padding_top padding_bottom"">
                        <h2 class=""font-xlight"">Let's Reset</h2>
                        <h2 class=""font-bold"">Forgotten Password</h2>
                        <h2 class=""font-xlight"">To Use Our</h2>
                        <h3 class=""font-light pt-2"">The Latest Ultimated Offers And Facilities</h3>
                    </div>
                </div>
            </div>
            <div class=""gradient-bg title-wrap"">
                <div class=""row"">
 ");
                WriteLiteral(@"                   <div class=""col-lg-12 col-md-12 whitecolor"">
                        <h3 class=""double-left"">Reset Password</h3>
                        <ul class=""breadcrumb top10 bottom10 double-right"">
                            <li class=""breadcrumb-item hover-light""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item hover-light"">Reset Password</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--Page Header ends -->
    <!-- reset password -->
    <section id=""sign-in"" class=""bglight position-relative padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12 text-center wow fadeIn"" data-wow-delay=""300ms"">
                    <h2 class=""heading bottom40 darkcolor font-light2"">
                        Reset<span class=""font-normal""> Password</span>
                        <span class=""divider-center""></span");
                WriteLiteral(@">
                    </h2>
                    <div class=""col-md-8 offset-md-2 heading_space"">
                    </div>
                </div>
                <div class=""col-lg-6 offset-lg-3 col-md-8 offset-md-2 col-sm-10 offset-sm-1 whitebox"">
                    <div class=""widget logincontainer shadow text-center text-md-left"">
                        <h3 class=""darkcolor bottom35"">Reset Password </h3>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e633ee9893b72fcacf28bb4d842c194afdca4f7390", async() => {
                    WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-12 col-sm-12"">
                                    <div class=""form-group bottom35"">
                                        <label for=""loginEmail"" class=""mb-3 pl-0"">Please enter Email or Username you remember!</label>
                                        <input class=""form-control"" type=""email"" placeholder=""Username or Email"" required id=""loginEmail"">
                                    </div>
                                </div>
                                <div class=""col-sm-12 forget-buttons"">
                                    <button type=""submit"" class=""button btn-primary"">Reset</button>
                                    <button type=""button"" class=""button btn-dark ml-2"">Cancel</button>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- sign-in ends -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- Mirrored from trax.acrothemes.com/forget-password.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sat, 10 Jul 2021 07:23:47 GMT -->\r\n</html>");
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
