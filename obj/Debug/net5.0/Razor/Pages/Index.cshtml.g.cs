#pragma checksum "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f194fb79c5bcf6c17bcc608b30e66054b7051060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProTrailers.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ProTrailers.Pages
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
#line 1 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\_ViewImports.cshtml"
using ProTrailers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f194fb79c5bcf6c17bcc608b30e66054b7051060", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e80bd93396446f8d44bfd91920907cb8d1b709b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mx-auto\">\r\n    <div class=\"container mt-12 border-gray-600 border-b-2 w-1/4\">\r\n        <h1 class=\" font-black text-gray-700 text-4xl\">Trailers Disponibles</h1>\r\n    </div>\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f194fb79c5bcf6c17bcc608b30e66054b70510604298", async() => {
                WriteLiteral("\r\n        <div class=\"form-actions no-color\">\r\n            <p>\r\n                Find by name:\r\n                <input type=\"text\" name=\"busqueda\"");
                BeginWriteAttribute("value", " value=\"", 459, "\"", 488, 1);
#nullable restore
#line 17 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
WriteAttributeValue("", 467, Model.filtroBusqueda, 467, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"submit\" value=\"Buscar\" class=\"btn btn-primary\" /> |\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f194fb79c5bcf6c17bcc608b30e66054b70510605247", async() => {
                    WriteLiteral("Lista Completa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"container mx-auto flex flex-row justify-between flex-wrap\">\r\n");
#nullable restore
#line 24 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
         foreach (var item in Model.Movie)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"max-w-sm max-h-full rounded overflow-hidden shadow-lg mt-10\">\r\n");
#nullable restore
#line 27 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
                  string urlFinal = item.Video.Replace("watch?v=", "embed/");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <iframe style=\"width: 100%;\"\r\n                        height=\"215\"");
            BeginWriteAttribute("src", "\r\n                        src=\"", 1066, "\"", 1106, 1);
#nullable restore
#line 32 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
WriteAttributeValue("", 1097, urlFinal, 1097, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                        frameborder=""0""
                        allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture""
                        allowfullscreen></iframe>
                <div class=""px-6 py-4"">
                    <div class=""font-bold text-black text-xl mb-2"">");
#nullable restore
#line 37 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
                                                              Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p class=\"text-gray-700 text-base\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
                   Write(item.Sinopsis);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <br>\r\n                    <p><b class=\"font-bold\">Dirigido por:</b> ");
#nullable restore
#line 42 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
                                                         Write(item.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><b class=\"font-bold\">Fecha de estreno:</b> ");
#nullable restore
#line 43 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
                                                             Write(item.Fecha.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                </div>\r\n                <div class=\"px-6 py-4\">\r\n                    <span class=\"inline-bloc bg-blue-600 rounded-full px-3 py-1 text-sm font-semibold text-gray-200\">");
#nullable restore
#line 47 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
                                                                                                                Write(item.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "C:\Users\Elvin Somon\Documents\Algoritmos\Pruebas C#\Entrevista\ProTrailers - DotNet V2.0\ProTrailers\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"mt-5\">\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
