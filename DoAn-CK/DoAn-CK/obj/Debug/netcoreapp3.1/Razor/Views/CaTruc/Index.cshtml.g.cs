#pragma checksum "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7632815d29ad7c082a5e830e04e10aae2f21e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaTruc_Index), @"mvc.1.0.view", @"/Views/CaTruc/Index.cshtml")]
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
#line 1 "L:\C#\DoAn-CK\DoAn-CK\Views\_ViewImports.cshtml"
using DoAn_CK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "L:\C#\DoAn-CK\DoAn-CK\Views\_ViewImports.cshtml"
using DoAn_CK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7632815d29ad7c082a5e830e04e10aae2f21e9", @"/Views/CaTruc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42e625add3077e0d47d4c1ad8c9bfc09d2f90bc", @"/Views/_ViewImports.cshtml")]
    public class Views_CaTruc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn_CK.Models.CaTruc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
  
    ViewData["title"] = "Index Ca Trực";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""css/table.css"">
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

<div  class=""container-table"">
<div class=""wrap-table"">
    <table class=""table table-bordered"" id=""table-CaTruc"">
        <tr class=""table_header"">
            <th>Mã Nhân Viên</th>
            <th>Tên Nhân Viên</th>
            <th>Tên Công Việc</th>
            <th>Nhiệm Vụ</th>
            <th>Khu Vực</th>
            <th>Ca Làm</th>
            <td></td>
        </tr>
");
#nullable restore
#line 29 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"row_tbl\">\r\n                <td>");
#nullable restore
#line 32 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
               Write(x.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
               Write(x.TenNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
               Write(x.TenCV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
               Write(x.NhiemVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
               Write(x.KhuVuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
               Write(x.CaLam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"td-action\">\r\n                    <button class=\"btn btn-danger delete-row\" title=\"Xoá\"");
            BeginWriteAttribute("id", " id=\"", 1477, "\"", 1489, 1);
#nullable restore
#line 39 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
WriteAttributeValue("", 1482, x.MaNV, 1482, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i></button>\r\n                    <button class=\"btn btn-info\" title=\"Sửa\"><i class=\"far fa-edit\"> </i></button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div>
    <button class=""btn btn-success"" id=""btnExport"" title=""Xuất File Excel""><i class=""glyphicon glyphicon-save""></i> Export To Excel</button>
</div>
</div>
<script>
    $(""#btnExport"").click(
        function () {
            tableToExcel('table-CaTruc', 'test', 'TestExport');

        });

    function getIEVersion() {
        var rv = -1;
        if (navigator.appName == 'Microsoft Internet Explorer') {
            var ua = navigator.userAgent;
            var re = new RegExp(""MSIE ([0-9]{1,}[\.0-9]{0,})"");
            if (re.exec(ua) != null)
                rv = parseFloat(RegExp.$1);
        }
        return rv;
    }

    function tableToExcel(table, sheetName, fileName) {
        var ua = window.navigator.userAgent;
        var msie = ua.indexOf(""MSIE "");
        if (msie > 0 || !!navigator.userAgent.match(/Trident.*rv\:11\./)) // If Internet Explorer
        {
            return fnExcelReport(table, fileName);
        }

        var uri = 'data:");
            WriteLiteral(@"application/vnd.ms-excel;base64,',
            templateData = '<html xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:x=""urn:schemas-microsoft-com:office:excel"" xmlns=""http://www.w3.org/TR/REC-html40""><head><!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>{worksheet}</x:Name><x:WorksheetOptions><x:DisplayGridlines/></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--><meta http-equiv=""content-type"" content=""text/plain; charset=UTF-8""/></head><body><table>{table}</table></body></html>',
            base64Conversion = function (s) { return window.btoa(unescape(encodeURIComponent(s))) },
            formatExcelData = function (s, c) { return s.replace(/{(\w+)}/g, function (m, p) { return c[p]; }) }

        $(""tbody > tr[data-level='0']"").show();

        if (!table.nodeType)
            table = document.getElementById(table)

        var ctx = { worksheet: sheetName || 'Worksheet', table: table.innerHTML }

      ");
            WriteLiteral(@"  var element = document.createElement('a');
        element.setAttribute('href', 'data:application/vnd.ms-excel;base64,' + base64Conversion(formatExcelData(templateData, ctx)));
        element.setAttribute('download', fileName);
        element.style.display = 'none';
        document.body.appendChild(element);
        element.click();
        document.body.removeChild(element);

        $(""tbody > tr[data-level='0']"").hide();
    }


    function fnExcelReport(table, fileName) {

        var tab_text = ""<table border='2px'>"";
        var textRange;

        if (!table.nodeType)
            table = document.getElementById(table)

        $(""tbody > tr[data-level='0']"").show();
        tab_text = tab_text + table.innerHTML;

        tab_text = tab_text + ""</table>"";
        tab_text = tab_text.replace(/<A[^>]*>|<\/A>/g, """");//remove if u want links in your table
        tab_text = tab_text.replace(/<img[^>]*>/gi, """"); // remove if u want images in your table
        tab_text = tab_t");
            WriteLiteral(@"ext.replace(/<input[^>]*>|<\/input>/gi, """"); // reomves input params

        txtArea1.document.open(""txt/html"", ""replace"");
        txtArea1.document.write(tab_text);
        txtArea1.document.close();
        txtArea1.focus();
        sa = txtArea1.document.execCommand(""SaveAs"", false, fileName + "".xlsx"");
        $(""tbody > tr[data-level='0']"").hide();
        return (sa);
    }
</script>

<script type=""text/javascript"">
    $('.delete-row').on('click', function () {
        var varid = this.id;
        var d;
        console.log(varid);
        if (confirm(""Are you sure to delete this contact?"")) {
            console.log(id);
            $.post('");
#nullable restore
#line 133 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\Index.cshtml"
               Write(Url.Action("DeleteCaTruc", "CaTruc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                {
                    MaNV: varid
                }, result => {
                    if (Number(result) > 0) {
                        alert(""success!"");
                        location.reload();
                    }
                    else {
                        alert(""Fail!"");
                    }
                })
        };
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn_CK.Models.CaTruc>> Html { get; private set; }
    }
}
#pragma warning restore 1591