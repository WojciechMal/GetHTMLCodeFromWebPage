#pragma checksum "D:\Programowanie\.NET CORE\Zadanie_Britenet\Views\Result\ResultIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4358213955cf5f5e74b684060b9258b73d9885c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Result_ResultIndex), @"mvc.1.0.view", @"/Views/Result/ResultIndex.cshtml")]
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
#line 1 "D:\Programowanie\.NET CORE\Zadanie_Britenet\Views\_ViewImports.cshtml"
using GetHTMLCodeAndImgsFromWebPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4358213955cf5f5e74b684060b9258b73d9885c9", @"/Views/Result/ResultIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e8e6d1e5b2d2068be8695dbdb9ebeafaf1a15e", @"/Views/_ViewImports.cshtml")]
    public class Views_Result_ResultIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col alert alert-danger m-3 rounded-3\">\r\n        Proszę wprowadzić adres strony zaczynając od \"http://\"\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 7 "D:\Programowanie\.NET CORE\Zadanie_Britenet\Views\Result\ResultIndex.cshtml"
 using (Html.BeginForm("GoBack", "Result"))
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input class=\"btn btn-primary m-3\" type=\"submit\" value=\"Powrót\" />\r\n");
#nullable restore
#line 11 "D:\Programowanie\.NET CORE\Zadanie_Britenet\Views\Result\ResultIndex.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
