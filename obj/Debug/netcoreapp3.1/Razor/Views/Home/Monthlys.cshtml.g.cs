#pragma checksum "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e4bd02dd126f5abed4cfce73577141f5d0e1da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Monthlys), @"mvc.1.0.view", @"/Views/Home/Monthlys.cshtml")]
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
#line 1 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\_ViewImports.cshtml"
using PaperTrades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\_ViewImports.cshtml"
using PaperTrades.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e4bd02dd126f5abed4cfce73577141f5d0e1da", @"/Views/Home/Monthlys.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a98aa757b0d63b4b58b59130720e790adc89e9d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Monthlys : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/images/DownArrow.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 15px; border-radius: 22px 22px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""scroller"">
    <table class=""table table-striped text-center table-dark table-sm "">
        <thead>
            <tr>
                <th colspan=""8"">Monthly Movers</th>
            </tr>
            <th>Coin</th>
            <th>Price</th>
            <th>1H</th>
            <th>1D</th>
            <th>1W</th>
            <th>1M</th>
            <th>Market Cap");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23e4bd02dd126f5abed4cfce73577141f5d0e1da4558", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n            <th>Volume</th>\r\n    </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
              
                foreach (var c in @ViewBag.AllCryptos2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 21 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                          
                            if( c.price_change_percentage_30d_in_currency > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"align-middle\"><img");
            BeginWriteAttribute("src", " src=\"", 869, "\"", 883, 1);
#nullable restore
#line 24 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
WriteAttributeValue("", 875, c.image, 875, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 50px;\"");
            BeginWriteAttribute("alt", " alt=\"", 906, "\"", 917, 1);
#nullable restore
#line 24 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
WriteAttributeValue("", 912, c.id, 912, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <h5 class=\"fs-6\">");
#nullable restore
#line 24 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                                                                            Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\r\n");
#nullable restore
#line 25 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                if (c.current_price <= 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-info\">$");
#nullable restore
#line 27 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                   Write(c.current_price.ToString("#,##0.#0####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-info\">$");
#nullable restore
#line 29 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                   Write(c.current_price.ToString("#,##0.#0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }
                                if (c.price_change_percentage_1h_in_currency >= 0) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-success\">+");
#nullable restore
#line 33 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                      Write(c.price_change_percentage_1h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 34 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-danger\">");
#nullable restore
#line 35 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                    Write(c.price_change_percentage_1h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 36 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }
                                if (c.price_change_percentage_24h_in_currency >= 0) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-success\">+");
#nullable restore
#line 39 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                      Write(c.price_change_percentage_24h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 40 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-danger\">");
#nullable restore
#line 41 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                    Write(c.price_change_percentage_24h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 42 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }
                                if (c.price_change_percentage_7d_in_currency >= 0) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-success\">+");
#nullable restore
#line 45 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                      Write(c.price_change_percentage_7d_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 46 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-danger\">");
#nullable restore
#line 47 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                    Write(c.price_change_percentage_7d_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 48 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"align-middle text-success\">+");
#nullable restore
#line 49 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                  Write(c.price_change_percentage_30d_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 50 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                    Write(c.market_cap.ToString("#,##0.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 51 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                    Write(c.total_volume.ToString("#,##0.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<div class=""mt-3 scroller"">
    <table class=""table table-striped text-center table-dark table-sm"">
        <thead>
            <tr>
                <th colspan=""8"">Monthly Losers</th>
            </tr>
            <th>Coin</th>
            <th>Price</th>
            <th>1H</th>
            <th>1D</th>
            <th>1W</th>
            <th>1M</th>
            <th>Market Cap");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23e4bd02dd126f5abed4cfce73577141f5d0e1da15306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n            <th>Volume</th>\r\n    </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 76 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
              
                foreach (var c in @ViewBag.AllCryptos2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 80 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                          
                            if( c.price_change_percentage_30d_in_currency < 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"align-middle\"><img");
            BeginWriteAttribute("src", " src=\"", 4191, "\"", 4205, 1);
#nullable restore
#line 83 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
WriteAttributeValue("", 4197, c.image, 4197, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 50px;\"");
            BeginWriteAttribute("alt", " alt=\"", 4228, "\"", 4239, 1);
#nullable restore
#line 83 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
WriteAttributeValue("", 4234, c.id, 4234, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <h5 class=\"fs-6\">");
#nullable restore
#line 83 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                                                                            Write(c.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\r\n");
#nullable restore
#line 84 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                if (c.current_price < 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-info\">$");
#nullable restore
#line 86 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                   Write(c.current_price.ToString("#,##0.#0####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 87 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-info\">$");
#nullable restore
#line 88 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                   Write(c.current_price.ToString("#,##0.#0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 89 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }
                                if (c.price_change_percentage_1h_in_currency >= 0) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-success\">+");
#nullable restore
#line 92 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                      Write(c.price_change_percentage_1h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 93 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-danger\">");
#nullable restore
#line 94 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                    Write(c.price_change_percentage_1h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 95 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }
                                if (c.price_change_percentage_24h_in_currency >= 0) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-success\">+");
#nullable restore
#line 98 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                      Write(c.price_change_percentage_24h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 99 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-danger\">");
#nullable restore
#line 100 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                    Write(c.price_change_percentage_24h_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 101 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }
                                if (c.price_change_percentage_7d_in_currency >= 0) 
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-success\">+");
#nullable restore
#line 104 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                      Write(c.price_change_percentage_7d_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 105 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"align-middle text-danger\">");
#nullable restore
#line 106 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                    Write(c.price_change_percentage_7d_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n");
#nullable restore
#line 107 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"align-middle text-danger\">");
#nullable restore
#line 108 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                                Write(c.price_change_percentage_30d_in_currency.ToString("#,##0.0#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 109 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                    Write(c.market_cap.ToString("#,##0.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
#nullable restore
#line 110 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                                                    Write(c.total_volume.ToString("#,##0.#"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 111 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 114 "C:\Users\dhrus\OneDrive\Desktop\C#\PaperTrades\Views\Home\Monthlys.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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