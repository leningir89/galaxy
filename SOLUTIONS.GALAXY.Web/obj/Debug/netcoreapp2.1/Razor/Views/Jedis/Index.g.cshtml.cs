#pragma checksum "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc82a6ef5b4759481950c547f9d9bc5d995a6772"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jedis_Index), @"mvc.1.0.view", @"/Views/Jedis/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jedis/Index.cshtml", typeof(AspNetCore.Views_Jedis_Index))]
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
#line 1 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\_ViewImports.cshtml"
using SOLUTIONS.GALAXY.Web;

#line default
#line hidden
#line 2 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\_ViewImports.cshtml"
using SOLUTIONS.GALAXY.Web.Models;

#line default
#line hidden
#line 4 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
using SOLUTIONS.GALAXY.Domain.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc82a6ef5b4759481950c547f9d9bc5d995a6772", @"/Views/Jedis/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3733bde27ab437c28fa06d96070661c9446d68e", @"/Views/_ViewImports.cshtml")]
    public class Views_Jedis_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JediViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(592, 270, true);
            WriteLiteral(@"<h2>Jedis</h2>

<div class=""row"">
    <div class=""col-md-6"" id=""divMessage"">
        <div id=""alertMessage"" class=""alert alert-success"" style=""display:none"">
            <span id=""lblMessage""></span>
        </div>
    </div>
    <div class=""col-md-4"">
        ");
            EndContext();
            BeginContext(862, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42f07295a1154aa5906af86c9b4eb795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 32 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectGrade);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = GetEnumSelectList();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(955, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-1\">\r\n        ");
            EndContext();
            BeginContext(1006, 102, false);
#line 35 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
   Write(Html.ActionLink("Limpiar", "Refresh", "Jedis", null, new { @class = "btn btn-warning btn-lg active" }));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 50, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-1\">\r\n        ");
            EndContext();
            BeginContext(1159, 99, false);
#line 38 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
   Write(Html.ActionLink("Nuevo", "Create", "Jedis", null, new { @class = "btn btn-primary btn-lg active" }));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 50, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div id=\"JediSection\">\r\n    ");
            EndContext();
            BeginContext(1309, 29, false);
#line 42 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
Write(Html.Partial("_Jedis", Model));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 2285, true);
            WriteLiteral(@"
</div>

<!-- Modal -->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" id=""myModal"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#SelectGrade').change(functi");
            WriteLiteral(@"on () {
            $.ajax({
                type: 'GET',
                url: '/jedis/GetByGrade',
                data: {
                    grade: $(this).val()
                },
                success: function (result) {
                    $(""#JediSection"").html(result);
                    deleteJedi();
                }
            });
        });       
    });
    deleteJedi();

    function deleteJedi() {
        $('#JediSection #btnDelete').on(""click"", function () {
            var value = $(this).attr('value');
            $.ajax({
                type: 'PUT',
                url: '/jedis/Edit',
                data: {
                    id: value
                },
                success: function (result) {
                    $(""#divMessage #alertMessage"").css(""display"", ""block"");;
                    $(""#lblMessage"").html(result);
                    getJedis();
                }
            });
        });
    } 
    function getJedis() {
        $.ajax");
            WriteLiteral("({\r\n            type: \'GET\',\r\n            url: \'/jedis/GetAll\',\r\n            success: function (result) {\r\n                $(\"#JediSection\").html(result);\r\n                deleteJedi();\r\n            }\r\n        });\r\n    }\r\n</script>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 7 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Jedis\Index.cshtml"
           
    public IEnumerable<SelectListItem> GetEnumSelectList()
    {
        var deptList = new List<SelectListItem>();
        deptList.Add(new SelectListItem
        {
            Text = "Select",
            Value = ""
        });
        foreach (Grade eVal in Enum.GetValues(typeof(Grade)))
        {
            deptList.Add(new SelectListItem { Text = Enum.GetName(typeof(Grade), eVal), Value = eVal.ToString() });
        }
        return deptList;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JediViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
