#pragma checksum "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed8adb4158513339ae968bfe4c59c68326e2df0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Team_Default), @"mvc.1.0.view", @"/Views/Home/Components/Team/Default.cshtml")]
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
#line 1 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\_ViewImports.cshtml"
using ActiveBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\_ViewImports.cshtml"
using ActiveBox.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\_ViewImports.cshtml"
using ActiveBox.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed8adb4158513339ae968bfe4c59c68326e2df0c", @"/Views/Home/Components/Team/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed443097f362597e838b38c2ece9e8f4e75afaad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Team_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<OurTeam>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml"
  int i = 0 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Team -->\r\n<div class=\"team\" id=\"team\">\r\n    <div class=\"container\">\r\n        <div class=\"team__inner\">\r\n");
#nullable restore
#line 8 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml"
 foreach (var item in Model)
{
    string s = $"img/team/team-{++i}.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"team__item\">\r\n        <img class=\"team__photo\"");
            BeginWriteAttribute("src", " src=\"", 294, "\"", 302, 1);
#nullable restore
#line 12 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml"
WriteAttributeValue("", 300, s, 300, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 303, "\"", 309, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"team__name\">");
#nullable restore
#line 13 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml"
                           Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"team__prof\">");
#nullable restore
#line 14 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml"
                           Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"team__text\">\r\n            <p>");
#nullable restore
#line 16 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml"
          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
          
        </div>

        <div class=""social"">
            <a class=""social__item"" href=""#"" target=""_blank"">
                <svg class=""social__icon"">
                    <use xlink:href=""#facebook""></use>
                </svg>
            </a>
            <a class=""social__item"" href=""#"" target=""_blank"">
                <svg class=""social__icon"">
                    <use xlink:href=""#twitter""></use>
                </svg>
            </a>
            <a class=""social__item"" href=""#"" target=""_blank"">
                <svg class=""social__icon"">
                    <use xlink:href=""#linkedin""></use>
                </svg>
            </a>
        </div>
    </div>
");
#nullable restore
#line 38 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Team\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div><!-- /.team__inner -->\r\n    </div><!-- /.container -->\r\n</div><!-- /.team -->\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<OurTeam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
