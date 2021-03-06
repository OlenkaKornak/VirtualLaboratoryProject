#pragma checksum "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47d14a143923aefc61ccf10c590feb0c1ea3d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
using Domain.RDBMS.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
using VietualSELaboratory.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47d14a143923aefc61ccf10c590feb0c1ea3d07", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179fc49a916ca0cd7fed31ea3b73de287ab4fae6", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VietualSELaboratory.ViewModel.ShowTasksViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style type=""text/css"">
    #main {
        font-size: 28px;
        margin-left: 135px;
    }

    #search_input {
        width: 100%;
        height: 35px;
    }

    #task_list {
        margin-top: 65px;
    }

    #add_button {
        height: 36px;
        width: 145px;
        font-size: 15px;
        float: right;
        color: #FFFFFF;
        background-color: #0C8524;
        margin-top: 12px;
    }

    #add_button {
        text-decoration: none;
        text-align: center;
    }

    #tasks_table {
        font-size: 18px;
        color: #707683;
    }

    #tasks_table {
        width: 100%;
        border-collapse: collapse;
        border: none;
        text-align: left;
        background-color: #FFFF;
    }

    td, th {
        padding: 0 25px 15px;
    }

    td {
        padding: 20px;
    }

    th {
        padding: 20px;
    }

    tr:first-child {
        border-bottom: solid 2px #18BF36;
    }

    tr {
        border");
            WriteLiteral(@"-bottom: 1px solid #E9E9E9;
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
</style>

<div id=""main"">
    <input type=""text"" class=""mainLoginInput"" id=""search_input"" placeholder=""&#61442; Search for a tasks"">

    <input type=""button"" id=""filter_button"" value=""Filter"" style=""margin-left: 10px;"">

");
#nullable restore
#line 90 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
     if (User.IsInRole(Constants.ApplicationRoles.Teacher))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Task/Create\" id=\"add_button\" style=\"padding-top: 7px;\">Add new task</a>\r\n");
#nullable restore
#line 93 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <div id=\"task_list\">\r\n         <table id=\"tasks_table\">\r\n             <tr>\r\n                 <th>Name</th>\r\n                 <th>Level</th>\r\n                 <th>Description</th>\r\n");
#nullable restore
#line 101 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                  if (User.IsInRole(Constants.ApplicationRoles.Student))
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <th>Status</th>\r\n");
#nullable restore
#line 104 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <th>Actions</th>\r\n                 </tr>\r\n");
#nullable restore
#line 107 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
              foreach (var item in Model.Exercises)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n             <td style=\"color: #323C47;\">");
#nullable restore
#line 110 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 111 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
            Write(item.LevelId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 112 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 114 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
              if (Model.CompletedTasksIds.Contains(item.Id))
             {
                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                  if (User.IsInRole(Constants.ApplicationRoles.Student))
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <td>Completed</td>\r\n                     <td></td>\r\n");
#nullable restore
#line 120 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                 }
                 else
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <td><a class=\"button_ref\"");
            BeginWriteAttribute("href", " href=\"", 2839, "\"", 2872, 2);
            WriteAttributeValue("", 2846, "/Task/View?taskId=", 2846, 18, true);
#nullable restore
#line 123 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
WriteAttributeValue("", 2864, item.Id, 2864, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n");
#nullable restore
#line 124 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                  

             }
             else
             {
                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                  if (User.IsInRole(Constants.ApplicationRoles.Student))
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                     <td>New</td>
                     <td>
                         <a style=""font-family: Poppins;
                            margin-top: 23px;
                            height: 39px;
                            width: 150px;
                            font-family: Poppins;
                            color: #0C8524;
                            font-size: 15px;
                            margin-left: 10px;""");
            BeginWriteAttribute("href", " href=\"", 3498, "\"", 3534, 2);
            WriteAttributeValue("", 3505, "/Task/Execute?taskId=", 3505, 21, true);
#nullable restore
#line 140 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
WriteAttributeValue("", 3526, item.Id, 3526, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Execute</a>\r\n                         \r\n                     </td>\r\n");
#nullable restore
#line 143 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                 }
                 else
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                     <td>
                         <a style=""font-family: Poppins;
                            margin-top: 23px;
                            height: 39px;
                            width: 150px;
                            font-family: Poppins;
                            color: #0C8524;
                            font-size: 15px;
                            """);
            BeginWriteAttribute("href", " href=\"", 4056, "\"", 4089, 2);
            WriteAttributeValue("", 4063, "/Task/View?taskId=", 4063, 18, true);
#nullable restore
#line 154 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
WriteAttributeValue("", 4081, item.Id, 4081, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n                         \r\n                     </td>\r\n");
#nullable restore
#line 157 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"


                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
                  
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                 </tr>\r\n");
#nullable restore
#line 162 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n    <nav aria-label=\"Tasks paging\">\r\n        ");
#nullable restore
#line 168 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Task\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model.Exercises }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VietualSELaboratory.ViewModel.ShowTasksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
