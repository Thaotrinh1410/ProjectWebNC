#pragma checksum "C:\Users\asus_vienthonga\Downloads\OrderSystemPJ\Hello.WebApp\Views\Home\_header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03765ec617e84f6e664a4df19ce19489bccbac99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__header), @"mvc.1.0.view", @"/Views/Home/_header.cshtml")]
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
#line 1 "C:\Users\asus_vienthonga\Downloads\OrderSystemPJ\Hello.WebApp\Views\_ViewImports.cshtml"
using Hello.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus_vienthonga\Downloads\OrderSystemPJ\Hello.WebApp\Views\_ViewImports.cshtml"
using Hello.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03765ec617e84f6e664a4df19ce19489bccbac99", @"/Views/Home/_header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34f3112ccbb817533c6a64656cb97ca1d747613", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""p-2"" style=""width: 100%;height: 55px;background: #28a745"">
        <div onclick=""featchAllItem()"" class=""bg-white text-center pt-1 float-left mr-2"" style=""width: 50px;height: 100%;border-radius: 6px"">
            <i class=""fa fa-home text-success"" aria-hidden=""true"" style=""font-size: 200%""></i>
        </div>
    <div onclick=""featchFoodItem()"" class=""bg-white text-center pt-2 float-left mr-2"" style=""width: 150px;height: 100%;border-radius: 6px"">
        <p class=""font-weight-bold text-success""><i class=""fa fa-cutlery mr-2"" aria-hidden=""true""></i>Food</p>
    </div>
    <div onclick=""featchDrinkItem()"" class=""bg-white text-center pt-2 float-left"" style=""width: 150px;height: 100%;border-radius: 6px"">
        <p class=""font-weight-bold text-success""><i class=""fa fa-glass mr-2"" aria-hidden=""true""></i>Drink</p>
    </div>
    <div class=""bg-white float-right pl-2"" style=""width: 250px;height: 100%;border-radius: 6px"">
        <input id=""inputSearch"" placeholder=""Search"" style=""width: 100%;");
            WriteLiteral("height: 100%;background: none;border:0;outline: none;\">\r\n    </div>\r\n</div>\r\n");
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
