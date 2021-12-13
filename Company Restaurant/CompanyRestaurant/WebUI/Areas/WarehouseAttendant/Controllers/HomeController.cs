using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.WarehouseAttendant.Controllers
{
    [Area("WarehouseAttendant")]
    public class HomeController : Controller
    {
        private readonly IRepository<StorageProduct> storageProductRepository;
        private readonly IRepository<StorageCategory> storageCategoryRepository;
        private readonly IRepository<Supplier> supplierRepository;
        public HomeController(IRepository<StorageProduct> _storageProductRepository, IRepository<StorageCategory> _storageCategoryRepository, IRepository<Supplier> _supplierRepository)
        {
            storageProductRepository = _storageProductRepository;
            storageCategoryRepository = _storageCategoryRepository;
            supplierRepository = _supplierRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Categories = new SelectList(storageCategoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Supplier = new SelectList(supplierRepository.GetAll(), "Id", "CompanyName");
            return View(storageProductRepository.GetAll());
        }
    }
}
