#pragma checksum "C:\Users\dada\source\repos\BooksApi\BooksApi\Views\Books\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edfd1f37a1812133302e44c865b749cde8af02d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Edit), @"mvc.1.0.view", @"/Views/Books/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Edit.cshtml", typeof(AspNetCore.Views_Books_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edfd1f37a1812133302e44c865b749cde8af02d5", @"/Views/Books/Edit.cshtml")]
    public class Views_Books_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksApi.Models.Books>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dada\source\repos\BooksApi\BooksApi\Views\Books\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(72, 1807, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Books</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Id"" class=""control-label""></label>
                <input asp-for=""Id"" class=""form-control"" />
                <span asp-validation-for=""Id"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""BookName"" class=""control-label""></label>
                <input asp-for=""BookName"" class=""form-control"" />
                <span asp-validation-for=""BookName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
       ");
            WriteLiteral(@"     <div class=""form-group"">
                <label asp-for=""Category"" class=""control-label""></label>
                <input asp-for=""Category"" class=""form-control"" />
                <span asp-validation-for=""Category"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Author"" class=""control-label""></label>
                <input asp-for=""Author"" class=""form-control"" />
                <span asp-validation-for=""Author"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1897, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\dada\source\repos\BooksApi\BooksApi\Views\Books\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksApi.Models.Books> Html { get; private set; }
    }
}
#pragma warning restore 1591
