#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6318b228e51273d112b45c9aedfaee5a663ebb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Employee_UpdateEmployee), @"mvc.1.0.view", @"/Areas/Admin/Views/Employee/UpdateEmployee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6318b228e51273d112b45c9aedfaee5a663ebb4", @"/Areas/Admin/Views/Employee/UpdateEmployee.cshtml")]
    public class Areas_Admin_Views_Employee_UpdateEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Employee/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
  
    ViewData["Title"] = "UpdateEmployee";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"body-content\">\r\n\r\n\r\n    <div class=\"ms-panel-header\">\r\n        <h6> Personel Bilgilerini Düzenleme Formu</h6>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6318b228e51273d112b45c9aedfaee5a663ebb43862", async() => {
                WriteLiteral("Personel Listesi");
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
    <div class=""ms-panel-body"">
        <form asp-action=""UpdateEmployee"" method=""POST"">
            <div class=""form-row"">
                <div class=""col-md-12 mb-3"">
                    <label asp-for=""IdentityNo"">Kimlik Numarası</label>
                    ");
#nullable restore
#line 18 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.IdentityNo, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"FirstName\">Personel Adı</label>\r\n                    ");
#nullable restore
#line 22 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.FirstName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"LastName\">Personel Soyadı</label>\r\n                    ");
#nullable restore
#line 26 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.LastName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Title\">Görev</label>\r\n                    ");
#nullable restore
#line 30 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.DropDownListFor(x => x.Title, new List<SelectListItem>
                       {
                       new SelectListItem {Text=Model.Title},
                       new SelectListItem { Text=@DataAccess.Enum.Title.Aşçı.ToString() },
                       new SelectListItem { Text=@DataAccess.Enum.Title.Garson.ToString() },
                       new SelectListItem { Text=@DataAccess.Enum.Title.Depo_Görevlisi.ToString() }
                       },
                       new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"TitleOfCourtesy\">Cinsiyet</label>\r\n                    ");
#nullable restore
#line 41 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.DropDownListFor(x => x.TitleOfCourtesy, new List<SelectListItem>
                       {
                       new SelectListItem {Text=Model.Title},
                       new SelectListItem { Text=@DataAccess.Enum.TitleofCourtesy.Mrs.ToString() },
                       new SelectListItem { Text=@DataAccess.Enum.TitleofCourtesy.Mr.ToString() }
                       },
                       new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"BirthDate\">Doğum Tarihi</label>\r\n                    ");
#nullable restore
#line 51 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.BirthDate.Date   , new { @class = "form-control", type = "datetime" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                   \r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"HomePhone\">Telefon Numarası</label>\r\n                    ");
#nullable restore
#line 57 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.HomePhone, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Email\">Mail Adres</label>\r\n                    ");
#nullable restore
#line 61 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Adress\">Adres</label>\r\n                    ");
#nullable restore
#line 65 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.Adress, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Country\">Ülke</label>\r\n                    ");
#nullable restore
#line 69 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.Country, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"City\">Şehir</label>\r\n                    ");
#nullable restore
#line 73 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.City, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"PostalCode\">Posta Kodu</label>\r\n                    ");
#nullable restore
#line 77 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
               Write(Html.TextBoxFor(x => x.PostalCode, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"Picture\">Personel Fotoğrafı</label>\r\n                    <div class=\"custom-file\">\r\n");
#nullable restore
#line 82 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
                         if (Model.Photo == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input name=\"Picture\" type=\"file\" class=\"form-control\" />\r\n");
#nullable restore
#line 85 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
                       Write(Html.TextBoxFor(x => x.Photo, new { @class = "form-control", type = "file" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\UpdateEmployee.cshtml"
                                                                                                          
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <button class=\"btn btn-primary float-end\" type=\"submit\">Güncelle</button>\r\n\r\n            </div>\r\n        </form>\r\n\r\n    </div>\r\n\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Entity.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591