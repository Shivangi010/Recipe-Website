#pragma checksum "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\CRUD\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bfa8a5fa1aef31dda8c3063c2a628c819bb7d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CRUD_ViewRecipe), @"mvc.1.0.view", @"/Views/CRUD/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CRUD/ViewRecipe.cshtml", typeof(AspNetCore.Views_CRUD_ViewRecipe))]
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
#line 1 "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\_ViewImports.cshtml"
using Recipe_Project.Models;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\_ViewImports.cshtml"
using Recipe_Project.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bfa8a5fa1aef31dda8c3063c2a628c819bb7d31", @"/Views/CRUD/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffa3959a2b530f9b95ca8b47aa9606eda732ebd", @"/Views/_ViewImports.cshtml")]
    public class Views_CRUD_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeIngredientMapping>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CRUD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-get-started scrollto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 166, true);
            WriteLiteral("<!-- Using BasicLayout file for Header -->\r\n<section id=\"contact\">\r\n    <!--Calling the partial view created in the shared folder named as PartialViewRecipe -->\r\n    ");
            EndContext();
            BeginContext(199, 52, false);
#line 5 "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\CRUD\ViewRecipe.cshtml"
Write(await Html.PartialAsync("PartialViewRecipe", @Model));

#line default
#line hidden
            EndContext();
            BeginContext(251, 16, true);
            WriteLiteral("\r\n    <center>\r\n");
            EndContext();
#line 7 "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\CRUD\ViewRecipe.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(323, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(335, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bff6a4ac12f140d0b5715f8cc3880e0f", async() => {
                BeginContext(447, 45, true);
                WriteLiteral("\r\n                Update Recipe\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\CRUD\ViewRecipe.cshtml"
                                                                                               WriteLiteral(Model.RecipeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(496, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\CRUD\ViewRecipe.cshtml"
        }

#line default
#line hidden
            BeginContext(509, 25, true);
            WriteLiteral("    </center>\r\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeIngredientMapping> Html { get; private set; }
    }
}
#pragma warning restore 1591
