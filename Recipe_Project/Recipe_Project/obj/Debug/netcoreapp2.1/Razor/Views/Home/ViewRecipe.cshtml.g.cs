#pragma checksum "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\Home\ViewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e698873c2629d9254346962da370ec6159444ae5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRecipe), @"mvc.1.0.view", @"/Views/Home/ViewRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRecipe.cshtml", typeof(AspNetCore.Views_Home_ViewRecipe))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e698873c2629d9254346962da370ec6159444ae5", @"/Views/Home/ViewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffa3959a2b530f9b95ca8b47aa9606eda732ebd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeIngredientMapping>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 166, true);
            WriteLiteral("<!-- Using BasicLayout file for Header -->\r\n<section id=\"contact\">\r\n    <!--Calling the partial view created in the shared folder named as PartialViewRecipe -->\r\n    ");
            EndContext();
            BeginContext(199, 52, false);
#line 5 "C:\Users\DELL\Desktop\Centennial\Load to GitHub\Recipe_Grp5\Recipe_Project\Recipe_Project\Views\Home\ViewRecipe.cshtml"
Write(await Html.PartialAsync("PartialViewRecipe", @Model));

#line default
#line hidden
            EndContext();
            BeginContext(251, 12, true);
            WriteLiteral("\r\n</section>");
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
