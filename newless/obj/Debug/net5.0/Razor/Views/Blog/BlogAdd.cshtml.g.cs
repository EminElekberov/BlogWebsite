#pragma checksum "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581af26266ff615610d2344097e6b90b0efd2dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581af26266ff615610d2344097e6b90b0efd2dd8", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02859c8aef81dc2a25723af84b1ac26e5f4dc2c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entity.Concencrate.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/_LayoutWriter.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>BlogAdd</h1>\r\n\r\n");
#nullable restore
#line 12 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Title"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Image"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.Image, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("ThumbnailImage"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.ThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 35 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Message"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x => x.Content, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 42 "D:\Muratyucedag\newless\Views\Blog\BlogAdd.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entity.Concencrate.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
