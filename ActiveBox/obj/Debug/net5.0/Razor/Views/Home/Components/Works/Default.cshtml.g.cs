#pragma checksum "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Works\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8273b9546e2def76a10e3280cb393ca6b43b53ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Works_Default), @"mvc.1.0.view", @"/Views/Home/Components/Works/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8273b9546e2def76a10e3280cb393ca6b43b53ad", @"/Views/Home/Components/Works/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed443097f362597e838b38c2ece9e8f4e75afaad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Works_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<EntityBase>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Works\Default.cshtml"
   int i = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"works\" id=\"works\">\r\n");
#nullable restore
#line 5 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Works\Default.cshtml"
 foreach (var item in Model)
{
    string s = $"img/works/work-{++i}.jpg";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"works__item\">\r\n        <img class=\"works__photo\"");
            BeginWriteAttribute("src", " src=\"", 230, "\"", 238, 1);
#nullable restore
#line 10 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Works\Default.cshtml"
WriteAttributeValue("", 236, s, 236, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 239, "\"", 245, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"works__content\">\r\n            <div class=\"works__title\">");
#nullable restore
#line 12 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Works\Default.cshtml"
                                 Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"works__text\">");
#nullable restore
#line 13 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Works\Default.cshtml"
                                Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Max Prohrochuk\RiderProjects\ActiveBox\ActiveBox\ActiveBox\Views\Home\Components\Works\Default.cshtml"
   
    
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>   \r\n<!-- Works -->\r\n");
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
