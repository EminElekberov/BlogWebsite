#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91eb81036a94f6c92b1e00188b61e0f7a5ca2760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91eb81036a94f6c92b1e00188b61e0f7a5ca2760", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ajax prosesleri</h1>

<br />

<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary"">Yazar listi</button>

<button type=""button"" id=""btngetbyId"" class=""btn btn-outline-primary"">Yazar getir</button>

<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar elave et</button>

<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Sil</button>

<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning"">Update</button>


<br />
<br />

<div id=""writerlist"">
    Yazarlar listi
</div>

<br />

<div id=""writerget"">
    Yazar yeri
</div>

<br />

<div>
    <input type=""text"" id=""writerId"" placeholder=""Yazarin ID-si"" class=""form-control"" />
</div>

<br />

<div>
    <input type=""text"" id=""txtwriterId"" placeholder=""Yazarin ID-si"" class=""form-control"" />
    <input type=""text"" id=""txtwriterName"" placeholder=""Yazarin Adi"" class=""form-control"" />
</div>

<br />

<div>
    <input type=""text"" id=""txtid"" plac");
            WriteLiteral(@"eholder=""Yazarin ID-si"" class=""form-control"" />
</div>

<br />

<div>
    <input type=""text"" id=""txtid1"" placeholder=""Update olunacaq Id"" class=""form-control"" />
    <input type=""text"" id=""txtwritername1"" placeholder=""Update olunacaq Ad"" class=""form-control"" />
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class='table table-bordered'><tr><th>Id</th><th>Ad</th> </tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.Id}</td> <td>${value.Name}</td> </tr>`
                    });
                    tablehtml += ""</table>""
                    $(""#writerlist"").html(tablehtml);

                }
            });
        });

        $(""#btngetbyId"").click(x => {
            let id = $(""#writerId"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                t");
                WriteLiteral(@"ype: ""Get"",
                url: ""/Admin/Writer/GetWriterById"",
                data: { writerId: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);

                    let getvalue = `<table class='table table-bordered'>
                                                    <tr>
                                                    <th>Id</th>
                                                    <th>Ad</th>
                                                    </tr>

                                                    <tr>
                                                    <td>${w.Id}</td>
                                                    <td>${w.Name}</td>
                                                    </tr>
                                                    </table>`;
                    $(""#writerget"").html(getvalue);
                }
            });
        });

        $(""#btnaddwriter"").clic");
                WriteLiteral(@"k(function () {
            let writer = {
                Id: $(""#txtwriterId"").val(),
                Name: $(""#txtwriterName"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar Elave etme ugurlu oldu"");
                }
            })
        });

        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();

            $.ajax({
                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""Yazar silindi"");
                }
            });
        });

        $(""#btnupdatewriter"").click(function () {
            let writer = {
                Id: $(""#txtid1"").val(),
                Name: $(""#t");
                WriteLiteral(@"xtwritername1"").val()
            };

            $.ajax({
                type: ""Post"",
                url: ""/Admin/Writer/UpdateWriter"",
                data: writer,
                success: function (func) {
                    alert(""Update olundu"")
                }
            });
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
