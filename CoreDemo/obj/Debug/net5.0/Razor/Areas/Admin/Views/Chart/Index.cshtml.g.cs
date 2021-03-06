#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Chart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d050466b9a1044e5160f81490d60b353f0d50ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chart_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d050466b9a1044e5160f81490d60b353f0d50ce1", @"/Areas/Admin/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Chart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div id=""chartdiv"" style=""width:800px;height:600px"">
            <h2>Chart yeri</h2>
        </div>
    </div>
</div>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">

    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(DrawonLoad);

    function DrawonLoad() {
        $(function () {
            $.ajax({
                type: 'GET',
                url: '/Admin/Chart/CategoryChart/',
                success: function (chartsdata) {
                    var Data = chartsdata.jsonlist;
                    var data = new google.visualization.DataTable();

                    data.addColumn('string', 'Name');
                    data.addColumn('number', 'Count');

                    for (var i = 0; i < Data.length; i++) {
                        data.addRow([Data[i].name, Data[i].count]);
                    }");
            WriteLiteral(@"

                    var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));

                    chart.draw(data, {
                        title: ""Goole Chart Core Project"",
                        position: ""top"",
                        fonsize: ""16px""
                    });
                }
            });
        })
    }

</script>");
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
