#pragma checksum "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68d258a5e9c4dbe68c4eabf58875300ca060856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaTruc_FormAddCaTruc), @"mvc.1.0.view", @"/Views/CaTruc/FormAddCaTruc.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68d258a5e9c4dbe68c4eabf58875300ca060856", @"/Views/CaTruc/FormAddCaTruc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42e625add3077e0d47d4c1ad8c9bfc09d2f90bc", @"/Views/_ViewImports.cshtml")]
    public class Views_CaTruc_FormAddCaTruc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/formEdit.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
  
    ViewData["title"] = "Add Ca Trực";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c68d258a5e9c4dbe68c4eabf58875300ca0608564528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""divformedit"">
    <div class=""formedit"">
        <h2 style=""font-size:30px;font-family: 'Open Sans';"">Thêm Ca Trực</h2>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label class=""lable-text"">Mã Nhân Viên</label>
");
            WriteLiteral("                    <select id=\"MaNV\" class=\"form-control\" name=\"MaNV\">\r\n");
#nullable restore
#line 19 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                           foreach (var x in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c68d258a5e9c4dbe68c4eabf58875300ca0608566413", async() => {
#nullable restore
#line 21 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                                              Write(x);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                                   WriteLiteral(x);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label class=\"lable-text\">Tên Nhân Viên</label>\r\n");
            WriteLiteral("                <select id=\"cbbMaNV\" class=\"form-control\" name=\"TenNV\">\r\n");
#nullable restore
#line 30 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                       foreach (var x in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c68d258a5e9c4dbe68c4eabf58875300ca0608568940", async() => {
                WriteLiteral("Đây là Tên Nv Nhưng chưa đọc được database");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                               WriteLiteral(x);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""lable-text"">Tên Công Việc</label>
            <input type=""text"" class=""form-control"" style=""font-size :18px;"" id=""tencv""  name=""TenCV"" placeholder=""Tên Công Việc"">
        </div>
        <div class=""form-group"">
            <label class=""lable-text"">Nhiệm Vụ</label>
            <input type=""text"" class=""form-control"" style=""font-size :18px;"" id=""nhiemvu"" name=""NhiemVu"" placeholder=""Nhiệm Vụ"">
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label class=""lable-text"">Khu Vực</label>
                <input type=""text"" class=""form-control"" style=""font-size :18px;"" id=""kv""  name=""KhuVuc"" placeholder=""Khu Vực"">
            </div>
            <div class=""form-group col-md-6"">
                <label class=""lable-text"" for=""inputZip"">Ca Làm</label>
                <input type=""text"" class=""form-control"" style=""font-size :18");
            WriteLiteral(@"px;"" id=""calam""  name=""CaLam"" placeholder=""Ca Làm"">
            </div>
        </div>
        <button style=""font-size : 18px;"" class=""btn btn-primary"" id=""sub"">Thêm</button>

    </div>
</div>

<script type=""text/javascript"">

    $('#sub').click(function () {
            if (confirm(""Bạn Có Chắc Thêm Ca Trực Này ?"")) {
                let manv = $('#MaNV option:selected').val();
                
                let tennv = $('#tennv').val();
                let tencv = $('#tencv').val();
                let nhiemvu = $('#nhiemvu').val();
                let kv = $('#kv').val();
                let calam = $('#calam').val();
                console.log(manv);
                console.log(tencv);
            $.post('");
#nullable restore
#line 74 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
               Write(Url.Action("AddCaTruc","CaTruc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             {
                    MaNV: manv,
                    TenNV: tennv,
                    TenCV: tencv,
                    NhiemVu: nhiemvu,
                    KhuVuc: kv,
                    CaLam: calam,
             }, result => {
                    if (Number(result) > 0) {
                        alert(""Thành Công!"");
                        window.open('");
#nullable restore
#line 85 "L:\C#\DoAn-CK\DoAn-CK\Views\CaTruc\FormAddCaTruc.cshtml"
                                Write(Url.Action("Index","CaTruc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', '_self');
                    }
                    else {
                        alert(""Thực Thi thất bại!"");
                        location.reload();
                    }
                })

            }
                        }
    );


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
