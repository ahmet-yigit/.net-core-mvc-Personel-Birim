#pragma checksum "E:\.net_core_app\ProjeCore\ProjeCore\Views\Default\BirimGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5d4c1abd82ec7b976d840e114c98c4a0015c65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_BirimGetir), @"mvc.1.0.view", @"/Views/Default/BirimGetir.cshtml")]
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
#line 2 "E:\.net_core_app\ProjeCore\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5d4c1abd82ec7b976d840e114c98c4a0015c65", @"/Views/Default/BirimGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_BirimGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjeCore.Models.Birim>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Default\BirimGetir.cshtml"
  
    ViewData["Title"] = "BirimGetir";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Default\BirimGetir.cshtml"
 using (Html.BeginForm("BirimGüncelle", "default", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Birim ID</b>\r\n");
#nullable restore
#line 11 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Default\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Birim Adı</b>\r\n");
#nullable restore
#line 15 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Default\BirimGetir.cshtml"
Write(Html.TextBoxFor(x => x.BirimAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Birim Güncelle</button>\r\n");
#nullable restore
#line 18 "E:\.net_core_app\ProjeCore\ProjeCore\Views\Default\BirimGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjeCore.Models.Birim> Html { get; private set; }
    }
}
#pragma warning restore 1591
