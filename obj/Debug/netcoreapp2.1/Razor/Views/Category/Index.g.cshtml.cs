#pragma checksum "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f7d99fc9247bc34935d1dadda967519bf168ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7d99fc9247bc34935d1dadda967519bf168ec8", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 34, true);
            WriteLiteral("\r\n<h2>Category List</h2>\r\n<br />\r\n");
            EndContext();
#line 9 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(199, 27, true);
            WriteLiteral("    <p>\r\n        Food Name:");
            EndContext();
            BeginContext(227, 19, false);
#line 12 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
             Write(Html.TextBox("par"));

#line default
#line hidden
            EndContext();
            BeginContext(246, 58, true);
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Find\" />\r\n    </p>\r\n");
            EndContext();
#line 15 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
}

#line default
#line hidden
            BeginContext(307, 212, true);
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Category Name</th>\r\n        <th>Status</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Change</th>\r\n    </tr>\r\n");
            EndContext();
#line 25 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(560, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(583, 15, false);
#line 28 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
       Write(item.CategoryID);

#line default
#line hidden
            EndContext();
            BeginContext(598, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(618, 17, false);
#line 29 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
       Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(635, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(655, 11, false);
#line 30 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
       Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(666, 21, true);
            WriteLiteral("</td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 687, "\"", 735, 2);
            WriteAttributeValue("", 694, "/Category/CategoryDelete/", 694, 25, true);
#line 31 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 719, item.CategoryID, 719, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(736, 55, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 791, "\"", 836, 2);
            WriteAttributeValue("", 798, "/Category/CategoryGet/", 798, 22, true);
#line 32 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 820, item.CategoryID, 820, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(837, 56, true);
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 893, "\"", 941, 2);
            WriteAttributeValue("", 900, "/Category/CategoryChange/", 900, 25, true);
#line 33 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 925, item.CategoryID, 925, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(942, 52, true);
            WriteLiteral(" class=\"btn btn-warning\">Pasif</a></td>\r\n    </tr>\r\n");
            EndContext();
#line 35 "D:\DERSLER\YAZILIM DERSLERİ\WEB TASARIMI VE PROGRAMLAMA\WEB ÖRNEKLER\BACK-END\DotNet\Core\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1005, 85, true);
            WriteLiteral("</table>\r\n<a href=\"/Category/CategoryAdd/\" class=\"btn btn-primary\">New Category</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591