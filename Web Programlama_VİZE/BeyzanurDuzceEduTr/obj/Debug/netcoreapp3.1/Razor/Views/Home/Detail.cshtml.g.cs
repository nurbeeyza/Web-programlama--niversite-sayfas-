#pragma checksum "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97c381ec7b8ff0b7f8f969dd645301c3bdc1bcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\_ViewImports.cshtml"
using BeyzanurDuzceEduTr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\_ViewImports.cshtml"
using BeyzanurDuzceEduTr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97c381ec7b8ff0b7f8f969dd645301c3bdc1bcb", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53c18be5b9fb594cf04fdfc50cf5c279df21d15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BeyzanurDuzceEduTr.Models.Entities.Announcement>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center mx-auto pb-4 wow fadeInUp"" data-wow-delay=""0.1s"" style=""max-width: 600px; visibility: visible; animation-delay: 0.1s; animation-name: fadeInUp;"">
            <p>");
#nullable restore
#line 11 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Home\Detail.cshtml"
          Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h1 class=\"display-5 mb-4\">");
#nullable restore
#line 12 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Home\Detail.cshtml"
                                  Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row gy-5 gx-4\">\r\n            <p class=\"mb-4\">\r\n                ");
#nullable restore
#line 16 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Home\Detail.cshtml"
           Write(Model.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeyzanurDuzceEduTr.Models.Entities.Announcement> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
