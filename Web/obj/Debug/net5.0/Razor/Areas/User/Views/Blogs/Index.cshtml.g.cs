#pragma checksum "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d876316d758e30c53954a972f39566ef5c7d77d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Blogs_Index), @"mvc.1.0.view", @"/Areas/User/Views/Blogs/Index.cshtml")]
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
#line 1 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\_ViewImports.cshtml"
using Web.Areas.User.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\_ViewImports.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d876316d758e30c53954a972f39566ef5c7d77d1", @"/Areas/User/Views/Blogs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a02f319a560de993cf6932b649af253b26448e5e", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Blogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d876316d758e30c53954a972f39566ef5c7d77d14075", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </p>

        <table id=""example"" class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Məqalə</th>
                    <th>Yazıçı</th>
                    <th>Baxış</th>
                    <th>Status</th>
                    <th>Tarix</th>
                    <th>Tənzimləmə</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                  
                    string yoxla = @ViewBag.userId;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                 foreach (var blog in Model.Where(x => x.UserID == yoxla))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                       Write(blog.PostName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                       Write(blog.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                       Write(blog.Hit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 36 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                             if (blog.IsDeleted == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-danger\">Geri çevrilib</span>\r\n");
#nullable restore
#line 39 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                            }
                            else if (blog.IsActive == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-success\">Təsdiqlənib</span>\r\n");
#nullable restore
#line 43 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"label label-warning\">Gözləmədə</span>\r\n");
#nullable restore
#line 47 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                       Write(blog.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1763, "\"", 1804, 2);
            WriteAttributeValue("", 1770, "admindashboard/blogs/edit/", 1770, 26, true);
#nullable restore
#line 52 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 1796, blog.ID, 1796, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i> Sil</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "C:\Users\veter\Desktop\K101Final\Web\Areas\User\Views\Blogs\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
            <tfoot>
                <tr>
                    <th>Məqalə</th>
                    <th>Yazıçı</th>
                    <th>Baxış</th>
                    <th>Status</th>
                    <th>Tarix</th>
                    <th>Tənzimləmə</th>
                </tr>
            </tfoot>
        </table>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
