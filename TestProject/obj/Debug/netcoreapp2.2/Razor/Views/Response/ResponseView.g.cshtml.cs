#pragma checksum "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c9ece76b190e8a211ee3a13c9a24ec7c1f05d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Response_ResponseView), @"mvc.1.0.view", @"/Views/Response/ResponseView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Response/ResponseView.cshtml", typeof(AspNetCore.Views_Response_ResponseView))]
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
#line 1 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject;

#line default
#line hidden
#line 2 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9ece76b190e8a211ee3a13c9a24ec7c1f05d28", @"/Views/Response/ResponseView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5793b3861753add5f6e734f58173abd93064819", @"/Views/_ViewImports.cshtml")]
    public class Views_Response_ResponseView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestProject.Models.ResponseInformationViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
  
    ViewData["Title"] = "ResponseView";

#line default
#line hidden
            BeginContext(119, 111, true);
            WriteLiteral("\r\n<h1>ResponseView</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(231, 47, false);
#line 13 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayNameFor(model => model.NameService));

#line default
#line hidden
            EndContext();
            BeginContext(278, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(334, 47, false);
#line 16 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(381, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(437, 47, false);
#line 19 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestTime));

#line default
#line hidden
            EndContext();
            BeginContext(484, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(540, 56, false);
#line 22 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayNameFor(model => model.CountFailuresPerHour));

#line default
#line hidden
            EndContext();
            BeginContext(596, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(652, 55, false);
#line 25 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayNameFor(model => model.CountFailuresPerDay));

#line default
#line hidden
            EndContext();
            BeginContext(707, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(763, 54, false);
#line 28 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscrepancyPerHour));

#line default
#line hidden
            EndContext();
            BeginContext(817, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(873, 53, false);
#line 31 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscrepancyPerDay));

#line default
#line hidden
            EndContext();
            BeginContext(926, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1044, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1093, 46, false);
#line 40 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameService));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1195, 46, false);
#line 43 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1297, 46, false);
#line 46 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequestTime));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1399, 55, false);
#line 49 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayFor(modelItem => item.CountFailuresPerHour));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1510, 54, false);
#line 52 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayFor(modelItem => item.CountFailuresPerDay));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1620, 53, false);
#line 55 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiscrepancyPerHour));

#line default
#line hidden
            EndContext();
            BeginContext(1673, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1729, 52, false);
#line 58 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiscrepancyPerDay));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "C:\Users\asana\OneDrive\Рабочий стол\TestProject\TestProject\Views\Response\ResponseView.cshtml"
}

#line default
#line hidden
            BeginContext(1820, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestProject.Models.ResponseInformationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
