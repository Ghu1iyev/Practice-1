#pragma checksum "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93221e84ad171d0e3c0aca6331d2605fb69fdbf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml"
using Practice_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93221e84ad171d0e3c0aca6331d2605fb69fdbf7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54847e1e0c8f1b14853d8f64eaed39fdb93fde7a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/skills-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <main>\r\n      <section id=\"services\">\r\n          <div class=\"cards mt-4\">\r\n              <div class=\"container\">\r\n                  <div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml"
                      foreach (Card card in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <div class=\"card col-lg-4 d-flex align-items-stretch\">\r\n                          <div class=\"icons\">\r\n                              <i");
            BeginWriteAttribute("class", " class=\"", 459, "\"", 486, 2);
            WriteAttributeValue("", 467, "fa-solid", 467, 8, true);
#nullable restore
#line 16 "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 475, card.Icon, 476, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                          </div>\r\n                          <div class=\"title\">\r\n                              <h2>");
#nullable restore
#line 19 "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml"
                             Write(card.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                          </div>\r\n                          <div class=\"description\">\r\n                              <p>");
#nullable restore
#line 22 "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml"
                            Write(card.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                          </div>\r\n                      </div>\r\n");
#nullable restore
#line 25 "C:\Users\fazil\Desktop\BackEnd\Practice-1\Practice-1\Views\Home\Index.cshtml"
                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </div>
              </div>
          </div>
      </section>
      <section id=""skills"">
          <div class=""container"">
              <div class=""row"">
                <div class=""title text-center"">
                    <h2>Our Skills</h2>
                </div>
                <div class=""description text-center"">
                    <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
                </div>
               
              </div>
            <div class=""about mt-3"">
                <div class=""row"">               
                    <div class=""img col-lg-6"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93221e84ad171d0e3c0aca6331d2605fb69fdbf76839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""skill col-lg-6"">
                        <div class=""title"">
                            <h2>
                                Voluptatem dignissimos provident quasi corporis voluptates</h2>
                        </div>
                        <div class=""desc"">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt direna past reda</p>
                        </div>
                        <span>HTML</span>
                        <span style=""position:absolute; right: 115px;"">100%</span>
                        <div class=""html mb-4"">
                        </div>
                        <span>CSS</span>
                        <span style=""position:absolute; right: 175px;"">90%</span>
                        <div class=""css mb-4"">
                        </div>
                        <span>JAVASCRIPT</span>
                        <span style=""position:absolute;");
            WriteLiteral(@" right: 270px;"">75%</span>
                        <div class=""js mb-4""></div>
                        <span>PHOTOSHOP</span>
                        <span style=""position:absolute; right: 400px;"">55%</span>
                        <div class=""ps mb-4""></div>
                    </div>
                
              </div>
            </div>
          </div>
      </section>
    </main>

");
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
