#pragma checksum "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "550de5d53a43b709517e9336a56e23a1bd738307"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rols_RolEdit), @"mvc.1.0.view", @"/Views/Rols/RolEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"550de5d53a43b709517e9336a56e23a1bd738307", @"/Views/Rols/RolEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4595673abd0d68eeeda2c3831a9da63ab980461f", @"/Views/_ViewImports.cshtml")]
    public class Views_Rols_RolEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rols", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RolEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
  
    ViewData["Title"] = $"{Model.Role.Name} düzenleme formu";
    Layout = "~/Views/Shared/_SiteLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 7 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550de5d53a43b709517e9336a56e23a1bd7383076103", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550de5d53a43b709517e9336a56e23a1bd7383076373", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 432, "\"", 454, 1);
#nullable restore
#line 15 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
WriteAttributeValue("", 440, Model.Role.Id, 440, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 510, "\"", 534, 1);
#nullable restore
#line 17 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
WriteAttributeValue("", 518, Model.Role.Name, 518, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <h6 class=\"bg-info text-white p-1\">Add to ");
#nullable restore
#line 19 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                                                 Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n\r\n            <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 22 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                 if (Model.NonMembers.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">Bütün kullanıcılar role ait</td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                }

                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                     foreach (var user in Model.NonMembers)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 35 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width:150px;\">\r\n                                <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 1297, "\"", 1313, 1);
#nullable restore
#line 38 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
WriteAttributeValue("", 1305, user.Id, 1305, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n            <hr />\r\n\r\n            <h6 class=\"bg-info text-white p-1\">Remove to ");
#nullable restore
#line 47 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                                                    Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n\r\n            <table class=\"table table-bordered table-sm\">\r\n");
#nullable restore
#line 50 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                 if (Model.Members.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">Role ait kullanıcı yok</td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                }

                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                     foreach (var user in Model.Members)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"width:150px;\">\r\n                                <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 2223, "\"", 2239, 1);
#nullable restore
#line 66 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
WriteAttributeValue("", 2231, user.Id, 2231, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\emirt\source\repos\DotnetCoreProjeleri\BTKurumsalBilisim\BTKurumsalBilisim.WebUI\Views\Rols\RolEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n");
                WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Kaydet\" class=\"btn btn-primary\" />\r\n                <a href=\"/Rols/RoleList\" class=\"btn btn-danger\">İptal</a>\r\n            </div>\r\n\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591