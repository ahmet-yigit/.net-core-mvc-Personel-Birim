#pragma checksum "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de1f5d60bb5b2d8f891689fa05d8911bc134b884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personelim_Index), @"mvc.1.0.view", @"/Views/Personelim/Index.cshtml")]
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
#line 1 "E:\.net_core_app\ProjeCore\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de1f5d60bb5b2d8f891689fa05d8911bc134b884", @"/Views/Personelim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Personelim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Şehir</th>\r\n        <th>Departman</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.PersonelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Birim.BirimAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 617, "\"", 658, 2);
            WriteAttributeValue("", 624, "/depart/DepartmanSil/", 624, 21, true);
#nullable restore
#line 30 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 645, x.PersonelID, 645, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 715, "\"", 761, 2);
            WriteAttributeValue("", 722, "/Personelim/PersonelGetir/", 722, 26, true);
#nullable restore
#line 31 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 748, x.PersonelID, 748, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/personelim/YeniPersonel\" class=\"btn btn-primary\">Yeni Personel</a>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
