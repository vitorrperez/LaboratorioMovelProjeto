#pragma checksum "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\Professor\Detalhe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d78236b2b4f3170ee11a1d1c0507132db50b771e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Detalhe), @"mvc.1.0.view", @"/Views/Professor/Detalhe.cshtml")]
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
#line 1 "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\_ViewImports.cshtml"
using LaboratorioMovelProjeto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\_ViewImports.cshtml"
using LaboratorioMovelProjeto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78236b2b4f3170ee11a1d1c0507132db50b771e", @"/Views/Professor/Detalhe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eec12c4d8368af23ed849c089072d2869e1bd572", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Detalhe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfessorModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\Professor\Detalhe.cshtml"
  
    ViewData["Title"] = "Editar Professor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Detalhe Professor</h1>\r\n\r\n</div>\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 172, "\"", 180, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d78236b2b4f3170ee11a1d1c0507132db50b771e4275", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label\">Nome</label>\r\n            <input type=\"text\" class=\" form-control col-5\" name=\"Nome\"");
                BeginWriteAttribute("value", " value=\"", 369, "\"", 388, 1);
#nullable restore
#line 16 "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\Professor\Detalhe.cshtml"
WriteAttributeValue("", 377, Model.Nome, 377, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Email</label>\r\n            <input type=\"email\" class=\"form-control col-5\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 560, "\"", 580, 1);
#nullable restore
#line 21 "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\Professor\Detalhe.cshtml"
WriteAttributeValue("", 568, Model.Email, 568, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>DataNascimento</label>\r\n            <input type=\"date\" class=\"form-control col-5\" name=\"DataNascimento\"");
                BeginWriteAttribute("value", " value=\"", 769, "\"", 798, 1);
#nullable restore
#line 26 "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\Professor\Detalhe.cshtml"
WriteAttributeValue("", 777, Model.DataNascimento, 777, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly />\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Observa????o</label>\r\n            <textarea class=\"form-control col-10\" rows=\"3\" name=\"Observacao\"");
                BeginWriteAttribute("value", " value=\"", 980, "\"", 988, 0);
                EndWriteAttribute();
                WriteLiteral(" readonly>");
#nullable restore
#line 31 "C:\Users\vitor.perez\Documents\Codigos\Projeto pessoal\LaboratorioMovelProjeto\LaboratorioMovelProjeto\Views\Professor\Detalhe.cshtml"
                                                                                          Write(Model.Observacao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n\r\n        </div>\r\n\r\n        <a href=\"/Professor\" class=\"btn btn-secondary btn-lg\">Voltar</a>\r\n\r\n\r\n\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfessorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
