#pragma checksum "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd005524d7de7d7c28fbf1571a3597fa9652b706"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodAdd), @"mvc.1.0.view", @"/Views/Food/FoodAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/FoodAdd.cshtml", typeof(AspNetCore.Views_Food_FoodAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd005524d7de7d7c28fbf1571a3597fa9652b706", @"/Views/Food/FoodAdd.cshtml")]
    public class Views_Food_FoodAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.productAdd>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
  
    ViewData["Title"] = "FoodAdd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 148, true);
            WriteLiteral("\r\n<h2>Food Add Page</h2>\r\n<br />\r\n<form class=\"form-group\" action=\"FoodAdd\" asp-controller=\"Food\" method=\"post\" enctype=\"multipart/form-data\">\r\n    ");
            EndContext();
            BeginContext(282, 23, false);
#line 10 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
            EndContext();
            BeginContext(305, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(312, 61, false);
#line 11 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(373, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(380, 72, false);
#line 12 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.Name, "", new { @style = "color:red" }));

#line default
#line hidden
            EndContext();
            BeginContext(452, 18, true);
            WriteLiteral("\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(471, 19, false);
#line 14 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
            EndContext();
            BeginContext(490, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(497, 62, false);
#line 15 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(559, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(566, 73, false);
#line 16 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.Stock, "", new { @style = "color:red" }));

#line default
#line hidden
            EndContext();
            BeginContext(639, 20, true);
            WriteLiteral("\r\n    <br />\r\n\r\n    ");
            EndContext();
            BeginContext(660, 19, false);
#line 19 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
            EndContext();
            BeginContext(679, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(686, 62, false);
#line 20 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(748, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(755, 73, false);
#line 21 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.Price, "", new { @style = "color:red" }));

#line default
#line hidden
            EndContext();
            BeginContext(828, 18, true);
            WriteLiteral("\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(847, 23, false);
#line 23 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Image Url"));

#line default
#line hidden
            EndContext();
            BeginContext(870, 61, true);
            WriteLiteral("\r\n    <input type=\"file\" name=\"ImageUrl\" />\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(932, 22, false);
#line 26 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
            EndContext();
            BeginContext(954, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(961, 106, false);
#line 27 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.v1, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1074, 78, false);
#line 28 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryID, "", new { @style = "color:red" }));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 20, true);
            WriteLiteral("\r\n\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(1173, 25, false);
#line 31 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1205, 69, false);
#line 32 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1281, 79, false);
#line 33 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Food\FoodAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.Description, "", new { @style = "color:red" }));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 76, true);
            WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-success\">Save</button>\r\n</form>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.productAdd> Html { get; private set; }
    }
}
#pragma warning restore 1591
