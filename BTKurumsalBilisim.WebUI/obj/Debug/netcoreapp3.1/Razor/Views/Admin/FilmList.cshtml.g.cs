#pragma checksum "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a94ab6cf98354af8dc1e4a38199487216c06c531"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_FilmList), @"mvc.1.0.view", @"/Views/Admin/FilmList.cshtml")]
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
#line 2 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\_ViewImports.cshtml"
using BTKurumsalBilisim.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\_ViewImports.cshtml"
using BTKurumsalBilisim.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\_ViewImports.cshtml"
using BTKurumsalBilisim.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\_ViewImports.cshtml"
using BTKurumsalBilisim.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\_ViewImports.cshtml"
using BTKurumsalBilisim.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94ab6cf98354af8dc1e4a38199487216c06c531", @"/Views/Admin/FilmList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4595673abd0d68eeeda2c3831a9da63ab980461f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_FilmList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/images.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/FilmDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
  
    ViewData["Title"] = "Filmler Listesi";
    Layout = "~/Views/Shared/_SiteLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 7 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""row"">
    <div class=""col-md-12"">
        <hr>
        <a href=""/Admin/FilmCreate"" class=""btn btn-primary btn-sm"">Film Ekle</a>

        <p></p>

        <table class=""table table-bordered table-responsive table-striped table-hover"">
            <thead>
                <tr>
                    <td style=""width: 30px;"">#</td>
                    <td></td>
                    <td style=""width: 30px;"">Film Adı</td>
                    <td>Anasayfa</td>
                    <td>Onaylı</td>
                    <td style=""width: 150px;""></td>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 29 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                 if (Model.Films.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                     foreach (var item in Model.Films)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                           Write(item.FilmId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a94ab6cf98354af8dc1e4a38199487216c06c5318102", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 40 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                                 if (item.IsHome)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 43 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 48 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n\r\n                            <td>\r\n");
#nullable restore
#line 52 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                                 if (item.IsApproved)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 55 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 60 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2185, "\"", 2220, 2);
            WriteAttributeValue("", 2192, "/Admin/FilmEdit/", 2192, 16, true);
#nullable restore
#line 64 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
WriteAttributeValue("", 2208, item.FilmId, 2208, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Düzenle</a>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a94ab6cf98354af8dc1e4a38199487216c06c53112435", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"filmId\"");
                BeginWriteAttribute("value", " value=\"", 2449, "\"", 2469, 1);
#nullable restore
#line 67 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
WriteAttributeValue("", 2457, item.FilmId, 2457, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 74 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>Kayıt Yok</h3>\r\n                    </div>\r\n");
#nullable restore
#line 81 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Admin\FilmList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
