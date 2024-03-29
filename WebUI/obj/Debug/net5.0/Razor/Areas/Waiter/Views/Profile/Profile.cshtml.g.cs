#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca1c9787faa00208016c045506b7d44493ffadfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Waiter_Views_Profile_Profile), @"mvc.1.0.view", @"/Areas/Waiter/Views/Profile/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca1c9787faa00208016c045506b7d44493ffadfb", @"/Areas/Waiter/Views/Profile/Profile.cshtml")]
    public class Areas_Waiter_Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Waiter/Profile/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Areas/Waiter/Views/Shared/_WaiterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
 if (Model.Nickname.ToLower() == User.Identity.Name.ToLower())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <main class=""body-content"">
        <div class=""ms-panel-header"">

        </div>
        <div class=""ms-panel-body"">
            <div class=""card"">
                <form asp-action=""Profile"" method=""POST"">

                    <div class=""form-row"">
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""PhotoPath""><strong>  FOTOĞRAF :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 23 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.PhotoPath));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""IdentityNo""><strong>  KİMLİK NUMARASI :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 31 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.IdentityNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""FirstName""><strong>  PERSONEL ADI :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 39 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""LastName""><strong>  PERSONEL SOYADI :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 47 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>


                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""TitleOfCourtesy""><strong>  Cinsiyet :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 57 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.TitleOfCourtesy));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""BirthDate""><strong>  DOĞUM TARİHİ :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 65 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""HomePhone""><strong>  TELEFON NUMARASI :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 73 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.HomePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""Email""><strong>  MAİL ADRESİ :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 81 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3 "">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""Adress""><strong>  ADRES :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 89 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""Country""><strong>  ÜLKE :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 97 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""City""><strong>  ŞEHİR :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 105 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.City));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-12 mb-3"">
                            <div class=""col-md-12 mb-2"">
                                <label asp-for=""PostalCode""><strong>  POSTA KODU :</strong></label>
                            </div>
                            <div class=""col-md-12 mb-2"">
                                ");
#nullable restore
#line 113 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
                           Write(Html.ValueFor(x => x.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"col-md-12 mb-1\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca1c9787faa00208016c045506b7d44493ffadfb12604", async() => {
                WriteLiteral("Düzenle");
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
            WriteLiteral("\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </main>\r\n");
#nullable restore
#line 129 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Waiter\Views\Profile\Profile.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
