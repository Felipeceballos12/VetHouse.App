#pragma checksum "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa93f13a74c7a166067da0e382cacfe583e48275"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VetHouse.App.Presentacion.Pages.OwnersFile.Pages_OwnersFile_Index), @"mvc.1.0.razor-page", @"/Pages/OwnersFile/Index.cshtml")]
namespace VetHouse.App.Presentacion.Pages.OwnersFile
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
#line 1 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\_ViewImports.cshtml"
using VetHouse.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa93f13a74c7a166067da0e382cacfe583e48275", @"/Pages/OwnersFile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4aa79d1b046ccc7917460adb3c9d01e6b8a15bd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OwnersFile_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Registro de Dueños</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Surname</th>
            <th>PhoneNumber</th>
            <th>Gender</th>
            <th>Email</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml"
         foreach (var owner in @Model.Owners)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml"
               Write(owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml"
               Write(owner.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml"
               Write(owner.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml"
               Write(owner.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml"
               Write(owner.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\cebal\OneDrive\Documents\Code\Ciclo3\VetHouse\VetHouse.App\VetHouse.App.Presentacion\Pages\OwnersFile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetHouse.App.Presentacion.Pages.OwnersFile.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetHouse.App.Presentacion.Pages.OwnersFile.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetHouse.App.Presentacion.Pages.OwnersFile.IndexModel>)PageContext?.ViewData;
        public VetHouse.App.Presentacion.Pages.OwnersFile.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
