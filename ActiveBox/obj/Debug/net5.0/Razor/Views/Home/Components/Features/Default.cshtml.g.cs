#pragma checksum "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Features\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f1431404c305d6df89bd93f7a935789020bb2d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Features_Default), @"mvc.1.0.view", @"/Views/Home/Components/Features/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1431404c305d6df89bd93f7a935789020bb2d5", @"/Views/Home/Components/Features/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed443097f362597e838b38c2ece9e8f4e75afaad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Features_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<EntityBase>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Features -->\r\n<div class=\"container\" id=\"features\">\r\n    <div class=\"features\">\r\n        \r\n");
#nullable restore
#line 7 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Features\Default.cshtml"
           int i = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Features\Default.cshtml"
         foreach (var item in Model)
        {
            string s = $"img/features/feature-{++i}.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"features__item\">\r\n                <img class=\"features__icon\"");
            BeginWriteAttribute("src", " src=\"", 347, "\"", 355, 1);
#nullable restore
#line 12 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Features\Default.cshtml"
WriteAttributeValue("", 353, s, 353, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 356, "\"", 362, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h4 class=\"features__title\">");
#nullable restore
#line 13 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Features\Default.cshtml"
                                       Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <div class=\"features__text\">");
#nullable restore
#line 14 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Features\Default.cshtml"
                                       Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Features\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n");
            WriteLiteral("    </div><!-- /.features -->\r\n</div><!-- /.container -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<EntityBase>> Html { get; private set; }
    }
}
#pragma warning restore 1591
