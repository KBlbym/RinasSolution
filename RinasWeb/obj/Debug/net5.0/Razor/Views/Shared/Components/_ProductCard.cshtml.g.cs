#pragma checksum "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\Shared\Components\_ProductCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd7e37d856356347dff2b64c360cf45281e19a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ProductCard), @"mvc.1.0.view", @"/Views/Shared/Components/_ProductCard.cshtml")]
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
#line 1 "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\_ViewImports.cshtml"
using RinasWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\_ViewImports.cshtml"
using RinasWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd7e37d856356347dff2b64c360cf45281e19a4d", @"/Views/Shared/Components/_ProductCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27ea3d27c973afd06be9599a8f31a894691b331", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__ProductCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section class=\"container-fluid card-container\">\r\n    \r\n");
#nullable restore
#line 6 "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\Shared\Components\_ProductCard.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 143, "\"", 218, 5);
            WriteAttributeValue("", 151, "card", 151, 4, true);
            WriteAttributeValue(" ", 155, "item-", 156, 6, true);
#nullable restore
#line 8 "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\Shared\Components\_ProductCard.cshtml"
WriteAttributeValue("", 161, Model.ToList().IndexOf(item)+1, 161, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 194, "text-white", 196, 12, true);
            WriteAttributeValue(" ", 206, "text-center", 207, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 238, "\"", 279, 1);
#nullable restore
#line 9 "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\Shared\Components\_ProductCard.cshtml"
WriteAttributeValue("", 244, string.Format("{0}", item.Image), 244, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" alt=\"...\">\r\n            <div class=\"card-img-overlay d-flex justify-content-center\">\r\n                <a href=\"#\" class=\"btn btn-primary align-self-end mb-3 card-btn\">");
#nullable restore
#line 11 "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\Shared\Components\_ProductCard.cshtml"
                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\khalo\source\repos\RinasSolution\RinasWeb\Views\Shared\Components\_ProductCard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
