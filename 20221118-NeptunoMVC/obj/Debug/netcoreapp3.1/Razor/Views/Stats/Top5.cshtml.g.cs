#pragma checksum "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Stats\Top5.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beced0db1642c3debcf52babea57a54276676b20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stats_Top5), @"mvc.1.0.view", @"/Views/Stats/Top5.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beced0db1642c3debcf52babea57a54276676b20", @"/Views/Stats/Top5.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e7f2d23314c7e102817fc4bdf80b7106fc94f54", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stats_Top5 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Stats\Top5.cshtml"
  
	ViewData["Title"] = "Top 5 vendedores";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-md-6\">\r\n\t\t<h1>");
#nullable restore
#line 7 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Stats\Top5.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
		<div>
			<canvas id=""myChart""></canvas>
		</div>
	</div>
	<div class=""col-md-6"">
		Lorem ipsum. Lorem ipsum. Lorem ipsum. Lorem ipsum.
	</div>
</div>

<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>

<script>
    window.onresize = function ()
    {
        location.reload();
    }
</script>


<script>
	const ctx = document.getElementById('myChart');

    new Chart(ctx, {
    type: 'bar',
    data: {
      labels: ");
#nullable restore
#line 33 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Stats\Top5.cshtml"
         Write(Html.Raw(ViewData["Empleados"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n      datasets: [{\r\n        label: \'Ventas por vendedor\',\r\n        data: ");
#nullable restore
#line 36 "C:\Users\Alumne_mati1\Documents\Oriol Garcia\Projectes\20221118-NeptunoMVC\Views\Stats\Top5.cshtml"
         Write(Html.Raw(ViewData["Importes"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        borderWidth: 1\r\n      }]\r\n    },\r\n    options: {\r\n      indexAxis: \'y\',\r\n      scales: {\r\n        y: {\r\n          beginAtZero: true\r\n        }\r\n      }\r\n    }\r\n  });\r\n</script>\r\n");
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