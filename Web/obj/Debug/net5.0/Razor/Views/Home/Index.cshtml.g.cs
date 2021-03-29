#pragma checksum "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9584c959927640da06e2981d757126a9c2169cf2"
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
#line 1 "C:\Users\veter\Desktop\K101Final\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\veter\Desktop\K101Final\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\veter\Desktop\K101Final\Web\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\veter\Desktop\K101Final\Web\Views\_ViewImports.cshtml"
using Web.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9584c959927640da06e2981d757126a9c2169cf2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f046c160c2aef2da792986c96564730b9b6e8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/products/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/ads/ads_1.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Header Area -->
<section id=""header"">
    <nav class=""navbar navbar-expand-sm navbar-dark bg-bookstore"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""#"">
                <span class=""bg-succesas p-1""> B<i class=""bi bi-eyeglasses""></i>k Store</span>
            </a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                    data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav ms-auto mb-2 mb-lg-0"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" aria-current=""page"" href=""/"">Ana səhifə</a>
                    </li>
");
#nullable restore
#line 23 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                     foreach (var menu in Model.Categories.Where(x=>x.IsActive == true))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                         if (menu.ID == menu.ParentCategoryID)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""nav-item dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                    ");
#nullable restore
#line 29 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                               Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                                <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">\r\n");
#nullable restore
#line 32 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                                     foreach (var subItem in Model.Categories.Where(x => x.ParentCategoryID == menu.ParentCategoryID))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a class=\"dropdown-item\" href=\"#\">");
#nullable restore
#line 34 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                                                                         Write(subItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 35 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </li>\r\n");
#nullable restore
#line 39 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }
                        else if (menu.ParentCategoryID == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 2250, "\"", 2281, 2);
            WriteAttributeValue("", 2257, "/products/index/", 2257, 16, true);
#nullable restore
#line 43 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2273, menu.ID, 2273, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                                                                               Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 45 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </ul>\r\n                <ul class=\"navbar-nav ms-auto mb-2 mb-lg-0\">\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9584c959927640da06e2981d757126a9c2169cf211190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class=""aniFlex"">

    </div>
    <div class=""headerTextArea"">
        <div class=""container h-100 text-center"">
            <div class=""d-flex h-100 justify-content-between my-auto esas "">
                <div class=""col-12 my-auto"">
                    <h1 class=""display-4""><span style=""color: #ff5252;"">BOOK</span> Store</h1>

                    <div class=""col-lg-12"">
                        <blockquote class=""blockquote mb-0"">
                            <p class=""text-lenght"">
                                Dünya hamıya çatacaq qədər böyükdür. Başqasının yerini tutmağa çalışmaqdansa, öz
                                yerin haqqında fikirləş.
                            </p>
                            <footer class=""blockquote-footer""><cite title=""Source Title"">Ç.Çaplin</cite></footer>
                        </blockquote>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9584c959927640da06e2981d757126a9c2169cf213344", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" name=""search"" class=""form-control"" placeholder=""Məhsulun adını daxil edin"">
                            <input type=""submit"" class=""btn  btn-mainColor"" value=""Axtar"">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
</section>

<section id=""blogPost"" class=""my-3"">
    <div class=""container"">
        <div class=""row"">
            <div class=""responsive"">
                <!-- Card start -->
");
#nullable restore
#line 94 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                 foreach (var blog in Model.Blogs.Where(x=>x.IsActive == true))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 4341, "\"", 4368, 2);
            WriteAttributeValue("", 4348, "blog/detail/", 4348, 12, true);
#nullable restore
#line 96 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4360, blog.ID, 4360, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"m-1\">\r\n                        <div class=\"card\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4460, "\"", 4480, 1);
#nullable restore
#line 98 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4466, blog.PhotoUrl, 4466, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text\">\r\n                                    ");
#nullable restore
#line 101 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                               Write(blog.PostName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 106 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!-- Card end -->\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n<section id=\"bookSection\" class=\"mt-3\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 121 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
             foreach (var ads in Model.Advertisements)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 col-sm-6 col-6 my-2\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5192, "\"", 5207, 1);
#nullable restore
#line 124 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 5199, ads.Url, 5199, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9584c959927640da06e2981d757126a9c2169cf218316", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5263, "~/Uploads/", 5263, 10, true);
#nullable restore
#line 125 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5273, ads.PhotoURL, 5273, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 128 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-10 col-md-12 col-sm-12 col-12\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 133 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                     foreach (var product in Model.Products)
                    {
                        Picture coverImage = PictureHelper.GetCoverImage(product.ProductPictures, product.ThumbnailPictureID);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- Card feed start -->\r\n                        <div class=\"col-lg-3 col-md-4 col-sm-6 col-6 mt-3\">\r\n                            <div class=\"card\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5926, "\"", 5961, 2);
            WriteAttributeValue("", 5933, "/Products/Detail/", 5933, 17, true);
#nullable restore
#line 139 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 5950, product.ID, 5950, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"card-body p-3\">\r\n                                        <div class=\"Sectionsbooks\">\r\n                                            <div class=\"asdfg\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9584c959927640da06e2981d757126a9c2169cf221643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6243, "~/uploads/", 6243, 10, true);
#nullable restore
#line 143 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 6253, product.Tags, 6253, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
                                    <div class=""price m-2"">
                                        <span class=""badge bg-price"">");
#nullable restore
#line 148 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                                                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        <!-- <span class=""badge bg-price""><del>45 AZN</del></span> -->
                                    </div>
                                </a>
                            </div>
                        </div>
                        <!-- Card feed end -->
");
#nullable restore
#line 155 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-2 col-md-12 col-sm-12 col-12 mt-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9584c959927640da06e2981d757126a9c2169cf224465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"my-3 d-flex justify-content-between\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 165 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                         if (Model.Pager.CurrentPage == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""page-item disabled"">
                                <a class=""page-link disabled"" href=""#"">
                                    <i class=""fas fa-angle-double-left""></i>
                                </a>
                            </li>
");
#nullable restore
#line 172 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7835, "\"", 7949, 1);
#nullable restore
#line 176 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 7842, Url.Action("index", "products", new { pageNo = Model.Pager.CurrentPage - 1, recordSize = Model.PageSize }), 7842, 107, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fas fa-angle-double-left\"></i>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 180 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 182 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                         for (int ownpage = Model.Pager.StartPage; ownpage < Model.Pager.EndPage + 1; ownpage++)
                        {
                            var active = ownpage == Model.Pager.CurrentPage ? "active" : string.Empty;


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 8411, "\"", 8436, 2);
            WriteAttributeValue("", 8419, "page-item", 8419, 9, true);
#nullable restore
#line 186 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 8428, active, 8429, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 8492, "\"", 8577, 1);
#nullable restore
#line 187 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8499, Url.Action("Index","Home",new { pageNo=ownpage , recordSize=Model.PageSize }), 8499, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 188 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                               Write(ownpage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 191 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 193 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                         if (Model.Pager.CurrentPage == Model.Pager.EndPage)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""page-item disabled"">
                                <a class=""page-link disabled"">
                                    <i class=""fas fa-angle-double-right""></i>
                                </a>
                            </li>
");
#nullable restore
#line 200 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 9299, "\"", 9407, 1);
#nullable restore
#line 204 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 9306, Url.Action("Index","Home",new { pageNo = Model.Pager.CurrentPage + 1, recordSize = Model.PageSize }), 9306, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fas fa-angle-double-right\"></i>\r\n                                </a>\r\n\r\n                            </li>\r\n");
#nullable restore
#line 209 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
