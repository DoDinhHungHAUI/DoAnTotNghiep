#pragma checksum "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c07e9a392096a8ef4fc2e826cc9d3b0b16c42696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c07e9a392096a8ef4fc2e826cc9d3b0b16c42696", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a67328a0d80daa505f4da71fa5db14b7f4a81500", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DDHUNG.ApplicationCore.ViewModel.MenuHeaderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""container"">
    <a class=""navbar-brand"" href=""index.html"">Vegefoods</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#ftco-nav"" aria-controls=""ftco-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""oi oi-menu""></span> Menu
    </button>

    <div class=""collapse navbar-collapse"" id=""ftco-nav"">
        <ul class=""navbar-nav ml-auto"">

");
#nullable restore
#line 14 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
              
                var lstMenus = Model.ListMenuHeader;


                foreach (var menu in lstMenus)
                {
                    // có dropdown
                    if (menu.IsDropDown == 1)
                    {
                        var lstDropdowns = Model.ListProductCategory.Where(x => x.MenuHeaderId == menu.MenuHeaderId).ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item dropdown\">\r\n                            <a class=\"nav-link dropdown-toggle\"");
            BeginWriteAttribute("href", " href=\"", 990, "\"", 1012, 2);
            WriteAttributeValue("", 997, "/", 997, 1, true);
#nullable restore
#line 26 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 998, menu.MenuLink, 998, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"dropdown04\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">");
#nullable restore
#line 26 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                                                                                                                                                    Write(menu.MenuHeaderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <div class=\"dropdown-menu\" aria-labelledby=\"dropdown04\">\r\n\r\n");
#nullable restore
#line 29 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                 foreach (var dropDown in lstDropdowns)
                                {
                                    var urlCategory = dropDown.ProductCategoryLink + "-pc" +  ".html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1482, "\"", 1502, 2);
            WriteAttributeValue("", 1489, "/", 1489, 1, true);
#nullable restore
#line 32 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1490, urlCategory, 1490, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                                                             Write(dropDown.ProductCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 33 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 37 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1764, "\"", 1786, 2);
            WriteAttributeValue("", 1771, "/", 1771, 1, true);
#nullable restore
#line 41 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 1772, menu.MenuLink, 1772, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">");
#nullable restore
#line 41 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                                                                                   Write(menu.MenuHeaderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 42 "F:\C#\Đồ Án Tốt Nghiệp\DDHUNG.DoAnTotNghiep\DDHUNG.DoAnTotNghiep\Views\Shared\Components\Header\Default.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           
            <li class=""nav-item cta cta-colored"">
                <a href=""/gio-hang.html"" class=""nav-link"">
                    <span>
                        <!-- class=""icon-shopping_cart""-->
                        <i class=""fa fa-shopping-cart"" aria-hidden=""true""></i>
                    </span>[0]</a>
            </li>

        </ul>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DDHUNG.ApplicationCore.ViewModel.MenuHeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
