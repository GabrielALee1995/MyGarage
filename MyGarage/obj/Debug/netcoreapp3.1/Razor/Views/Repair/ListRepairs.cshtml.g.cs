#pragma checksum "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be50ee2f8784b60cbc1501bdca736eb150d3287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repair_ListRepairs), @"mvc.1.0.view", @"/Views/Repair/ListRepairs.cshtml")]
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
#line 1 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\_ViewImports.cshtml"
using MyGarage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\_ViewImports.cshtml"
using MyGarage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be50ee2f8784b60cbc1501bdca736eb150d3287", @"/Views/Repair/ListRepairs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ebbb07844b7848dd346e5f52977ba6002e3243", @"/Views/_ViewImports.cshtml")]
    public class Views_Repair_ListRepairs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Repair>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Repair", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-add btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row\">\r\n   <div class=\"col-2 text-center\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be50ee2f8784b60cbc1501bdca736eb150d32875718", async() => {
                WriteLiteral("\r\n         ");
#nullable restore
#line 6 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
    Write(ViewBag.VehicleNickName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      ");
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
#line 5 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
                                                                WriteLiteral(ViewBag.VehicleId);

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
            WriteLiteral("\r\n   </div>\r\n   <div class=\"col-8 text-center\">\r\n      <h2 class=\"page-title display-4\">");
#nullable restore
#line 10 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
                                  Write(ViewBag.VehicleNickName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Repairs</h2>\r\n   </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-4 offset-2 text-right green-text\">\r\n\r\n      Total Cost of Repairs:\r\n   </div>\r\n   <div class=\"col-4 text-left\">\r\n      ");
#nullable restore
#line 20 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
 Write(ViewBag.TotalRepairCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
   </div>
</div>
<hr />

<div class=""row"">
   <div class=""col-2 offset-1 text-center list-header"">
      Repair
   </div>
   <div class=""col-2 text-center list-header"">
      Date
   </div>
   <div class=""col-2 text-center list-header"">
      Mileage
   </div>
   <div class=""col-2 text-center list-header"">
      Cost
   </div>
</div>
<br />


");
#nullable restore
#line 42 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
 foreach (Repair r in Model.OrderByDescending(r => r.Date).ThenBy(r => r.VehicleMileage))
{
      float total = 0;
      total += r.LaborCost.Value;
      total += r.PartsCost.Value;


#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"row\">\r\n      <div class=\"col-2 offset-1 my-auto\">\r\n         ");
#nullable restore
#line 50 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
    Write(r.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </div>\r\n      <div class=\"col-2 text-center my-auto\">\r\n         ");
#nullable restore
#line 53 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
    Write(r.Date.ToString("MM/dd/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </div>\r\n      <div class=\"col-2 text-center my-auto\">\r\n         ");
#nullable restore
#line 56 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
    Write(r.VehicleMileage.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </div>\r\n      <div class=\"col-2 text-center my-auto\">\r\n            ");
#nullable restore
#line 59 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
       Write(total.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      </div>\r\n      <div class=\"col-2 text-center my-auto\">\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be50ee2f8784b60cbc1501bdca736eb150d328711585", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-repairId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
                                                                                 WriteLiteral(r.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["repairId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-repairId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["repairId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n   </div>\r\n   <div class=\"row\">\r\n      <div class=\"col\">\r\n         <hr />\r\n      </div>\r\n   </div>\r\n");
#nullable restore
#line 70 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"row\">\r\n   <div class=\"col-12 text-center\">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8be50ee2f8784b60cbc1501bdca736eb150d328714557", async() => {
                WriteLiteral("\r\n         Add Repair\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vehicleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\gabri\OneDrive\Desktop\Coding\Projects\MyGarage\MyGarage\MyGarage\Views\Repair\ListRepairs.cshtml"
                                                                               WriteLiteral(ViewBag.VehicleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vehicleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vehicleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vehicleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Repair>> Html { get; private set; }
    }
}
#pragma warning restore 1591
