using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StorageCategoryController : Controller
    {
        private readonly IRepository<StorageCategory> storageCategoryRepository;

        public StorageCategoryController(IRepository<StorageCategory> _storageCategoryRepository)
        {
            storageCategoryRepository = _storageCategoryRepository;
        }
        public IActionResult Index()
        {
            return View(storageCategoryRepository.GetAll());
        }
        public IActionResult AddStorageCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStorageCategory(StorageCategory category)
        {
            storageCategoryRepository.Create(category);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteStorageCategory(int id)
        {
            return View(storageCategoryRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeleteStorageCategory(StorageCategory category)
        {
            storageCategoryRepository.Delete(category);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateStorageCategory(int id)
        {
            return View(storageCategoryRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateStorageCategory(StorageCategory category)
        {
            storageCategoryRepository.Update(category);
            return RedirectToAction("Index");
        }
    }
}
