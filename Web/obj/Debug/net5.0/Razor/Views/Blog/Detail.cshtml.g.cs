#pragma checksum "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de27746be1e1cec84dad91f4f4d85e8fa5dd0d6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de27746be1e1cec84dad91f4f4d85e8fa5dd0d6c", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f046c160c2aef2da792986c96564730b9b6e8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section id=""header"" style=""height: 30vh;"">
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
#line 24 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
                     foreach (var item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1289, "\"", 1320, 2);
            WriteAttributeValue("", 1296, "/products/index/", 1296, 16, true);
#nullable restore
#line 27 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 1312, item.ID, 1312, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </li>\r\n");
#nullable restore
#line 29 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </ul>\r\n                <ul class=\"navbar-nav ms-auto mb-2 mb-lg-0\">\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de27746be1e1cec84dad91f4f4d85e8fa5dd0d6c6938", async() => {
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
    <div class=""headerTextArea"" style=""height: 30vh;"">
        <div class=""container h-100 text-center"">
            <div class=""d-flex h-100 justify-content-between my-auto esas "">
                <div class=""col-12 my-auto"">
                    <h1 class=""display-4""><span style=""color: #ff5252;"">BOOK</span> Store</h1>
                    <p class=""text-lenght"">
                        <div class=""col-lg-12"">
                            <blockquote class=""blockquote mb-0"">
                    <p>
                        Dünya hamıya çatacaq qədər böyükdür. Başqasının yerini tutmağa çalışmaqdansa, öz
                        yerin haqqında fikirləş.
                    </p>
                    <footer class=""blockquote-footer""><cite title=""Source Title"">Ç.Çaplin</cite></footer>
                    </blockquote>

                </div>
                </p>
            </div>
            <!-- <di");
            WriteLiteral(@"v class=""my-auto"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""perspectiv"">
                            <div class=""book3D"">
                                <div class=""cover"">
                                    <figure class=""front""></figure>
                                    <figure class=""back""></figure>
                                </div>
                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Omnis nesciunt
                                    doloribus accusamus ex, repudiandae ratione quam!</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div> -->
        </div>
    </div>
    </div>
</section>

<section id=""bookSection"" class=""mt-3"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-sm-6 col-6 my-2"">
                <img class=""img-flu");
            WriteLiteral("id\" src=\"../BookShop/img/ads/ads_3.PNG\"");
            BeginWriteAttribute("alt", " alt=\"", 3667, "\"", 3673, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-6 col-sm-6 col-6 my-2\">\r\n                <img class=\"img-fluid\" src=\"../BookShop/img/ads/ads_4.PNG\"");
            BeginWriteAttribute("alt", " alt=\"", 3836, "\"", 3842, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-6 col-sm-6 col-6 my-2\">\r\n                <img class=\"img-fluid\" src=\"../BookShop/img/ads/ads_5.PNG\"");
            BeginWriteAttribute("alt", " alt=\"", 4005, "\"", 4011, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-lg-3 col-md-6 col-sm-6 col-6 my-2\">\r\n                <img class=\"img-fluid\" src=\"../BookShop/img/ads/ads_6.PNG\"");
            BeginWriteAttribute("alt", " alt=\"", 4174, "\"", 4180, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
        <div class=""row"">
            <!-- Blog feed start -->
            <div class=""col-lg-9 col-md-12 col-sm-12 col-12 mt-3"">
                <div class=""blogs"">
                    <div class=""card mb-3"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 4463, "\"", 4489, 1);
#nullable restore
#line 101 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 4469, Model.Blog.PhotoUrl, 4469, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">\r\n                                ");
#nullable restore
#line 104 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
                           Write(Model.Blog.PostName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h5>\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 107 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
                           Write(Model.Blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                        </div>
                    </div>
                </div>

            </div>
            <!-- Blog feed end -->
            <div class=""col-lg-3 col-md-12 col-sm-12 col-12"">
                <div class=""row"">
                    <!-- Card feed start -->
");
#nullable restore
#line 119 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
                     foreach (var product in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6 col-md-4 col-sm-6 col-6 mt-3\">\r\n                            <div class=\"card\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5499, "\"", 5534, 2);
            WriteAttributeValue("", 5506, "/products/detail/", 5506, 17, true);
#nullable restore
#line 123 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 5523, product.ID, 5523, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"card-body p-3\">\r\n                                        <div class=\"Sectionsbook\">\r\n                                            <div class=\"asdfg\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "de27746be1e1cec84dad91f4f4d85e8fa5dd0d6c14306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5815, "~/uploads/", 5815, 10, true);
#nullable restore
#line 127 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 5825, product.Tags, 5825, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
#line 132 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
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
");
#nullable restore
#line 138 "C:\Users\veter\Desktop\K101Final\Web\Views\Blog\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- Card feed end -->\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591