#pragma checksum "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9919cbe9330c8d5b52e6265ef981fdd44eee85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_Index), @"mvc.1.0.view", @"/Views/Statistics/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\_ViewImports.cshtml"
using VietualSELaboratory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\_ViewImports.cshtml"
using VietualSELaboratory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9919cbe9330c8d5b52e6265ef981fdd44eee85b", @"/Views/Statistics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179fc49a916ca0cd7fed31ea3b73de287ab4fae6", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<Domain.RDBMS.Entities.Statistics>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    #all_bodyl {
        width: 83%;
        height: 100%;
        margin-left: 260px;
    }
    #header_div {
        margin-right: 10px;
        margin-top: 10px;
        margin-bottom: 10px;
        padding: 20px;
        background: #FFFF;
        text-align: left;
        width: 100%;
        justify-content: flex-start;
    }

    #lable {
        font-family: Poppins;
        color: #0C8524;
    }

    .button_ref {
        font-family: Poppins;
        margin-top: 23px;
        height: 39px;
        width: 150px;
        font-family: Poppins;
        color: #0C8524;
        font-size: 15px;
    }

    #task_list {
        margin-top: 10px;
    }

    #tasks_table {
        font-size: 18px;
        color: #707683;
        width: 100%;
        border-collapse: collapse;
        border: none;
        text-align: left;
        background-color: #FFFF;
    }
</style>

<div id=""all_bodyl"">
    <div id=""header_div"">
        <h1 id=""lable"">Statistics<");
            WriteLiteral(@"/h1>
    </div>
    <div id=""task_list"">
        <table id=""tasks_table"">
            <tr>
                <th>Name</th>
                <th>Level</th>
                <th>Description</th>
                <th>Grade</th>
                <th>Actions</th>
            </tr>
");
#nullable restore
#line 63 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"color: #323C47;\">");
#nullable restore
#line 66 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
                                           Write(item.Exercise.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
                   Write(item.Exercise.LevelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
                   Write(item.Exercise.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
                   Write(item.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                    <td>\r\n                        <a class=\"button_ref\"");
            BeginWriteAttribute("href", " href=\"", 1761, "\"", 1814, 2);
            WriteAttributeValue("", 1768, "/Statistics/TaskOverview?statisticsId=", 1768, 38, true);
#nullable restore
#line 71 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
WriteAttributeValue("", 1806, item.Id, 1806, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Overview</a>\r\n                        <a class=\"button_ref\" href=\"#\">Graphic</a>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 76 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n<nav aria-label=\"Tasks paging\">\r\n    ");
#nullable restore
#line 81 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\Index.cshtml"
Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<Domain.RDBMS.Entities.Statistics>> Html { get; private set; }
    }
}
#pragma warning restore 1591
