#pragma checksum "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95158a32213e0e09010b7c750b4b4c1d0bf6b36f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vitrin_Components_FoodGetList_Default), @"mvc.1.0.view", @"/Views/Vitrin/Components/FoodGetList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vitrin/Components/FoodGetList/Default.cshtml", typeof(AspNetCore.Views_Vitrin_Components_FoodGetList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95158a32213e0e09010b7c750b4b4c1d0bf6b36f", @"/Views/Vitrin/Components/FoodGetList/Default.cshtml")]
    public class Views_Vitrin_Components_FoodGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Food>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:240px; height:120px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 38, true);
            WriteLiteral("<div class=\"agile_top_brands_grids\">\r\n");
            EndContext();
#line 3 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(122, 434, true);
            WriteLiteral(@"    <div class=""col-md-3 top_brand_left"" style=""margin-bottom:30px"">
        <div class=""hover14 column"">
            <div class=""agile_top_brand_left_grid"">              
                <div class=""agile_top_brand_left_grid1"">
                    <figure>
                        <div class=""snipcart-item block"">
                            <div class=""snipcart-thumb"">
                                <a href=""single.html"">");
            EndContext();
            BeginContext(556, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd3b1ebed490412296d5a5e8d21140f7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
AddHtmlAttributeValue("", 602, item.Name, 602, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
AddHtmlAttributeValue("", 619, item.Description, 619, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 643, "~/resimler/", 643, 11, true);
#line 12 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
AddHtmlAttributeValue("", 654, item.ImageUrl, 654, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(672, 41, true);
            WriteLiteral("</a>\r\n                                <p>");
            EndContext();
            BeginContext(714, 9, false);
#line 13 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(723, 42, true);
            WriteLiteral("</p>\r\n                                <h4>");
            EndContext();
            BeginContext(766, 10, false);
#line 14 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
                               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(776, 16, true);
            WriteLiteral(" ₺</h4><h6>Stok:");
            EndContext();
            BeginContext(793, 10, false);
#line 14 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
                                                          Write(item.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(803, 1485, true);
            WriteLiteral(@"</h6>
                            </div>
                            <div class=""snipcart-details top_brand_home_details"">
                                <form action=""checkout.html"" method=""post"">
                                    <fieldset>
                                        <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                        <input type=""hidden"" name=""add"" value=""1"" />
                                        <input type=""hidden"" name=""business"" value="" "" />
                                        <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                        <input type=""hidden"" name=""amount"" value=""7.99"" />
                                        <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                        <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                        <input type=""hidden"" name=""return"" value="" "" />
              ");
            WriteLiteral(@"                          <input type=""hidden"" name=""cancel_return"" value="" "" />
                                        <input type=""submit"" name=""submit"" value=""Add to cart"" class=""button"" />
                                    </fieldset>

                                </form>

                            </div>
                        </div>
                    </figure>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 40 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Vitrin\Components\FoodGetList\Default.cshtml"
}

#line default
#line hidden
            BeginContext(2291, 39, true);
            WriteLiteral("<div class=\"clearfix\"> </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591