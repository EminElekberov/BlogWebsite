#pragma checksum "D:\Muratyucedag\newless\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dbe9178d43adf2d44746808423c6cc403db1422"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 3 "D:\Muratyucedag\newless\Views\_ViewImports.cshtml"
using Entity.Concencrate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
using newless.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dbe9178d43adf2d44746808423c6cc403db1422", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02859c8aef81dc2a25723af84b1ac26e5f4dc2c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Name</th>\r\n        <th>Delete</th>\r\n        <th>Edit</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 435, "\"", 475, 2);
            WriteAttributeValue("", 442, "/Employee/DeleteEmployee/", 442, 25, true);
#nullable restore
#line 22 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
WriteAttributeValue("", 467, item.Id, 467, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 543, "\"", 581, 2);
            WriteAttributeValue("", 550, "/Employee/EditEmployee/", 550, 23, true);
#nullable restore
#line 23 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
WriteAttributeValue("", 573, item.Id, 573, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Edit</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\Muratyucedag\newless\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Employee/AddEmployee/\" class=\"btn btn-outline-primary\">Add</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; }
    }
}
#pragma warning restore 1591