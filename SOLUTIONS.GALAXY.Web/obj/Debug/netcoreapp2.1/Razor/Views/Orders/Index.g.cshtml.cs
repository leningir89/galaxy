#pragma checksum "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cba82da9f899ef5a66ca6edbe5ffc95f081ad77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
#line 1 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Orders\Index.cshtml"
using SOLUTIONS.GALAXY.Domain.Entities;

#line default
#line hidden
#line 2 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Orders\Index.cshtml"
using SOLUTIONS.GALAXY.Application.Interfaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cba82da9f899ef5a66ca6edbe5ffc95f081ad77", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3733bde27ab437c28fa06d96070661c9446d68e", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HologramList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("jedi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hologram"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(123, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(228, 20, true);
            WriteLiteral("\r\n<h2>Pedidos</h2>\r\n");
            EndContext();
            BeginContext(953, 123, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <span>\r\n            Seleccione el Jedi:\r\n        </span>\r\n        ");
            EndContext();
            BeginContext(1076, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4e5735a80f54bf4949fd5e0addb27e9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 39 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Orders\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = GetJedisSelectList(jediApp.GetAll());

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1174, 156, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <span>\r\n            Seleccione el Holograma:\r\n        </span>\r\n        ");
            EndContext();
            BeginContext(1330, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da05e6261f5c49b6a4e55336f8d25ef4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 48 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Orders\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = GetHologramsSelectList(hologramsApp.GetHologramsActive());

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1453, 1370, true);
            WriteLiteral(@"
    </div>
</div>
<br />
<div class=""row"">
    <div class=""col-md-4"">
        <div id=""alertMessage"" class=""alert alert-success"">
            <span id=""lblMessage"">
                Seleccione el Jedi y Holograma para realizar un pedido.
            </span>
        </div>
    </div>
    <div class=""col-md-2"">
        <a id=""btnRegister"" class=""btn btn-primary btn-lg active"" role=""button"" aria-pressed=""true"" href=""#"">Registrar pedido</a>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        $('#btnRegister').on('click', function (evt) {
            evt.preventDefault();
            $.ajax({
                type: 'POST',
                url: '/Orders/Create',
                data:
                {
                    JediId: $(""#jedi"").val(),
                    HologramId: $(""#hologram"").val(),
                },
                success: function (result) {
                   $(""#lblMessage"").html(result.description);
                    if (result.isErr");
            WriteLiteral(@"or) {
                        $(""#alertMessage"").removeClass(""alert-success"").addClass(""alert-danger"");
                    }
                    else {
                        $(""#alertMessage"").removeClass(""alert-danger"").addClass(""alert-success"");
                    }
                }
            });
        });
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
#line 12 "C:\Users\rlenin\Documents\Test\SOLUTIONS.GALAXY.Web\Views\Orders\Index.cshtml"
           

    public IEnumerable<SelectListItem> GetJedisSelectList(IList<Jedi> jedis)
    {
        var deptList = new List<SelectListItem>();
        foreach (var eVal in jedis.Where(x => x.Status))
        {
            deptList.Add(new SelectListItem { Text = eVal.Name, Value = eVal.Id.ToString() });
        }
        return deptList;
    }
    public IEnumerable<SelectListItem> GetHologramsSelectList(IList<Hologram> holograms)
    {
        var deptList = new List<SelectListItem>();
        foreach (var eVal in holograms)
        {
            deptList.Add(new SelectListItem { Text = eVal.Name, Value = eVal.Id.ToString() });
        }
        return deptList;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHologramsApp hologramsApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJediApp jediApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HologramList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
