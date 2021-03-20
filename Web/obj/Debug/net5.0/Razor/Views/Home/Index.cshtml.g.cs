#pragma checksum "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8a2507b0c38dd7b19a86f3c15a723e26f0d3af3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8a2507b0c38dd7b19a86f3c15a723e26f0d3af3", @"/Views/Home/Index.cshtml")]
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
                     foreach (var item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1211, "\"", 1242, 2);
            WriteAttributeValue("", 1218, "/products/index/", 1218, 16, true);
#nullable restore
#line 26 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1234, item.ID, 1234, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 28 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </ul>\r\n                <ul class=\"navbar-nav ms-auto mb-2 mb-lg-0\">\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8a2507b0c38dd7b19a86f3c15a723e26f0d3af38755", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8a2507b0c38dd7b19a86f3c15a723e26f0d3af310908", async() => {
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
#line 75 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                 foreach (var blog in Model.Blogs.Where(x=>x.IsActive == true))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3269, "\"", 3296, 2);
            WriteAttributeValue("", 3276, "blog/detail/", 3276, 12, true);
#nullable restore
#line 77 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3288, blog.ID, 3288, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"m-1\">\r\n                        <div class=\"card\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3388, "\"", 3408, 1);
#nullable restore
#line 79 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3394, blog.PhotoUrl, 3394, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <p class=\"card-text\">\r\n                                    ");
#nullable restore
#line 82 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                               Write(blog.PostName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n");
#nullable restore
#line 87 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!-- Card end -->\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n<section id=\"bookSection\" class=\"mt-3\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 102 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
             foreach (var ads in Model.Advertisements)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 col-sm-6 col-6 my-2\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4120, "\"", 4135, 1);
#nullable restore
#line 105 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4127, ads.Url, 4127, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8a2507b0c38dd7b19a86f3c15a723e26f0d3af315878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4191, "~/Uploads/", 4191, 10, true);
#nullable restore
#line 106 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4201, ads.PhotoURL, 4201, 13, false);

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
#line 109 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-10 col-md-12 col-sm-12 col-12\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 114 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                     foreach (var product in Model.Products)
                    {
                        Picture coverImage = PictureHelper.GetCoverImage(product.ProductPictures, product.ThumbnailPictureID);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- Card feed start -->\r\n                        <div class=\"col-lg-3 col-md-4 col-sm-6 col-6 mt-3\">\r\n                            <div class=\"card\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4854, "\"", 4889, 2);
            WriteAttributeValue("", 4861, "/Products/Detail/", 4861, 17, true);
#nullable restore
#line 120 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4878, product.ID, 4878, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"card-body p-3\">\r\n                                        <div class=\"Sectionsbooks\">\r\n                                            <div class=\"asdfg\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8a2507b0c38dd7b19a86f3c15a723e26f0d3af319205", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5171, "~/uploads/", 5171, 10, true);
#nullable restore
#line 124 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5181, product.Tags, 5181, 13, false);

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
#line 129 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
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
#line 136 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-2 col-md-12 col-sm-12 col-12 mt-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8a2507b0c38dd7b19a86f3c15a723e26f0d3af322027", async() => {
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
#line 146 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
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
#line 153 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6763, "\"", 6877, 1);
#nullable restore
#line 157 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 6770, Url.Action("index", "products", new { pageNo = Model.Pager.CurrentPage - 1, recordSize = Model.PageSize }), 6770, 107, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fas fa-angle-double-left\"></i>\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 161 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 163 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                         for (int ownpage = Model.Pager.StartPage; ownpage < Model.Pager.EndPage + 1; ownpage++)
                        {
                            var active = ownpage == Model.Pager.CurrentPage ? "active" : string.Empty;


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 7339, "\"", 7364, 2);
            WriteAttributeValue("", 7347, "page-item", 7347, 9, true);
#nullable restore
#line 167 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 7356, active, 7357, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7420, "\"", 7505, 1);
#nullable restore
#line 168 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 7427, Url.Action("Index","Home",new { pageNo=ownpage , recordSize=Model.PageSize }), 7427, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 169 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                               Write(ownpage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 172 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 174 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
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
#line 181 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 8227, "\"", 8335, 1);
#nullable restore
#line 185 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8234, Url.Action("Index","Home",new { pageNo = Model.Pager.CurrentPage + 1, recordSize = Model.PageSize }), 8234, 101, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"fas fa-angle-double-right\"></i>\r\n                                </a>\r\n\r\n                            </li>\r\n");
#nullable restore
#line 190 "C:\Users\veter\Desktop\K101Final\Web\Views\Home\Index.cshtml"
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
