#pragma checksum "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7527c9b18fb4f1723943ddb6bbb187a159bb7472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Detail), @"mvc.1.0.view", @"/Views/Products/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7527c9b18fb4f1723943ddb6bbb187a159bb7472", @"/Views/Products/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f046c160c2aef2da792986c96564730b9b6e8da", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/2.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/3.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/4.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/5.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/6.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
  
    ViewData["Title"] = Model.Product.ProductName;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""header"">
    <div class=""aniFlex"">

    </div>
    <div class=""headerTextArea"">
        <div class=""container h-100 text-center"">
            <div class=""d-flex h-100 justify-content-between my-auto esas "">
                <div class=""col-12 my-auto"">
                    <h1 class=""display-4""><span style=""color: #ff5252;"">BOOK</span> Store</h1>
                    <p class=""text-lenght"">
                        <div class=""col-lg-12"">
                            <blockquote class=""blockquote mb-0"">
                                D??nya ham??ya ??atacaq q??d??r b??y??kd??r. Ba??qas??n??n yerini tutma??a ??al????maqdansa, ??z
                                yerin haqq??nda fikirl????.
                                <footer class=""blockquote-footer""><cite title=""Source Title"">??.??aplin</cite></footer>
                            </blockquote>

                        </div>
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>


<section id");
            WriteLiteral(@"=""bookDetail"" class=""mt-3"">
    <div class=""container"">
        <div class=""row"">
            <!-- Card feed start -->
            <div class=""col-lg-3 col-md-4 col-sm-6 col-12 mt-3"">
                <div class=""cards"">
                    <div class=""card-body p-3"">
                        <div class=""Sectionsbook"">
                            <div class=""asdfg"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7527c9b18fb4f1723943ddb6bbb187a159bb74727875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1547, "~/uploads/", 1547, 10, true);
#nullable restore
#line 41 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 1557, Model.Product.Tags, 1557, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            </div>
            <div class=""col-lg-8 col-md-8 col-sm-12 col-12 mt-3"">
                <div class=""cards mt-4"">
                    <h3 class=""card-title"">
                        Lorem ipsum dolor sit amet consectetur
                    </h3>
                    <p><b>54 AZN</b></p>
                    <p><b>Sat??c?? :</b> ");
#nullable restore
#line 53 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
                                  Write(Model.Product.Supplier);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><a class=\"callSeller\"");
            BeginWriteAttribute("href", " href=\"", 2126, "\"", 2158, 2);
            WriteAttributeValue("", 2133, "tel:", 2133, 4, true);
#nullable restore
#line 54 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
WriteAttributeValue("", 2137, Model.Product.Number, 2137, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Z??ng et</a></p>\r\n                    <ul class=\"list-group list-group-flush\">\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"far fa-check-circle\"></i> <b>Janr :</b> ");
#nullable restore
#line 57 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
                                                                         Write(Model.Product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"far fa-check-circle\"></i> <b>N????riyyat :</b> ");
#nullable restore
#line 60 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
                                                                              Write(Model.Product.Publishing);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"far fa-check-circle\"></i> <b>M????llif :</b> ");
#nullable restore
#line 63 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
                                                                            Write(Model.Product.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            <i class=\"far fa-check-circle\"></i> <b>S??hif?? :</b> ");
#nullable restore
#line 66 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
                                                                           Write(Model.Product.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                    <p>\r\n                        ");
#nullable restore
#line 70 "C:\Users\veter\Desktop\K101Final\Web\Views\Products\Detail.cshtml"
                   Write(Html.Raw(Model.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
            </div>
        </div>
    </div>

</section>

<div class=""container"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">
        <div class=""row"">
            <!-- Card feed start -->
            <div class=""col-lg-2 col-md-4 col-sm-6 col-6 mt-3"">
                <div class=""card"">
                    <a href=""#"">
                        <div class=""card-body p-3"">
                            <div class=""Sectionsbook"">
                                <div class=""asdfg"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7527c9b18fb4f1723943ddb6bbb187a159bb747213582", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            <span class=""badge bg-price"">45 AZN</span>
                            <!-- <span class=""badge bg-price""><del>45 AZN</del></span> -->
                        </div>
                    </a>
                </div>
            </div>
            <!-- Card feed end -->
            <!-- Card feed start -->
            <div class=""col-lg-2 col-md-4 col-sm-6 col-6 mt-3"">
                <div class=""card"">
                    <a href=""#"">
                        <div class=""card-body p-3"">
                            <div class=""Sectionsbook"">
                                <div class=""asdfg"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7527c9b18fb4f1723943ddb6bbb187a159bb747215627", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            <span class=""badge bg-price"">7 AZN</span>
                            <!-- <span class=""badge bg-price""><del>45 AZN</del></span> -->
                        </div>
                    </a>
                </div>
            </div>
            <!-- Card feed end -->
            <!-- Card feed start -->
            <div class=""col-lg-2 col-md-4 col-sm-6 col-6 mt-3"">
                <div class=""card"">
                    <a href=""#"">
                        <div class=""card-body p-3"">
                            <div class=""Sectionsbook"">
                                <div class=""asdfg"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7527c9b18fb4f1723943ddb6bbb187a159bb747217671", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            <span class=""badge bg-price"">14 AZN</span>
                            <!-- <span class=""badge bg-price""><del>45 AZN</del></span> -->
                        </div>
                    </a>
                </div>
            </div>
            <!-- Card feed end -->
            <!-- Card feed start -->
            <div class=""col-lg-2 col-md-4 col-sm-6 col-6 mt-3"">
                <div class=""card"">
                    <a href=""#"">
                        <div class=""card-body p-3"">
                            <div class=""Sectionsbook"">
                                <div class=""asdfg"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7527c9b18fb4f1723943ddb6bbb187a159bb747219716", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            <span class=""badge bg-price"">21 AZN</span>
                            <!-- <span class=""badge bg-price""><del>45 AZN</del></span> -->
                        </div>
                    </a>
                </div>
            </div>
            <!-- Card feed end -->
            <!-- Card feed start -->
            <div class=""col-lg-2 col-md-4 col-sm-6 col-6 mt-3"">
                <div class=""card"">
                    <a href=""#"">
                        <div class=""card-body p-3"">
                            <div class=""Sectionsbook"">
                                <div class=""asdfg"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7527c9b18fb4f1723943ddb6bbb187a159bb747221761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            <span class=""badge bg-price"">18 AZN</span>
                            <!-- <span class=""badge bg-price""><del>45 AZN</del></span> -->
                        </div>
                    </a>
                </div>
            </div>
            <!-- Card feed end -->
            <!-- Card feed start -->
            <div class=""col-lg-2 col-md-4 col-sm-6 col-6 mt-3"">
                <div class=""card"">
                    <a href=""#"">
                        <div class=""card-body p-3"">
                            <div class=""Sectionsbook"">
                                <div class=""asdfg"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7527c9b18fb4f1723943ddb6bbb187a159bb747223806", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            <span class=""badge bg-price"">32 AZN</span>
                            <!-- <span class=""badge bg-price""><del>45 AZN</del></span> -->
                        </div>
                    </a>
                </div>
            </div>
            <!-- Card feed end -->
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
