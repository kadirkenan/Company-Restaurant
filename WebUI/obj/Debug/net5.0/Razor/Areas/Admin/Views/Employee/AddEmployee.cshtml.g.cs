#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\AddEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc7a0826c3897863844ff15dfc600d2edce14f3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Employee_AddEmployee), @"mvc.1.0.view", @"/Areas/Admin/Views/Employee/AddEmployee.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc7a0826c3897863844ff15dfc600d2edce14f3d", @"/Areas/Admin/Views/Employee/AddEmployee.cshtml")]
    public class Areas_Admin_Views_Employee_AddEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.Employee>
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\AddEmployee.cshtml"
  
    ViewData["Title"] = "AddEmployee";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"body-content\">\r\n\r\n    <div class=\"ms-panel-header\">\r\n        <h6> Personel Ekleme Formu</h6>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc7a0826c3897863844ff15dfc600d2edce14f3d3826", async() => {
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
        <form asp-action=""AddEmployee"" asp-controller=""Employee"" method=""POST"">
            <div class=""form-row"">
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Kimlik Numarası</label>
                    <input name=""IdentityNo"" type=""text"" class=""form-control"" placeholder=""Kimlik Numarasını giriniz..."" />

                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Personel Adı</label>
                    <input name=""FirstName"" type=""text"" class=""form-control"" placeholder=""Personel adını giriniz..."" />

                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Personel Soyadı</label>
                    <input name=""LastName"" type=""text"" class=""form-control"" placeholder=""Personel soyadını giriniz..."" />

                </div>
                <div class=""col-md-6 mb-3"">
  ");
            WriteLiteral("                  <label asp-for=\"Title\">Personel Görevi</label>\r\n                    <div class=\"input-group\">\r\n                        <select name=\"Title\" class=\"form-control\">\r\n                            <option>");
#nullable restore
#line 35 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\AddEmployee.cshtml"
                               Write(DataAccess.Enum.Title.Aşçı);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option>");
#nullable restore
#line 36 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\AddEmployee.cshtml"
                               Write(DataAccess.Enum.Title.Garson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option>");
#nullable restore
#line 37 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\AddEmployee.cshtml"
                               Write(DataAccess.Enum.Title.Depo_Görevlisi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                        </select>
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label asp-for=""TitleOfCourtesy"">Cinsiyet</label>
                    <div class=""input-group"">
                        <select name=""TitleofCourtesy"" class=""form-control"">
                            <option>");
#nullable restore
#line 45 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\AddEmployee.cshtml"
                               Write(DataAccess.Enum.TitleofCourtesy.Mrs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n                            <option>");
#nullable restore
#line 46 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\Employee\AddEmployee.cshtml"
                               Write(DataAccess.Enum.TitleofCourtesy.Mr);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</option>
                        </select>
                    </div>
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Kullanıcı Adı</label>
                    <input name=""NickName"" type=""text"" class=""form-control"" placeholder=""Kullanıcı adı giriniz..."" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Doğum Tarihi</label>
                    <input name=""BirthDate"" type=""datetime"" class=""form-control""  />

                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Telefon Numarası</label>
                    <input name=""HomePhone"" type=""text"" class=""form-control"" placeholder=""Telefon numarasını giriniz..."" />

                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Mail Adres</label>
                    <input name=""Emai");
            WriteLiteral(@"l"" type=""text"" class=""form-control"" placeholder=""Mail adresini giriniz..."" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Adress</label>
                    <input name=""Adress"" type=""text"" class=""form-control"" placeholder=""Adres giriniz..."" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Ülke</label>
                    <input name=""Country"" type=""text"" class=""form-control"" placeholder=""Yaşadığınız ülke adını giriniz..."" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Şehir</label>
                    <input name=""City"" type=""text"" class=""form-control"" placeholder=""Yaşadığınız şehir adını giriniz..."" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom18"">Posta Kodu</label>
                    <input name");
            WriteLiteral(@"=""PostalCode"" type=""text"" class=""form-control"" placeholder=""Posta kodunu giriniz..."" />
                </div>
                <div class=""col-md-12 mb-3"">
                    <label for=""validationCustom12"">Personel Fotoğrafı</label>
                    <div class=""custom-file"">
                        <input type=""file"" class=""custom-file-input"" id=""validatedCustomFile"">
                        <input name=""PhotoPath"" type=""file"" class=""form-control"" />
                    </div>
                </div>
                <button class=""btn btn-primary float-end"" type=""submit"">Kaydet</button>

            </div>
        </form>

    </div>

</main>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Entity.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
