<<<<<<< HEAD:MascotaFeliz.App.Presentacion/obj/Debug/netcoreapp3.1/Razor/Pages/Mascota/ListMascota.cshtml.g.cs
#pragma checksum "C:\MascotaFeliz V1\MascotaFeliz\MascotaFeliz.App.Presentacion\Pages\Mascota\ListMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eb8dccdc266e769e3b692577f118595337534e2"
=======
#pragma checksum "C:\MascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Presentacion\Pages\CMascota\ListMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1ed11deaba0c118ab21c547290129615bff9b6"
>>>>>>> 495f089109b65c874ab4a0ebedf181eb825fb033:MascotaFeliz.App.Presentacion/obj/Debug/netcoreapp3.1/Razor/Pages/CMascota/ListMascota.cshtml.g.cs
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Presentacion.Pages.CMascota.Pages_CMascota_ListMascota), @"mvc.1.0.razor-page", @"/Pages/CMascota/ListMascota.cshtml")]
namespace MascotaFeliz.App.Presentacion.Pages.CMascota
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
#line 1 "C:\MascotaFeliz V1\MascotaFeliz\MascotaFeliz.App.Presentacion\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Presentacion;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD:MascotaFeliz.App.Presentacion/obj/Debug/netcoreapp3.1/Razor/Pages/Mascota/ListMascota.cshtml.g.cs
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb8dccdc266e769e3b692577f118595337534e2", @"/Pages/Mascota/ListMascota.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1ed11deaba0c118ab21c547290129615bff9b6", @"/Pages/CMascota/ListMascota.cshtml")]
>>>>>>> 495f089109b65c874ab4a0ebedf181eb825fb033:MascotaFeliz.App.Presentacion/obj/Debug/netcoreapp3.1/Razor/Pages/CMascota/ListMascota.cshtml.g.cs
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d2d4d12cde42b399948991385062cf76f235456", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CMascota_ListMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD:MascotaFeliz.App.Presentacion/obj/Debug/netcoreapp3.1/Razor/Pages/Mascota/ListMascota.cshtml.g.cs
=======
            WriteLiteral(@"<h1>Formulario de Mascotas</h1>
<table class=""table"">

    <colgroup>
        <col style=""background-color: rgba(14, 221, 248, 0.397);"">
        <col style=""background-color: rgba(120, 250, 178, 0.452);"">
        <col style=""background-color: rgba(14, 221, 248, 0.397);"">
        <col style=""background-color: rgba(120, 250, 178, 0.452);"">
");
            WriteLiteral("\r\n\r\n    </colgroup>\r\n\r\n    <caption><b>Listado de Mascotas</b></caption>\r\n    <thead>\r\n        <tr>\r\n            <td>Id Mascota</td>\r\n");
            WriteLiteral("            <td>Caracteristica</td>\r\n            <td>Propietario</td>\r\n            <td>tipo de mascota</td>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 28 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Presentacion\Pages\CMascota\ListMascota.cshtml"
     foreach (var Mascota in Model.Mascotas)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Presentacion\Pages\CMascota\ListMascota.cshtml"
           Write(Mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Presentacion\Pages\CMascota\ListMascota.cshtml"
           Write(Mascota.NombreMascota);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Presentacion\Pages\CMascota\ListMascota.cshtml"
           Write(Mascota.Caracteristicas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 45 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Presentacion\Pages\CMascota\ListMascota.cshtml"
           Write(Mascota.TipoMascota);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 54 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Presentacion\Pages\CMascota\ListMascota.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table> ");
>>>>>>> 495f089109b65c874ab4a0ebedf181eb825fb033:MascotaFeliz.App.Presentacion/obj/Debug/netcoreapp3.1/Razor/Pages/CMascota/ListMascota.cshtml.g.cs
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Presentacion.Pages.ListMascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Presentacion.Pages.ListMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Presentacion.Pages.ListMascotaModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Presentacion.Pages.ListMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
