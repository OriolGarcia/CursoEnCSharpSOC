#pragma checksum "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Support\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e6d362c7bb21d6cefd190687cba864981da3d25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Support_Index), @"mvc.1.0.view", @"/Views/Support/Index.cshtml")]
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
#line 1 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\_ViewImports.cshtml"
using _20221118_NeptunoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\_ViewImports.cshtml"
using _20221118_NeptunoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e6d362c7bb21d6cefd190687cba864981da3d25", @"/Views/Support/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7f2d23314c7e102817fc4bdf80b7106fc94f54", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Support_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Support/SendMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validar()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Support\Index.cshtml"
  
	ViewData["Title"] = "Support";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col\">\r\n\t\t<h1>");
#nullable restore
#line 8 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Support\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t</div>\r\n</div>\r\n<div class=\"row\">\r\n\t<div class=\"col-md-6\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e6d362c7bb21d6cefd190687cba864981da3d255015", async() => {
                WriteLiteral(@"
			<!-- codigo Validacion formulario.Codigo anti Forgery-->
			<div class=""form-group row"">
				<label for=""txtNombre"" class=""col-sm-3 col-form-label"">Nombre*:</label>
				<div class=""col-sm-9"">
					<input type=""text"" class=""form-control"" id=""txtNombre"" 
						name=""txtNombre"" placeholder=""Nombre completo"" required>
				</div>
			</div>
			<div class=""form-group row"">
				<label for=""txtEmail"" class=""col-sm-3 col-form-label"">Email*:</label>
				<div class=""col-sm-9"">
					<input type=""email"" class=""form-control"" id=""txtEmail""
						   name=""txtEmail"" placeholder=""Email"" required>
				</div>
			</div>
			<div class=""form-group row"">
				<label for=""txtPhone"" class=""col-sm-3 col-form-label"">Teléfono:</label>
				<div class=""col-sm-9"">
					<input type=""text"" class=""form-control"" id=""txtTelefono""
						   name=""txtTelefono"" placeholder=""Teléfono"">
				</div>
			</div>
			<div class=""form-group row"">
				<label for=""txtTema"" class=""col-sm-3 col-form-label"">Tema*:</label>
				<div class=");
                WriteLiteral(@"""col-sm-9"">
					<input type=""text"" class=""form-control"" id=""txtTema""
						   name=""txtTema"" placeholder=""Tema"" required>
				</div>
			</div>
			<div class=""form-group row"">
				<label for=""txtMensaje"" class=""col-sm-3 col-form-label"">Mensaje*:</label>
				<div class=""col-sm-9"">
					<textarea class=""form-control"" id=""txtMensaje"" name=""txtMensaje"" 
						rows=""10"" required></textarea>
				</div>
			</div>
			<div class=""form-group row"">
				<label");
                BeginWriteAttribute("for", " for=\"", 1744, "\"", 1750, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"col-sm-3 col-form-label\"></label>\r\n\t\t\t\t<div class=\"col-sm-9\">\r\n\t\t\t\t\t<input type=\"submit\" class=\"btn btn-primary\" value=\"Enviar\" />\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"col-md-6\">\r\n\t\t<!-- Información de contacto -->\r\n\t\t<h2>Contacto</h2>\r\n\t\t<ul>\r\n\t\t\t<li>Neptuno</li>\r\n\t\t\t<li>Calle demostración, 13</li>\r\n\t\t\t<li>....</li>\r\n\t\t\t<li>....</li>\r\n\t\t</ul>\r\n\r\n\t</div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
