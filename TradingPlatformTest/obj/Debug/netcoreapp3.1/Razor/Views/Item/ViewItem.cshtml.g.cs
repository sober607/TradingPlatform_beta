#pragma checksum "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bd4acd756bfc0c1657ba6a425557aa9b6cc5d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_ViewItem), @"mvc.1.0.view", @"/Views/Item/ViewItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd4acd756bfc0c1657ba6a425557aa9b6cc5d60", @"/Views/Item/ViewItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c1fa71c3d9360ffabd22abf547e7ccc63b99e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_ViewItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"

    if (ViewBag.nullItem != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
       Write(ViewBag.nullItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 10 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"itemArea\">\r\n\r\n            <table border=\"1\">\r\n                <tr>\r\n                    <td><center><h2>");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                               Write(Model.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></center></td>\r\n                    <td rowspan=\"2\" >\r\n");
#nullable restore
#line 19 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                          
                            if (@Model.ItemDescription != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Description</h3><br />\r\n");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                           Write(Model.ItemDescription);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                                                      
                            }


                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td><center><img");
            BeginWriteAttribute("src", " src=\"", 830, "\"", 849, 1);
#nullable restore
#line 31 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
WriteAttributeValue("", 836, Model.ImgUrl, 836, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height: 500px; max-width: 300px\" /></center></td>\r\n                    \r\n                </tr>\r\n\r\n                <tr>\r\n                    <td></td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                   Write(Model.SellerPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                                       Write(Model.SellerCurrency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td></td>\r\n                    <td>\r\n");
#nullable restore
#line 43 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                          
                            if (Model.BuyerPrice != 0 && Model.BuyerPrice != null)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral(" Model.BuyerPrice <b>Model.BuyerCurrency</b>");
#nullable restore
#line 46 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
                                                                                         
                            }


                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <td></td>\r\n                    <td>Buy</td>\r\n                </tr>\r\n\r\n            </table> \r\n\r\n        </div>\r\n");
#nullable restore
#line 63 "C:\Users\Admin\source\repos\TradingPlatformTest\TradingPlatformTest\Views\Item\ViewItem.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591