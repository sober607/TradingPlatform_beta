#pragma checksum "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c62c695029a1459c380d8a66e690db0a84a8b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Category), @"mvc.1.0.view", @"/Views/Items/Category.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\_ViewImports.cshtml"
using TradingPlatformTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\_ViewImports.cshtml"
using TradingPlatformTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\_ViewImports.cshtml"
using TradingPlatformTest.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c62c695029a1459c380d8a66e690db0a84a8b0", @"/Views/Items/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c1fa71c3d9360ffabd22abf547e7ccc63b99e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
  
    if (@ViewBag.CategoryName != null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <center><h1>List of items of ");
#nullable restore
#line 5 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
                                Write(ViewBag.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" category</h1></center>\r\n        <div style=\"display: flex; flex-direction: row; flex-wrap: wrap\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
             foreach (ItemListViewModel t in (ViewBag.ItemsList as List<ItemListViewModel> )  )
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"width: 180px; height: 250px; margin: 10px; border: 1px solid black\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28c62c695029a1459c380d8a66e690db0a84a8b05046", async() => {
                WriteLiteral("\r\n                        <div><center><img style=\"max-height: 200px; max-width: 175px\"");
                BeginWriteAttribute("src", " src=\"", 610, "\"", 625, 1);
#nullable restore
#line 12 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
WriteAttributeValue("", 616, t.ImgUrl, 616, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></center></div>\r\n                        <div>");
#nullable restore
#line 13 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
                        Write(t.ItemName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div>");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
                        Write(t.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
                                 Write(t.Currency);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-itemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
                                                                         WriteLiteral(t.ItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-itemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["itemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<center><h1>Category not found</h1></center>\r\n");
#nullable restore
#line 26 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Items\Category.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
