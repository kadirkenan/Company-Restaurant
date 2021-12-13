using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Chef.Controllers
{
    [Area("Chef")]
    public class StorageProductController : Controller
    {
        private readonly IRepository<StorageProduct> storageProductRepository;
        private readonly IRepository<StorageCategory> storageCategoryRepository;
        public StorageProductController(IRepository<StorageCategory> _storageCategoryRepository, IRepository<StorageProduct> _storageProductRepository)
        {
            storageCategoryRepository = _storageCategoryRepository;
            storageProductRepository = _storageProductRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Categories = new SelectList(storageCategoryRepository.GetAll(), "Id", "CategoryName");
            return View(storageProductRepository.GetAll());
        }
    }
}
