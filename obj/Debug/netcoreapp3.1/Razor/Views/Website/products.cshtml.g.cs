#pragma checksum "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Website\products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c45e5529d3c033ccc2bddb8b593021f7bed911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Website_products), @"mvc.1.0.view", @"/Views/Website/products.cshtml")]
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
#line 1 "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\_ViewImports.cshtml"
using SHOP_DECOMPILED.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c45e5529d3c033ccc2bddb8b593021f7bed911", @"/Views/Website/products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d15a9e523eca5a17a857e4df62f700c509088df", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Website_products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Website\products.cshtml"
    Layout = "~/Views/Shared/_Layout_website.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    
    <!-- ======= Blog Section ======= -->
    <section id=""blog "" class=""blog mt-5"">
      <div class=""container"" data-aos=""fade-up"">

        <div class=""row"">

          <div class=""col-lg-12 entries"">

            <article class=""entry"">

              <div class=""entry-img"">
                <img src=""https://res.cloudinary.com/dqab6gg7d/image/upload/v1677580644/Agusto/w4_qhto0w.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 528, "\"", 534, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
              </div>

              <h2 class=""entry-title"">
                <a href=""blog-single.html"">Agusto Tech Fuel station</a>
              </h2>

          

              <div class=""entry-content"">
                <p>
                 Welcome to our petrol station! We are delighted to offer you high-quality fuel products and excellent customer service. Whether you need petrol, diesel or any other fuel, we've got you covered. Our fuel is specially formulated to keep your engine running smoothly and efficiently, helping you to get the most out of your vehicle. Our friendly and knowledgeable staff are always on hand to assist you with any questions or concerns you may have. We invite you to visit our petrol station and experience the difference for yourself. Thank you for choosing us as your fuel provider! </p>
               
              </div>
               <section id=""pricing"" class=""pricing bg-none"">
      <div class=""container"">
            <h2 class=""entry-");
            WriteLiteral("title\">\r\n                <a href=\"blog-single.html\">Fuel prices</a>\r\n              </h2>\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 39 "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Website\products.cshtml"
               foreach (var item in  ViewBag.fuel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"col-lg-3 col-md-6 mt-4 mt-md-0\">\r\n            <div class=\"box featured\">\r\n              <h3>");
#nullable restore
#line 43 "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Website\products.cshtml"
             Write(item.Fuel_names);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("              <h4><sup>Ksh.</sup>");
#nullable restore
#line 47 "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Website\products.cshtml"
                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span></span></h4>\r\n             \r\n             \r\n            </div>\r\n          </div>\r\n");
#nullable restore
#line 52 "C:\Users\AMBIENT\source\repos\SHOP_DECOMPILED-master (2)\SHOP_DECOMPILED-master\Views\Website\products.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n\r\n        </div>\r\n\r\n      </div>\r\n    </section>\r\n            </article><!-- End blog entry -->\r\n\r\n            <!-- End Pricing Section -->\r\n\r\n\r\n          </div><!-- End blog entries list -->\r\n\r\n  </main><!-- End #main -->\r\n\r\n");
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
