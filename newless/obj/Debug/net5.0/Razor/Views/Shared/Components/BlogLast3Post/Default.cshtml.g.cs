#pragma checksum "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bff7518ddc4f65fb37ef1a75b31e839f6b482a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "D:\Muratyucedag\newless\Views\_ViewImports.cshtml"
using newless;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Muratyucedag\newless\Views\_ViewImports.cshtml"
using newless.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using Entity.Concencrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23bff7518ddc4f65fb37ef1a75b31e839f6b482a", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02859c8aef81dc2a25723af84b1ac26e5f4dc2c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml"
 foreach (var item in Model)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\r\n        <div class=\"col-md-5 blog-grid-left\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 187, "\"", 221, 3);
            WriteAttributeValue("", 194, "/Blog/BlogReadAll/", 194, 18, true);
#nullable restore
#line 11 "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 212, item.Id, 212, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 220, "/", 220, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 245, "\"", 262, 1);
#nullable restore
#line 12 "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 251, item.Image, 251, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 294, "\"", 300, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"col-md-7 blog-grid-right\">\r\n\r\n            <h5>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 424, "\"", 458, 3);
            WriteAttributeValue("", 431, "/Blog/BlogReadAll/", 431, 18, true);
#nullable restore
#line 18 "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 449, item.Id, 449, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 457, "/", 457, 1, true);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n            </h5>\r\n            <div class=\"sub-meta\">\r\n                <span>\r\n                    <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                             Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\Muratyucedag\newless\Views\Shared\Components\BlogLast3Post\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591