#pragma checksum "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2cf3e830239cd566ce1baa4a99f80596af96726"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UI_grid.Pages.Pages__12), @"mvc.1.0.razor-page", @"/Pages/_12.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/_12.cshtml", typeof(UI_grid.Pages.Pages__12), null)]
namespace UI_grid.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_ViewImports.cshtml"
using UI_grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2cf3e830239cd566ce1baa4a99f80596af96726", @"/Pages/_12.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2f2e0ff53d0b122217bf27d3bece029a1b00c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages__12 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
  
    ViewData["Title"] = "_12";

#line default
#line hidden
            BeginContext(77, 27, true);
            WriteLiteral("\r\n<h2>_12</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(105, 22, false);
#line 10 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
Write(Model.Question.Content);

#line default
#line hidden
            EndContext();
            BeginContext(127, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(137, 997, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c9e8a91f0dc4ca585e38326cba0b351", async() => {
                BeginContext(157, 15, true);
                WriteLiteral("\r\n    <table>\r\n");
                EndContext();
#line 15 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
         for (int i = 0; i < Model.Answers.Count; i++)
        {

#line default
#line hidden
                BeginContext(239, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(300, 24, false);
#line 19 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
               Write(Model.Answers[i].Content);

#line default
#line hidden
                EndContext();
                BeginContext(324, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(325, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14cccb9a8611402c8f5471501a6f9f12", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 19 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Answers[i].Correct);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(363, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 20 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
                     if (Model.Messages != null)
                    {
                        if (Model.Messages[i].Equals("Correct"))
                        {

#line default
#line hidden
                BeginContext(531, 55, true);
                WriteLiteral("                            <span style=\"color: green\">");
                EndContext();
                BeginContext(587, 17, false);
#line 24 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
                                                  Write(Model.Messages[i]);

#line default
#line hidden
                EndContext();
                BeginContext(604, 10, true);
                WriteLiteral(" </span>\r\n");
                EndContext();
#line 25 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(698, 53, true);
                WriteLiteral("                            <span style=\"color: red\">");
                EndContext();
                BeginContext(752, 17, false);
#line 28 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
                                                Write(Model.Messages[i]);

#line default
#line hidden
                EndContext();
                BeginContext(769, 10, true);
                WriteLiteral(" </span>\r\n");
                EndContext();
#line 29 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(829, 54, true);
                WriteLiteral("                </td>\r\n            </tr>\r\n            ");
                EndContext();
                BeginContext(883, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "db5fceeea9c74bc5b2cd24efa41b4eba", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 33 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Answers[i].Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
                                                    WriteLiteral(Model.Answers[i].Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(959, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\Kolya\Documents\BU MET CS\CS795\Project_795\UI_grid\Pages\_12.cshtml"
        }

#line default
#line hidden
                BeginContext(972, 155, true);
                WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                <input id=\"Submit1\" type=\"submit\" value=\"submit\" />\r\n            </td>\r\n\r\n        </tr>\r\n\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UI_grid.Pages._12Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UI_grid.Pages._12Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UI_grid.Pages._12Model>)PageContext?.ViewData;
        public UI_grid.Pages._12Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
