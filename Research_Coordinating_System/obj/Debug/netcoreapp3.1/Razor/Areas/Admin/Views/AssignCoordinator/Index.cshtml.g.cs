#pragma checksum "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Areas\Admin\Views\AssignCoordinator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd024efcb26fdff3428d6a57673575158098a19b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AssignCoordinator_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AssignCoordinator/Index.cshtml")]
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
#line 1 "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Areas\Admin\Views\_ViewImports.cshtml"
using Research_Coordinating_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Areas\Admin\Views\_ViewImports.cshtml"
using Research_Coordinating_System.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd024efcb26fdff3428d6a57673575158098a19b", @"/Areas/Admin/Views/AssignCoordinator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c6a178499b4acfb8f7536c51862a00aecab6fe", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AssignCoordinator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Research_Coordinating_System.Areas.Admin.Models.AssignCoordinator.AssignModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ActionMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Areas\Admin\Views\AssignCoordinator\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("PageStyles", async() => {
                WriteLiteral("\r\n    <!-- DataTables -->\r\n    <link rel=\"stylesheet\" href=\"/admin/plugins/datatables-bs4/css/dataTables.bootstrap4.css\">\r\n");
            }
            );
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>DataTables</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">DataTables</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">DataTable with default features</h3>
                    </div>
                    <!-- /.ca");
            WriteLiteral("rd-header -->\r\n                    <div class=\"card-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bd024efcb26fdff3428d6a57673575158098a19b5491", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 42 "G:\Projects\Research_Coordinating_System\Research_Coordinating_System\Areas\Admin\Views\AssignCoordinator\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Response;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <table id=\"AssignCo\" class=\"table table-bordered table-striped\">\r\n                            <thead>\r\n                                <tr>\r\n                                    <th>Email</th>\r\n");
            WriteLiteral(@"
                                    <th>Action</th>

                                </tr>
                            </thead>
                            <tfoot>
                                <tr>
                                    <th>Email</th>
");
            WriteLiteral(@"
                                    <th>Action</th>

                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </section>
    <!-- /.content -->
</div>

");
            DefineSection("PageScripts", async() => {
                WriteLiteral(@"
    <!-- DataTables -->
    <script src=""/admin/plugins/datatables/jquery.dataTables.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.js""></script>
    <!-- page script -->
    <script>
        $(function () {
            $('#AssignCo').DataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""ajax"": ""/Admin/AssignCoordinator/GetUsers"",
                ""columnDefs"": [
                    {
                        ""orderable"": false,
                        ""targets"": 1,
                        ""render"": function (data, type, row) {
                            return `<button type=""submit"" class=""btn btn-info btn-sm"" onclick=""window.location.href='/admin/AssignCoordinator/EditRole/${data}'"" value='${data}'>
                                        <i class=""fas fa-pencil-alt"">
                                        </i>
                                        Edit
                                    </button>
");
                WriteLiteral(@"                                    <button type=""submit"" class=""btn btn-danger btn-sm show-bs-modal"" href=""#"" data-id='${data}' value='${data}'>
                                        <i class=""fas fa-trash"">
                                        </i>
                                        Delete
                                    </button>`;
                        }
                    }
                ]
            });

            $('#AssignCo').on('click', '.show-bs-modal', function (event) {
                var id = $(this).data(""id"");
                var modal = $(""#modal-default"");
                modal.find('.modal-body p').text('Are you sure you want to delete this record?')
                //$(""#deleteForm"").attr(""action"", ""/admin/category/delete/"" + id );
                $(""#deleteId"").val(id);
                modal.modal('show');
            });

            $(""#deleteButton"").click(function () {
                $(""#deleteForm"").submit();
            });
        });
");
                WriteLiteral("    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Research_Coordinating_System.Areas.Admin.Models.AssignCoordinator.AssignModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
