#pragma checksum "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0089ab629719f3a07e1dd3559c7051bdd85ac65c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
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
#line 1 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0089ab629719f3a07e1dd3559c7051bdd85ac65c", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4c1f8a331756813dc62d0a9e9a6b6778f02506", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"page-consent\">\n    <div class=\"row page-header\">\n        <div class=\"col-sm-10\">\n");
#line 6 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            WriteLiteral("                <div class=\"client-logo\"><img");
            BeginWriteAttribute("src", " src=\"", 223, "\"", 249, 1);
#line 8 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
WriteAttributeValue("", 229, Model.ClientLogoUrl, 229, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral("></div>\n");
#line 9 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
            WriteLiteral("            <h1>\n                ");
#line 11 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            WriteLiteral("\n                <small>is requesting your permission</small>\n            </h1>\n        </div>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-8\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0089ab629719f3a07e1dd3559c7051bdd85ac65c6490", async() => {
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
            WriteLiteral("\n            \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0089ab629719f3a07e1dd3559c7051bdd85ac65c7630", async() => {
                WriteLiteral("\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0089ab629719f3a07e1dd3559c7051bdd85ac65c7902", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 22 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                <div>Uncheck the permissions you do not wish to grant.</div>\n                \n");
#line 26 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
#line 34 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {

#line default
#line hidden
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0089ab629719f3a07e1dd3559c7051bdd85ac65c10522", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 36 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#line 37 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                            }

#line default
#line hidden
                WriteLiteral("                        </ul>\n                    </div>\n");
#line 40 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                WriteLiteral("\n");
#line 42 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Application Access
                        </div>
                        <ul class=""list-group"">
");
#line 50 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {

#line default
#line hidden
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0089ab629719f3a07e1dd3559c7051bdd85ac65c13384", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 52 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#line 53 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                            }

#line default
#line hidden
                WriteLiteral("                        </ul>\n                    </div>\n");
#line 56 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                WriteLiteral("\n");
#line 58 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
                WriteLiteral("                    <div class=\"consent-remember\">\n                        <label>\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0089ab629719f3a07e1dd3559c7051bdd85ac65c15749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 62 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            <strong>Remember My Decision</strong>\n                        </label>\n                    </div>\n");
#line 66 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                WriteLiteral("\n                <div class=\"consent-buttons\">\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\n");
#line 71 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
                WriteLiteral("                        <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 2885, "\"", 2908, 1);
#line 73 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
WriteAttributeValue("", 2892, Model.ClientUrl, 2892, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                WriteLiteral(">\n                            <span class=\"glyphicon glyphicon-info-sign\"></span>\n                            <strong>");
#line 75 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                               Write(Model.ClientName);

#line default
#line hidden
                WriteLiteral("</strong>\n                        </a>\n");
#line 77 "C:\Users\Barrie\source\repos\AuthzAuthn\Authentication\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                WriteLiteral("                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
