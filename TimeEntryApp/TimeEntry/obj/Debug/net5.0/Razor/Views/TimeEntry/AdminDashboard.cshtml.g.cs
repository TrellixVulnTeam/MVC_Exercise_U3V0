#pragma checksum "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796b4319e379fa1be48837549d601bce74bc6bac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TimeEntry_AdminDashboard), @"mvc.1.0.view", @"/Views/TimeEntry/AdminDashboard.cshtml")]
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
#line 1 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\_ViewImports.cshtml"
using TimeEntry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\_ViewImports.cshtml"
using TimeEntry.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796b4319e379fa1be48837549d601bce74bc6bac", @"/Views/TimeEntry/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f469405d4c649f6ced14ec0fbf10e87ed1d70a65", @"/Views/_ViewImports.cshtml")]
    public class Views_TimeEntry_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessObjectLayer.Models.TimeEntry>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
  
    ViewData["Title"] = "AdminDashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

     <div class=""row"">
        <div class=""col-12"">
            <table class=""table table-bordered table-striped"" style=""width: 100%"">
                <thead>
                    <tr>
                        <th> Employee Id </th>
                        <th> Date </th>
                        <th>  In Time </th>
                        <th> Out Time  </th>
                        <th> Total working time </th>
                        <th> Total break time </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                     foreach (var entry in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td> ");
#nullable restore
#line 26 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                            Write(ViewBag.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 27 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                            Write(entry.Date.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 28 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                            Write(entry.InTime.ToString("hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 29 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                            Write(entry.OutTime.ToString("hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 30 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                            Write(entry.OutTime.Subtract(entry.InTime).TotalHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 32 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                                 foreach (var b in @entry.Breaks)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                               Write(b.BreakOut.Subtract(b.BreakIn).TotalHours);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                                                                              
                                }                              

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\srividhyav\source\repos\TimeEntryApp\TimeEntry\Views\TimeEntry\AdminDashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessObjectLayer.Models.TimeEntry>> Html { get; private set; }
    }
}
#pragma warning restore 1591
