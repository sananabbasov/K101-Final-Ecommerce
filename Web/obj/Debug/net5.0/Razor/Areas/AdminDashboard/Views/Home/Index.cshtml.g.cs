#pragma checksum "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf20c86eae5dff3fb6a292e487b2044a7ed34cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminDashboard_Views_Home_Index), @"mvc.1.0.view", @"/Areas/AdminDashboard/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\_ViewImports.cshtml"
using Web.Areas.AdminDashboard.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf20c86eae5dff3fb6a292e487b2044a7ed34cd", @"/Areas/AdminDashboard/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77a88665962a7bc03522e399ee3b4331f9cbc5b1", @"/Areas/AdminDashboard/Views/_ViewImports.cshtml")]
    public class Areas_AdminDashboard_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
  
    int? totalHit = 0;
    int totalProduct = 0;

    foreach (var item in Model.Products)
    {
        totalHit += item.Hit;
    }

    for (int i = 0; i < Model.Products.Count; i++)
    {
        totalProduct += 1;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<!-- top tiles -->\r\n<div class=\"row tile_count\">\r\n    <div class=\"col-md-2 col-sm-4 col-xs-6 tile_stats_count\">\r\n        <span class=\"count_top\"><i class=\"fa fa-area-chart\"></i> Məhsul baxışı</span>\r\n        <div class=\"count\">");
#nullable restore
#line 27 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
                      Write(totalHit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"col-md-2 col-sm-4 col-xs-6 tile_stats_count\">\r\n        <span class=\"count_top\"><i class=\"fa fa-clock-o\"></i> Məhsul sayı</span>\r\n        <div class=\"count\">");
#nullable restore
#line 31 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
                      Write(totalProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
            WriteLiteral(@"</div>
<!-- /top tiles -->


<table id=""example"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Məhsul adı</th>
            <th>Qiyməti</th>
            <th>Baxış</th>
            <th>İdentifikasiya</th>
            <th>User id</th>
            <th>Tənzimləmə</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 69 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
        foreach (var produc in Model.Products)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 72 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
           Write(produc.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 73 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
           Write(produc.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 74 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
           Write(produc.Hit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 75 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
           Write(produc.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
           Write(produc.Seller);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 2664, "\"", 2712, 2);
            WriteAttributeValue("", 2671, "admindashboard/products/delete/", 2671, 31, true);
#nullable restore
#line 79 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
WriteAttributeValue("", 2702, produc.ID, 2702, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i> Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\veter\Desktop\K101Final\Web\Areas\AdminDashboard\Views\Home\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
    <tfoot>
        <tr>
            <th>Məhsul adı</th>
            <th>Qiyməti</th>
            <th>Baxış</th>
            <th>İdentifikasiya</th>
            <th>Status</th>
            <th>Tənzimləmə</th>
        </tr>
    </tfoot>
</table>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
