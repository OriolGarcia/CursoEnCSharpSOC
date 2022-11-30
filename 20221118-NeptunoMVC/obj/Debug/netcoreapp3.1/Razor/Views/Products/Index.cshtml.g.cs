#pragma checksum "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b81a141c469dae72c6ee113971a9c72d88b5f68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
using _20221118_NeptunoMVC.Dal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b81a141c469dae72c6ee113971a9c72d88b5f68", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7f2d23314c7e102817fc4bdf80b7106fc94f54", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
  
	ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
  
	ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col\" style=\"text-align:center;margin-bottom:25px;\">\r\n\t\t<h1>");
#nullable restore
#line 12 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t</div>\r\n</div>\r\n<!-- Panel filtrado-->\r\n<div class=\"row\" style=\"margin-bottom:20px\">\r\n\t<div class=\"col text-center\">\r\n\t\tCategorias: ");
#nullable restore
#line 18 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
               Write(Html.Raw(@ViewData["cmbCategorias"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\tTexto:");
#nullable restore
#line 19 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
         Write(Html.Raw(@ViewData["txtTexto"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
		<input type=""button"" class=""btn btn-primary"" value=""Buscar"" onclick=""search();""/>
	</div>
</div>
<div class=""row"">
	<div class=""col"">
		<div class=""table-responsive"">
			<table class=""table table-bordered table-striped"">
				<tr>
					<th>Image</th>
					<th>Product</th>
					<th>Category</th>
					<th>Price</th>
					<th>Stock</th>
					<th>State</th>
					<th>Options</th>
				</tr>
");
#nullable restore
#line 36 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
                  
					foreach (var item in (List<ProductSlim>)ViewData["products"])
					{
						string imagen = "";
						string nombreImagen = item.ProductId + "lr.jpg";
						string nombreImagenHR = item.ProductId + "hr.jpg";
						var path = (string)AppDomain.CurrentDomain.GetData("WebRootPath") + 
							"wwwroot\\images\\products\\" + nombreImagen;

						if (File.Exists(path))
						{
							imagen = "<a href='/images/products/" + nombreImagenHR + "' " +
									"data-lightbox='image-"+item.ProductId+"' data-title='" + item.ProductName + "'> " +
											"<img src='/images/products/" + nombreImagen + "' height='75' />" +
										"</a>";
						}

						//Formateado de datos
						string strPrice = ((decimal)item.Price).ToString("N2");
						string strState = (item.State) ? "Active" : "Discontinued";
						strState="<a href='javascript:void(0);' onClick='changeState("+item.ProductId+");'>"+strState+"</a>";
						
						
						

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 62 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
                                                                           Write(Html.Raw(imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1995, "\"", 2036, 2);
            WriteAttributeValue("", 2002, "/Products/Detail?p=", 2002, 19, true);
#nullable restore
#line 65 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2021, item.ProductId, 2021, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 66 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
                                                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 69 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
                                                                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 70 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
                                                                           Write(strPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 71 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
                                                                           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td");
            BeginWriteAttribute("id", " id=\"", 2282, "\"", 2308, 2);
            WriteAttributeValue("", 2287, "state_", 2287, 6, true);
#nullable restore
#line 72 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2293, item.ProductId, 2293, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
                                                                                                      Write(Html.Raw(@strState));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2384, "\"", 2425, 2);
            WriteAttributeValue("", 2391, "/Products/Detail?p=", 2391, 19, true);
#nullable restore
#line 74 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2410, item.ProductId, 2410, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-product-hunt\" aria-hidden=\"true\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2553, "\"", 2592, 2);
            WriteAttributeValue("", 2560, "/Products/Edit?p=", 2560, 17, true);
#nullable restore
#line 77 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2577, item.ProductId, 2577, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\" title=\"Editar\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 82 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Products\Index.cshtml"
					}
				

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</table>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col text-center"">
		<input type=""button"" class=""btn btn-primary"" value=""Back to Categories"" 
			onclick=""backCategories();"" />

		<a href=""/Categories/Index"" class=""btn btn-primary"" role=""button"">Back to Categories</a>
	</div>
</div>

<script>
	function backCategories()
	{
		//Hacer algo importante
		//...

		//Redirección
		location.href=""/Categories/Index"";
	}
	function changeState(productId)
	{
		var content = $(""#state_"" + productId).html()
		$(""#state_"" + productId).html(""<img src='/images/loading.gif' width='32'/>"");
		
		$.ajax({
			// la URL para la petición
			url: '/Products/ChangeState',

			data: { productId: productId },

			type: 'GET',


			// código a ejecutar si la petición es satisfactoria;
			// la respuesta es pasada como argumento a la función
			success: function (resp) {

				var strState = ""<a href='javascript:void(0);' onClick='changeState("" + productId + "");'>"" + resp + ""</a>"";");
            WriteLiteral(@"
				$(""#state_""+productId).html(strState);
				
			},

			// código a ejecutar si la petición falla;
			// son pasados como argumentos a la función
			// el objeto de la petición en crudo y código de estatus de la petición
			error: function () {

				alert('Se ha producido un error');
				$(""#state_"" + productId).html(content);
			},

			// código a ejecutar sin importar si la petición falló o no
			complete: function (xhr, status) {
				//alert('Petición realizada');
			}
		});
	}
	function search(){
		//Recoger parametros del buscador y recargar página con parametros
		var categoria=$(""#cmbCategorias"").val();
		var texto=$(""#txtSearch"").val();
		location.href=""/Products/Index?CategoryId=""+categoria+""&search=""+texto;

	}
</script>");
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
