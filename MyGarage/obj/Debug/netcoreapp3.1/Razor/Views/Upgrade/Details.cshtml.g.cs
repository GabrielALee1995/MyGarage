#pragma checksum "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9450ad3ae6066782aee61f76c548acb560197dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upgrade_Details), @"mvc.1.0.view", @"/Views/Upgrade/Details.cshtml")]
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
#line 1 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\_ViewImports.cshtml"
using MyGarage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\_ViewImports.cshtml"
using MyGarage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9450ad3ae6066782aee61f76c548acb560197dfe", @"/Views/Upgrade/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ebbb07844b7848dd346e5f52977ba6002e3243", @"/Views/_ViewImports.cshtml")]
    public class Views_Upgrade_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Upgrade>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Upgrade", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListUpgrades", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-edit-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n   <div class=\"col-2 text-center\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9450ad3ae6066782aee61f76c548acb560197dfe5672", async() => {
                WriteLiteral("\r\n         Back\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vehicleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 4 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
                                                                     WriteLiteral(Model.VehicleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vehicleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vehicleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vehicleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   </div>\r\n   <div class=\"col-8  text-center\">\r\n      <h2 class=\"page-title display-4\">");
#nullable restore
#line 9 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
                                  Write(ViewBag.VehicleNickName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
                                                           Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Upgrade</h2>\r\n   </div>\r\n   <div class=\"col-2 text-center\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9450ad3ae6066782aee61f76c548acb560197dfe8947", async() => {
                WriteLiteral("\r\n         Edit\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-upgradeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["upgradeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-upgradeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["upgradeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   </div>\r\n</div>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-6 text-right list-header\">\r\n      Upgrade:\r\n   </div>\r\n   <div class=\"col-6 text-left\">\r\n      ");
#nullable restore
#line 24 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
 Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-6 text-right list-header\">\r\n      Date Perfomed:\r\n   </div>\r\n   <div class=\"col-6 text-left\">\r\n      ");
#nullable restore
#line 33 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
 Write(Model.Date.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-6 text-right list-header\">\r\n      Location:\r\n   </div>\r\n   <div class=\"col-6 text-left\">\r\n      ");
#nullable restore
#line 42 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
 Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-6 text-right list-header\">\r\n      Cost:\r\n   </div>\r\n   <div class=\"col-6 text-left\">\r\n");
#nullable restore
#line 51 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
       if (Model.Cost != null)
      {
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
    Write(Model.Cost.Value.ToString("C"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
                                        
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-6 text-right list-header\">\r\n      Vehicle Mileage:\r\n   </div>\r\n   <div class=\"col-6 text-left\">\r\n      ");
#nullable restore
#line 63 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
 Write(Model.VehicleMileage.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-6 text-right list-header\">\r\n      Warranty Expiration:\r\n   </div>\r\n   <div class=\"col-6 text-left\">\r\n");
#nullable restore
#line 72 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
       if (Model.WarrantyExpiration != null)
      {
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
    Write(Model.WarrantyExpiration.Value.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
                                                                  
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-6 text-center\">\r\n      ");
#nullable restore
#line 81 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
 Write(Model.Photo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </div>\r\n   <div class=\"col-6 text-center\">\r\n      ");
#nullable restore
#line 84 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
 Write(Model.Receipt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </div>\r\n</div>\r\n<br />\r\n<br />\r\n\r\n<div class=\"row align-bottom\">\r\n   <div class=\"col-2 offset-10 text-center\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9450ad3ae6066782aee61f76c548acb560197dfe15822", async() => {
                WriteLiteral("\r\n         Delete\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-upgradeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\gabri\OneDrive\Desktop\Projects\MyGarage\MyGarage\MyGarage\Views\Upgrade\Details.cshtml"
                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["upgradeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-upgradeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["upgradeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Upgrade> Html { get; private set; }
    }
}
#pragma warning restore 1591
