#pragma checksum "C:\Users\Hugo\Desktop\PetShop\PetShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe17c3acb47d53ee4e0d41f44ce1b1a3b28c1418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe17c3acb47d53ee4e0d41f44ce1b1a3b28c1418", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetShop.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Hugo\Desktop\PetShop\PetShop\Views\Home\Index.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
            BeginContext(69, 103, true);
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"alert alert-success\">\r\n            ");
            EndContext();
            BeginContext(173, 17, false);
#line 7 "C:\Users\Hugo\Desktop\PetShop\PetShop\Views\Home\Index.cshtml"
       Write(Model.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(190, 74, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-12\">\r\n\r\n            <table>\r\n");
            EndContext();
#line 12 "C:\Users\Hugo\Desktop\PetShop\PetShop\Views\Home\Index.cshtml"
                 foreach (var item in Model.Pet)
                {

#line default
#line hidden
            BeginContext(333, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(418, 9, false);
#line 16 "C:\Users\Hugo\Desktop\PetShop\PetShop\Views\Home\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(427, 62, true);
            WriteLiteral(" -\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 19 "C:\Users\Hugo\Desktop\PetShop\PetShop\Views\Home\Index.cshtml"


                }

#line default
#line hidden
            BeginContext(512, 58, true);
            WriteLiteral("            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetShop.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
