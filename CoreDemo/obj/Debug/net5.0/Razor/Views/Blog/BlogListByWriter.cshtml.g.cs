#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb0db4f36165a36b42e5a1d061ba78a6a9741c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cb0db4f36165a36b42e5a1d061ba78a6a9741c6", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 4 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
Write(ViewBag.asd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Title</th>\r\n        <th>Date</th>\r\n        <th>Category</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Edit</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 25 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
    Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 644, "\"", 676, 2);
            WriteAttributeValue("", 651, "/Blog/DeleteBlog/", 651, 17, true);
#nullable restore
#line 30 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 668, item.Id, 668, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 728, "\"", 758, 2);
            WriteAttributeValue("", 735, "/Blog/EditBlog/", 735, 15, true);
#nullable restore
#line 31 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 750, item.Id, 750, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a></td>\r\n</tr>\r\n");
#nullable restore
#line 33 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Blog/BlogAdd/\" class=\"btn btn-primary\">Create new blog</a>");
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
