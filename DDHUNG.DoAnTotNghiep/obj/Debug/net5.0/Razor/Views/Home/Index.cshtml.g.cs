#pragma checksum "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a5fbd1a3af19e354ff3e0a4894b2717c8a1a3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\_ViewImports.cshtml"
using DDHUNG.DoAnTotNghiep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\_ViewImports.cshtml"
using DDHUNG.DoAnTotNghiep.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a5fbd1a3af19e354ff3e0a4894b2717c8a1a3d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a67328a0d80daa505f4da71fa5db14b7f4a81500", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DDHUNG.ApplicationCore.ViewModel.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CustomCss/ProductSection.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76a5fbd1a3af19e354ff3e0a4894b2717c8a1a3d4185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!--Slide -->\r\n<section id=\"home-section\" class=\"hero\">\r\n\r\n    ");
#nullable restore
#line 14 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n</section>\r\n\r\n\r\n<section class=\"ftco-section product-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center mb-3 pb-3\">\r\n            <div class=\"col-md-12 heading-section text-center ftco-animate\">\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                <span class=\"subheading\">Sản Phẩm Mới Nhất</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 35 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
              
                var lstProductLength = Model.ListProduct.Count;

                foreach (var item in Model.ListProduct)
                {
                    var urlImage = "/images/" + item.Image;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                        <div class=\"product\">\r\n                            <a href=\"#\" class=\"img-prod\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 1445, "", 1459, 1);
#nullable restore
#line 45 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 1450, urlImage, 1450, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Colorlib Template"">
                                <span class=""status"">30%</span>
                                <div class=""overlay""></div>
                            </a>
                            <div class=""text py-3 pb-4 px-3 text-center"">
                                <h3><a href=""#"">");
#nullable restore
#line 50 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <div class=\"d-flex\">\r\n                                    <div class=\"pricing\">\r\n                                        <p class=\"price\"><span class=\"mr-2 price-dc\">");
#nullable restore
#line 53 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                       (item.Price ?? 0).ToString("N0").Replace(",", ".");

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 53 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                                                          Write(item.PromotionPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                    </div>
                                </div>
                                <div class=""bottom-area d-flex px-3"">
                                    <div class=""m-auto d-flex"">
                                        <a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                            <span>
                                                <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                            </span>
                                        </a>
                                        <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1"">
                                            <span>
                                                <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                                            </span>
                                        </a>
                               ");
            WriteLiteral(@"         <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
                                            <span>
                                                <i class=""fa fa-heart"" aria-hidden=""true""></i>
                                            </span>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 78 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                }

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DDHUNG.ApplicationCore.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
