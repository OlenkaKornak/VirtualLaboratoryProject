#pragma checksum "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd066a30ccac1f6b5f4493154a1f1558da516a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_TaskOverview), @"mvc.1.0.view", @"/Views/Statistics/TaskOverview.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd066a30ccac1f6b5f4493154a1f1558da516a5", @"/Views/Statistics/TaskOverview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179fc49a916ca0cd7fed31ea3b73de287ab4fae6", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_TaskOverview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.RDBMS.Entities.Statistics>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style type=""text/css"">

    #all_bodyl {
        width: 83%;
        height: 100%;
        margin-left: 260px;
    }

    #header_div {
        margin-right: 10px;
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

    #task_div {
        margin-right: 10px;
        margin-top: 10px;
        margin-bottom: 10px;
        padding: 20px;
        background: #FFFF;
        text-align: left;
        width: 100%;
        justify-content: flex-start;
    }

    .answer-correct {
        background: #C0F2C9;
    }

    .answer-mistake {
        background: #FFE0E0;
    }

    .list-caption {
        font-family: Poppins;
        color: #707683;
        border-bottom: 3px solid #18BF36;
        margin: 10px;
    }

    .result {
        font-family: Poppins;
        font-size");
            WriteLiteral(@": 20px;
        color: black;
    }

    .question {
        font-family: Poppins;
        font-size: 20px;
        color: #91959E;
    }

    .button_ref {
        font-family: Poppins;
        margin-top: 10px;
        height: 39px;
        width: 150px;
        font-family: Poppins;
        color: #0C8524;
        font-size: 24px;
    }

    .arrow-left {
        border: solid #0C8524;
        border-width: 0 3px 3px 0;
        display: inline-block;
        padding: 3px;
        margin-bottom: 3px;
        transform: rotate(135deg);
        -webkit-transform: rotate(135deg);
    }

    .list-cell {
        list-style-type: none;
        padding: 10px;
    }

    .list-card {
        margin: 5px;
    }

    .question_space{
        width:100%;
    }
</style>

<div id=""all_bodyl"" style=""width: 1050px;"">
    <div id=""header_div"">
        <h1 id=""lable"">Statistics</h1>
    </div>
    <div id=""task_div"" style=""height: 550px;"">
        <a class=""button_ref"" href=");
            WriteLiteral("\"/Statistics/Index\"><i class=\"arrow-left\"></i>Overview</a>\r\n        <p class=\"result\">Task name: ");
#nullable restore
#line 104 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                Write(Model.Exercise.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"result\">Grade: ");
#nullable restore
#line 105 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                            Write(Model.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n\r\n        <div id=\"questions_block\">\r\n");
#nullable restore
#line 108 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
             foreach (var question in Model.Exercise.Questions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"question_space\" style=\"background:white; height: 200px;\">\r\n                    <p  class=\"question\">");
#nullable restore
#line 111 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                    Write(question.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div id=""answers"">
                        <div class=""container"">
                            <div class=""row"" style=""font-size: 15px;"">
                                <div class=""col-md-6"" >
                                    <p class=""list-caption"">Choosed correct answers</p>
                                    <ul class="" correct list-cell js-cell"">

");
#nullable restore
#line 119 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                          
                                            var correctUserAnswers = Model.UserAnswers.FirstOrDefault(m => m.QuestionId == question.Id).CorrectAnswers.Split(",").Select(Int32.Parse).ToList();
                                            var incorrectUserAnswers = Model.UserAnswers.FirstOrDefault(m => m.QuestionId == question.Id).IncorrectAnswers.Split(",").Select(Int32.Parse).ToList();
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                         foreach (var answer in question.Answers)
                                        {
                                            if (answer.IsCorrect)
                                            {
                                                if (correctUserAnswers.Contains(answer.Id))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"list-card answer-correct\">");
#nullable restore
#line 129 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                                                    Write(answer.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 130 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"list-card answer-mistake\">");
#nullable restore
#line 133 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                                                    Write(answer.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 134 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                }

                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                                <div class=""col-md-6"">
                                    <p class=""list-caption"">Choosed incorrect answers</p>
                                    <ul class=""list-cell incorrect  js-cell"">
");
#nullable restore
#line 143 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                         foreach (var answer in question.Answers)
                                        {
                                            if (!answer.IsCorrect)
                                            {
                                                if (incorrectUserAnswers.Contains(answer.Id))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"list-card answer-correct\">");
#nullable restore
#line 149 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                                                    Write(answer.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 150 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"list-card answer-mistake\">");
#nullable restore
#line 153 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                                                    Write(answer.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 154 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
                                                }
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 163 "C:\Users\User\Desktop\Арх\VietualSELaboratory\VietualSELaboratory\Views\Statistics\TaskOverview.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.RDBMS.Entities.Statistics> Html { get; private set; }
    }
}
#pragma warning restore 1591
