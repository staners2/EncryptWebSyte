#pragma checksum "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "084d4efe781fab20b5d1ca305110fb6b1ea4659d"
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
#line 1 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\_ViewImports.cshtml"
using EncryptWebSyte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\_ViewImports.cshtml"
using EncryptWebSyte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084d4efe781fab20b5d1ca305110fb6b1ea4659d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc71ebfb94523a5ce932c2a5a57ab1814b09efa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "084d4efe781fab20b5d1ca305110fb6b1ea4659d4009", async() => {
                WriteLiteral("\r\n    <title>Ecnrypt\\Descrypt text</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    .wrapper{
        display: flex;
        justify-content: space-around;
    }
    body {
        background: #e6f4fd;
        font-family: 'Roboto', sans-serif;
    }

    .ui-form {
        max-width: 350px;
        padding: 80px 30px 0px;
        margin: 50px auto 30px;
        background: white;
    }

    .ui-form textarea{
        resize: none;
    }

        .ui-form h3 {
            position: relative;
            z-index: 5;
            margin: 0 0 60px;
            text-align: center;
            color: #4a90e2;
            font-size: 30px;
            font-weight: normal;
        }

            .ui-form h3:before {
                content: """";
                position: absolute;
                z-index: -1;
                left: 60px;
                top: -30px;
                width: 100px;
                height: 100px;
                border-radius: 50%;
                background: #fee8e4;
            }

            .ui-form h3:after {
  ");
            WriteLiteral(@"              content: """";
                position: absolute;
                z-index: -1;
                right: 50px;
                top: -40px;
                width: 0;
                height: 0;
                border-left: 55px solid transparent;
                border-right: 55px solid transparent;
                border-bottom: 90px solid #ffe3b5;
            }

        .ui-form input[type=""submit""] {
            width: 100%;
            padding: 0;
            line-height: 42px;
            background: #4a90e2;
            border-width: 0;
            color: white;
            font-size: 20px;
            cursor: pointer;
        }

        .ui-form p {
            margin: 0;
            padding-top: 10px;
        }

    .form-row {
        position: relative;
        margin-bottom: 40px;
    }

        .form-row input {
            display: block;
            width: 100%;
            padding: 0 10px;
            line-height: 40px;
            font-family: 'Rob");
            WriteLiteral(@"oto', sans-serif;
            background: none;
            border-width: 0;
            border-bottom: 2px solid #4a90e2;
            -webkit-transition: all 0.2s ease;
            transition: all 0.2s ease;
        }

            .form-row input:focus {
                outline: 0;
                border-color: #F77A52;
            }

                .form-row input:focus + label, .form-row input:valid + label {
                    -webkit-transform: translateY(-60px);
                    transform: translateY(-60px);
                    margin-left: -14px;
                    font-size: 14px;
                    font-weight: 400;
                    outline: 0;
                    border-color: #F77A52;
                    color: #F77A52;
                }

        .form-row label {
            position: absolute;
            left: 13px;
            color: #9d959d;
            font-size: 20px;
            font-weight: 300;
");
            WriteLiteral("            -webkit-transition: all 0.2s ease;\r\n            transition: all 0.2s ease;\r\n        }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "084d4efe781fab20b5d1ca305110fb6b1ea4659d8252", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n        <div class=\"ui-form\">\r\n            <h3>Форма шифрования</h3>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "084d4efe781fab20b5d1ca305110fb6b1ea4659d8629", async() => {
                    WriteLiteral("\r\n                <input hidden type=\"text\" name=\"TypeOperation\" value=\"Encrypt\" />\r\n                <div class=\"form-row\">\r\n                    <input type=\"text\" name=\"InputText\"");
                    BeginWriteAttribute("value", " value=\"", 3652, "\"", 3685, 1);
#nullable restore
#line 135 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
WriteAttributeValue("", 3660, ViewBag.InputEncryptText, 3660, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <label for=\"InputText\">Введите текст:</label>\r\n                </div>\r\n                <div class=\"form-row\">\r\n                    <input type=\"text\" name=\"InputKey\"");
                    BeginWriteAttribute("value", " value=\"", 3876, "\"", 3908, 1);
#nullable restore
#line 139 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
WriteAttributeValue("", 3884, ViewBag.InputEncryptKey, 3884, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                    <label for=""InputKey"">Введите ключ шифрования:</label>
                </div>
                <p><input type=""submit"" value=""Зашифровать"" /></p>
                <div class=""form-row"">
                    <h2>Результат:</h2>
                    <textarea rows=""8"" cols=""46"" readonly wrap=""soft"" class=""ResultText"">");
#nullable restore
#line 145 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
                                                                                    Write(ViewBag.ResultEncryptText);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</textarea>\r\n                </div>\r\n                <div class=\"form-row\">\r\n                    <input readonly type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 4402, "\"", 4430, 1);
#nullable restore
#line 148 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
WriteAttributeValue("", 4410, ViewBag.DescryptKey, 4410, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <label for=\"InputEncryptKey\">Ключ расшифровки</label>\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n");
                WriteLiteral("        <div class=\"ui-form\">\r\n            <h3>Форма дешифрования</h3>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "084d4efe781fab20b5d1ca305110fb6b1ea4659d12816", async() => {
                    WriteLiteral("\r\n                <input hidden type=\"text\" name=\"TypeOperation\" value=\"Descrypt\" />\r\n                <div class=\"form-row\">\r\n                    <input type=\"text\" name=\"InputText\"");
                    BeginWriteAttribute("value", " value=\"", 5197, "\"", 5231, 1);
#nullable restore
#line 168 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
WriteAttributeValue("", 5205, ViewBag.InputDescryptText, 5205, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <label for=\"InputEncryptText\">Введите текст:</label>\r\n                </div>\r\n                <div class=\"form-row\">\r\n                    <input type=\"text\" name=\"InputKey\"");
                    BeginWriteAttribute("value", " value=\"", 5429, "\"", 5456, 1);
#nullable restore
#line 172 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
WriteAttributeValue("", 5437, ViewBag.EncryptKey, 5437, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" />
                    <label for=""InputEncryptKey"">Введите ключ шифрования:</label>
                </div>
                <p><input type=""submit"" value=""Расшифровать"" /></p>
                <div class=""form-row"">
                    <h2>Результат:</h2>
                    <textarea rows=""8"" cols=""46"" readonly wrap=""soft"" class=""ResultText"">");
#nullable restore
#line 178 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
                                                                                    Write(ViewBag.ResultDescryptText);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</textarea>\r\n                </div>\r\n                <div class=\"form-row\">\r\n                    <input readonly type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 5959, "\"", 5986, 1);
#nullable restore
#line 181 "D:\Visual Studio Project\EncryptWebSyte\EncryptWebSyte\Views\Home\Index.cshtml"
WriteAttributeValue("", 5967, ViewBag.EncryptKey, 5967, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    <label for=\"InputEncryptKey\">Ключ шифрования</label>\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
