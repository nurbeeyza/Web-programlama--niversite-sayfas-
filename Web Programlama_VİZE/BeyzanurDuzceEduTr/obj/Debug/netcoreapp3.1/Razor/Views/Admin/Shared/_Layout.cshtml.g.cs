#pragma checksum "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e611a54d3697140c0485d115ae5858582d90c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Shared__Layout), @"mvc.1.0.view", @"/Views/Admin/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e611a54d3697140c0485d115ae5858582d90c2", @"/Views/Admin/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53c18be5b9fb594cf04fdfc50cf5c279df21d15", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\" data-layout=\"vertical\" data-topbar=\"light\" data-sidebar=\"dark\" data-sidebar-size=\"lg\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e611a54d3697140c0485d115ae5858582d90c23479", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 4 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
Write(Html.Partial("~/Views/Admin/Shared/_title_meta.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 5 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
Write(Html.Partial("~/Views/Admin/Shared/_head_css.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e611a54d3697140c0485d115ae5858582d90c25283", async() => {
                WriteLiteral("\r\n    <!-- Begin page -->\r\n    <div id=\"layout-wrapper\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
   Write(Html.Partial("~/Views/Admin/Shared/_menu.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!-- ============================================================== -->
        <!-- Start right Content here -->
        <!-- ============================================================== -->
        <div class=""main-content"">

            <div class=""page-content"">
                <div class=""container-fluid"">
                    ");
#nullable restore
#line 20 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
               Write(Html.Partial("~/Views/Admin/Shared/_page_title.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 22 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            ");
#nullable restore
#line 25 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
       Write(Html.Partial("~/Views/Admin/Shared/_footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n    <!-- END layout-wrapper -->\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 32 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
Write(Html.Partial("~/Views/Admin/Shared/_vendor_scripts.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 34 "C:\Users\Beyza\Desktop\Web Programlama_VİZE\BeyzanurDuzceEduTr\Views\Admin\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
