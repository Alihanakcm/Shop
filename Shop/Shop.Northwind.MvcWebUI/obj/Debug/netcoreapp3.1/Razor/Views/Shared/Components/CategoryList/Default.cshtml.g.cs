#pragma checksum "D:\Visual Studio Projects\Shop\Shop.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0a93790aeea3e298062a47df92b73bd3950801"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0a93790aeea3e298062a47df92b73bd3950801", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"976d2047d6c5cfbdf9a679f131dfb8e94215c2ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shop.Northwind.MvcWebUI.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 4 "D:\Visual Studio Projects\Shop\Shop.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var item in Model.Categories)
    {
        var css = "list-group-item list-group-item-action";
        if (@item.CategoryId == Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 314, "\"", 358, 2);
            WriteAttributeValue("", 321, "/Home/Index?category=", 321, 21, true);
#nullable restore
#line 11 "D:\Visual Studio Projects\Shop\Shop.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 342, item.CategoryId, 342, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 359, "\"", 371, 1);
#nullable restore
#line 11 "D:\Visual Studio Projects\Shop\Shop.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 367, css, 367, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "D:\Visual Studio Projects\Shop\Shop.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 12 "D:\Visual Studio Projects\Shop\Shop.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shop.Northwind.MvcWebUI.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
