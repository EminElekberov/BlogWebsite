#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e264b6acc3344b1a41048a2efbf5a9d0ec88fb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e264b6acc3344b1a41048a2efbf5a9d0ec88fb4", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>InBox</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Subject</th>\r\n        <th>By Sender</th>\r\n        <th>Date</th>\r\n        <th>Open Message</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 26 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
   Write(item.SenderUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
    Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 571, "\"", 610, 2);
            WriteAttributeValue("", 578, "/Message/MessageDetails/", 578, 24, true);
#nullable restore
#line 30 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
WriteAttributeValue("", 602, item.Id, 602, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Open Message</a></td>\r\n</tr>\r\n");
#nullable restore
#line 32 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Message\InBox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Message/SendMessage/\" class=\"btn btn-primary\">Create new blog</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
