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
    public class StorageProductController : Controller
    {
        private readonly IRepository<StorageProduct> storageProductRepository;
        private readonly IRepository<StorageCategory> storageCategoryRepository;
        private readonly IRepository<Supplier> supplierRepository;
        public StorageProductController(IRepository<StorageProduct> _storageProductRepository, IRepository<StorageCategory> _storageCategoryRepository, IRepository<Supplier> _supplierRepository)
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
        public IActionResult AddStorageProduct()
        {
            ViewBag.Categories = new SelectList(storageCategoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Supplier = new SelectList(supplierRepository.GetAll(), "Id", "CompanyName");
            return View();
        }
        [HttpPost]
        public IActionResult AddStorageProduct(StorageProduct storageProduct)
        {
            storageProductRepository.Create(storageProduct);
            return RedirectToAction("Index");
        }
        public IActionResult GetStorageProduct(int id)
        {
            ViewBag.Categories = new SelectList(storageCategoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Supplier = new SelectList(supplierRepository.GetAll(), "Id", "CompanyName");
            try
            {
                if (storageProductRepository.GetById(id).Id == id)
                {
                    return View(storageProductRepository.GetById(id));
                }
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }
        public IActionResult UpdateStorageProduct(int id)
        {
            ViewBag.Categories = new SelectList(storageCategoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Supplier = new SelectList(supplierRepository.GetAll(), "Id", "CompanyName");
            return View(storageProductRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateStorageProduct(StorageProduct product)
        {
            storageProductRepository.Update(product);
            return RedirectToAction("Index");
        }
    }
}
