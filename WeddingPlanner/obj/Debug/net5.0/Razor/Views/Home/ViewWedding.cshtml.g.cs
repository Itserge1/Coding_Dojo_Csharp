#pragma checksum "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2401d5f32e508c8f0b3ea0b52e9e19fac173d483"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewWedding), @"mvc.1.0.view", @"/Views/Home/ViewWedding.cshtml")]
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
#line 1 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2401d5f32e508c8f0b3ea0b52e9e19fac173d483", @"/Views/Home/ViewWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17fc3f5ee4e23fcd11f0e6452031d9952f5f9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2401d5f32e508c8f0b3ea0b52e9e19fac173d4833308", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <title>Document</title>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2401d5f32e508c8f0b3ea0b52e9e19fac173d4834458", async() => {
                WriteLiteral("\n    <h1>");
#nullable restore
#line 12 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml"
   Write(Model.WedderOne);

#line default
#line hidden
#nullable disable
                WriteLiteral(" and ");
#nullable restore
#line 12 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml"
                        Write(Model.WedderTwo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \'s Wedding</h1>\n    <h2>");
#nullable restore
#line 13 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml"
   Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n    <h3>Guess</h3>\n    <ul>\n");
#nullable restore
#line 16 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml"
          
            foreach( Guess u in @Model.GuessI)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li>");
#nullable restore
#line 19 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml"
               Write(u.UserI.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
#nullable restore
#line 19 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml"
                                   Write(u.UserI.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\n");
#nullable restore
#line 20 "/Users/sergehountondji/Downloads/dojo_assigment/Coding_Dojo/csharp/WeddingPlanner/Views/Home/ViewWedding.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n    <a href=\"/dashboard\">Dashboard</a>  |  <a href=\"/logout\">Logout</a>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
