#pragma checksum "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30a91ed72871bb1bc10a84daccf4bdedabef3224"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_StorageProduct_UpdateStorageProduct), @"mvc.1.0.view", @"/Areas/Admin/Views/StorageProduct/UpdateStorageProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a91ed72871bb1bc10a84daccf4bdedabef3224", @"/Areas/Admin/Views/StorageProduct/UpdateStorageProduct.cshtml")]
    public class Areas_Admin_Views_StorageProduct_UpdateStorageProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Entity.StorageProduct>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/StorageProduct/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
  
    ViewData["Title"] = "UpdateStorageProduct";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"body-content\">\r\n\r\n    <div class=\"ms-panel-header\">\r\n        <h6> Depo Ürün Düzenleme Formu</h6>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30a91ed72871bb1bc10a84daccf4bdedabef32243941", async() => {
                WriteLiteral("Depo Ürünler Listesi");
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
        <form asp-action=""UpdateStorageProduct"" method=""POST"">
            <div class=""form-row"">
                <div class=""col-md-12 mb-3"">
                    <label asp-for=""StorageProductName"">Ürün Adı</label>
                    ");
#nullable restore
#line 18 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
               Write(Html.TextBoxFor(x => x.StorageProductName, new { @class = "form-control", type = "text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"UnitPrice\">Fiyat</label>\r\n                    ");
#nullable restore
#line 22 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
               Write(Html.TextBoxFor(x => x.UnitPrice, new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"UnitsInStock\">Stok</label>\r\n                    ");
#nullable restore
#line 26 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
               Write(Html.TextBoxFor(x => x.UnitsInStock, new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"QuantityPerUnit\">Birim</label>\r\n                    ");
#nullable restore
#line 30 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
               Write(Html.DropDownListFor(x => x.QuantityPerUnit, new List<SelectListItem>
                        {
                        new SelectListItem {Text=Model.QuantityPerUnit},
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Kilogram.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Gram.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Litre.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Fıçı.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Şişe.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Paket.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Kutu.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Teneke.ToString() },
                        new SelectListItem { Text=@DataAccess.Enum.QuantityPerUnit.Kasa.ToString() }
                        },
                        new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label asp-for=\"StorageCategoryId\">Kategori Seçiniz</label>\r\n                    <div class=\"input-group\">\r\n                        ");
#nullable restore
#line 48 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
                   Write(Html.DropDownListFor(x => x.StorageCategoryId, (SelectList)ViewBag.Categories, new { @class = " form-control m-bot15" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <label asp-for=\"SupplierId\">Tedarikçi Seçiniz</label>\r\n                    <div class=\"input-group\">\r\n                        ");
#nullable restore
#line 54 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
                   Write(Html.DropDownListFor(x => x.SupplierId, (SelectList)ViewBag.Supplier, new { @class = " form-control m-bot15" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-12 mb-3\">\r\n                    <label asp-for=\"ProductImagePath\">Ürün Görseli</label>\r\n                    <div class=\"custom-file\">\r\n");
#nullable restore
#line 60 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
                         if (Model.ProductImagePath == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input name=\"ProductImagePath\" type=\"file\" class=\"form-control\" />\r\n");
#nullable restore
#line 63 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
                       Write(Html.TextBoxFor(x => x.ProductImagePath, new { @class = "form-control", type = "file" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\Kadir\Company Restaurant\CompanyRestaurant\WebUI\Areas\Admin\Views\StorageProduct\UpdateStorageProduct.cshtml"
                                                                                                                     
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <button class=\"btn btn-primary float-end\" type=\"submit\">Güncelle</button>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Entity.StorageProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
