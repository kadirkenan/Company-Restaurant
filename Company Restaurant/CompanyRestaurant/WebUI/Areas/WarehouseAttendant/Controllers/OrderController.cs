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
    public class OrderController : Controller
    {
        private readonly IRepository<StorageCategory> categoryRepository;
        private readonly IRepository<StorageProduct> productRepository;
        private readonly IRepository<Supplier> supplierRepository;
        public OrderController(IRepository<StorageCategory> _categoryRepository, IRepository<StorageProduct> _productRepository, IRepository<Supplier> _supplierRepository)
        {
            categoryRepository = _categoryRepository;
            productRepository = _productRepository;
            supplierRepository = _supplierRepository;
        }


        public IActionResult Index()
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Supplier = new SelectList(supplierRepository.GetAll(), "Id", "CompanyName");
            return View(productRepository.GetAll());
        }
        public IActionResult GetOrder(int id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Supplier = new SelectList(supplierRepository.GetAll(), "Id", "CompanyName");
            return View(productRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult GetOrder(StorageProduct storageProduct)
        {
            productRepository.Update(storageProduct);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateStorageProduct(int id, int orderUnit)
        {
           
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Supplier = new SelectList(supplierRepository.GetAll(), "Id", "CompanyName");
            return View(productRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateStorageProduct(StorageProduct product, int orderUnit)
        {

            StorageProduct update = productRepository.GetById(product.Id);
            update.UnitsOnOrder = orderUnit;
            productRepository.Update(update);
            return RedirectToAction("Index");
        }
    }
}
