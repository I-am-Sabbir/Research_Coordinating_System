#pragma checksum "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b1bd8217805a2d11432955e6f5c0917962899c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Views\_ViewImports.cshtml"
using Research_Coordinating_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Views\_ViewImports.cshtml"
using Research_Coordinating_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b1bd8217805a2d11432955e6f5c0917962899c9", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dcd0991f14246cd7c21814b71c98a85eacbefa3", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Research_Coordinating_System.Models.FacultyDashboardModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_FacultyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""content-wrapper"">
    <section class=""col-lg-5 connectedSortable"">
        <div class=""card bg-gradient-success"">
            <div class=""card-header border-0"">

                <h3 class=""card-title"">
                    <i class=""far fa-calendar-alt""> Calendar </i>

                </h3>
                <!-- tools card -->
                <div class=""card-tools"">
                    <!-- button with a dropdown -->

                    <button type=""button"" class=""btn btn-success btn-sm"" data-card-widget=""collapse"">
                        <i class=""fas fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-success btn-sm"" data-card-widget=""remove"">
                        <i class=""fas fa-times""></i>
                    </button>
                </div>
                <!-- /. tools -->
            </div>
            <!-- /.card-header -->
            <div class=""card-body pt-0"">
                <!--The calendar -->
   ");
            WriteLiteral(@"             <div id=""calendar"" style=""width: 100%""></div>
            </div>
            <!-- /.card-body -->
        </div>

        <div class=""card bg-gradient-primary"">
            <div class=""card-footer bg-transparent"">
                <div class=""row"">
                    <div class=""col-4 text-center"">
                        <div id=""sparkline-1""></div>
                        <div class=""text-white"">visitors</div>
                    </div>

                    <div class=""col-4 text-center"">
                        <div id=""sparkline-2""></div>
                        <div class=""text-white"">online</div>
                    </div>

                    <div class=""col-4 text-center"">
                        <div id=""sparkline-3""></div>
                        <div class=""text-white"">sales</div>
                    </div>
                </div>
            </div>
        </div>
    </section>      
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Research_Coordinating_System.Models.FacultyDashboardModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
