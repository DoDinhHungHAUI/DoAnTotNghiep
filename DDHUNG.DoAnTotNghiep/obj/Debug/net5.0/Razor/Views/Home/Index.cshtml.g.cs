#pragma checksum "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4788c5d53ca4a65239ffa393c2b2b449e54c6ad1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4788c5d53ca4a65239ffa393c2b2b449e54c6ad1", @"/Views/Home/Index.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4788c5d53ca4a65239ffa393c2b2b449e54c6ad14185", async() => {
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
            WriteLiteral(";\r\n\r\n</section>\r\n\r\n");
#nullable restore
#line 18 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
 if (Model.PhoneLatests.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""ftco-section product-section"">
        <div class=""container"">
            <div class=""row justify-content-center mb-3 pb-3"">
                <div class=""col-md-12 heading-section text-center ftco-animate"">

                    <span class=""subheading"">Điện Thoại Mới Nhất</span>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">

");
#nullable restore
#line 32 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                  

                    foreach (var item in Model.PhoneLatests)
                    {
                        var urlImage = "";

                        // Điện thoại
                        urlImage = "/images/ImageProduct/DienThoai/" + item.Image;

                        var urlProductDetail = "/" + "san-pham-chi-tiet" + "/" + item.ProductId + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                            <div class=\"product\">\r\n                                <a href=\"#\" class=\"img-prod\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 1400, "", 1414, 1);
#nullable restore
#line 46 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 1405, urlImage, 1405, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Colorlib Template"">
                                    <span class=""status"">30%</span>
                                    <div class=""overlay""></div>
                                </a>
                                <div class=""text py-3 pb-4 px-3 text-center"">
                                    <h3>
                                        <a href=""#""");
            BeginWriteAttribute("title", " title=\"", 1785, "\"", 1810, 1);
#nullable restore
#line 52 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 1793, item.ProductName, 1793, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"product-name-text\">");
#nullable restore
#line 53 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                      Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                        </a>
                                    </h3>
                                    <div class=""d-flex"">
                                        <div class=""pricing"">
                                            <p class=""price"">
");
#nullable restore
#line 59 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                 if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-dc\">");
#nullable restore
#line 61 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                            Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 61 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                                                                                                       Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 62 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-sale\">");
#nullable restore
#line 65 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                              Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 66 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </p>
                                        </div>
                                    </div>
                                    <div class=""bottom-area d-flex px-3"">
                                        <div class=""m-auto d-flex"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 3430, "\"", 3454, 1);
#nullable restore
#line 72 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 3437, urlProductDetail, 3437, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                                <span>
                                                    <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                                </span>
                                            </a>
                                            <a class=""buy-now d-flex justify-content-center align-items-center mx-1 btnAddToCart"" data-id=""");
#nullable restore
#line 77 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                      Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                <span>
                                                    <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                                                </span>
                                            </a>
                                            <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
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
#line 92 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 99 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 103 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
 if (Model.LaptopLatests.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"ftco-section product-section\">\r\n        <div class=\"container\">\r\n            <div class=\"row justify-content-center mb-3 pb-3\">\r\n                <div class=\"col-md-12 heading-section text-center ftco-animate\">\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                    <span class=\"subheading\">Laptop Mới Nhất</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 121 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                  

                    foreach (var item in Model.LaptopLatests)
                    {
                        var urlImage = "";

                        // Điện thoại
                        urlImage = "/images/ImageProduct/Laptop/" + item.Image;

                        var urlProductDetail = "/" + "san-pham-chi-tiet" + "/" + item.ProductId + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                            <div class=\"product\">\r\n                                <a href=\"#\" class=\"img-prod\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 6338, "", 6352, 1);
#nullable restore
#line 135 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 6343, urlImage, 6343, 9, false);

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
#line 140 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <div class=\"d-flex\">\r\n                                        <div class=\"pricing\">\r\n                                            <p class=\"price\">\r\n");
#nullable restore
#line 144 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                 if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-dc\">");
#nullable restore
#line 146 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                            Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 146 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                                                                                                       Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 147 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-sale\">");
#nullable restore
#line 150 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                              Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 151 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </p>
                                        </div>
                                    </div>
                                    <div class=""bottom-area d-flex px-3"">
                                        <div class=""m-auto d-flex"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 8137, "\"", 8161, 1);
#nullable restore
#line 157 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 8144, urlProductDetail, 8144, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                                <span>
                                                    <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                                </span>
                                            </a>
                                            <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1 btnAddToCart"" data-id=""");
#nullable restore
#line 162 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                               Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                <span>
                                                    <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                                                </span>
                                            </a>
                                            <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
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
#line 177 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 184 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 187 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
 if (Model.TabletLatests.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""ftco-section product-section"">
        <div class=""container"">
            <div class=""row justify-content-center mb-3 pb-3"">
                <div class=""col-md-12 heading-section text-center ftco-animate"">
                    <span class=""subheading"">Máy Tính Bảng Mới Nhất</span>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">

");
#nullable restore
#line 200 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                  

                    foreach (var item in Model.TabletLatests)
                    {
                        var urlImage = "";

                        // Điện thoại
                        urlImage = "/images/ImageProduct/MayTinhBang/" + item.Image;

                        var urlProductDetail = "/" + "san-pham-chi-tiet" + "/" + item.ProductId + ".html";


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                            <div class=\"product\">\r\n                                <a href=\"#\" class=\"img-prod\">\r\n                                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 10742, "", 10756, 1);
#nullable restore
#line 214 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 10747, urlImage, 10747, 9, false);

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
#line 219 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <div class=\"d-flex\">\r\n                                        <div class=\"pricing\">\r\n                                            <p class=\"price\">\r\n");
#nullable restore
#line 223 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                 if (item.PromotionPrice != null && item.PromotionPrice != 0)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-dc\">");
#nullable restore
#line 225 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                            Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span><span class=\"price-sale\">");
#nullable restore
#line 225 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                                                                                                       Write((Math.Round((decimal)item.PromotionPrice, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 226 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"mr-2 price-sale\">");
#nullable restore
#line 229 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                              Write((Math.Round((decimal)item.Price, 0, MidpointRounding.AwayFromZero)).ToString("N0").Replace(",", "."));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vnđ</span>\r\n");
#nullable restore
#line 230 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </p>
                                        </div>
                                    </div>
                                    <div class=""bottom-area d-flex px-3"">
                                        <div class=""m-auto d-flex"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 12541, "\"", 12565, 1);
#nullable restore
#line 236 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
WriteAttributeValue("", 12548, urlProductDetail, 12548, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                                <span>
                                                    <i class=""fa fa-bars"" aria-hidden=""true""></i>
                                                </span>
                                            </a>
                                            <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1 btnAddToCart"" data-id=""");
#nullable restore
#line 241 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                                                                                                                                               Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                <span>
                                                    <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                                                </span>
                                            </a>
                                            <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
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
#line 256 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 263 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
