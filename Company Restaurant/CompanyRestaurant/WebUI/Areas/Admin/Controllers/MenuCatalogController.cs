using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuCatalogController : Controller
    {
        private readonly IRepository<MenuCategory> menuCategoryRepository;
        private readonly IRepository<MenuProduct> menuProductRepository;

        public MenuCatalogController(IRepository<MenuCategory> _menuCategoryRepository, IRepository<MenuProduct> _menuProductRepository)
        {
            menuCategoryRepository = _menuCategoryRepository;
            menuProductRepository = _menuProductRepository;
        }

        public IActionResult Index()
        {
           
            return View(menuCategoryRepository.GetAll());
        }
        public IActionResult AddMenuCatalog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMenuCatalog(MenuCategory category)
        {
            menuCategoryRepository.Create(category);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateMenuCatalog(int id)
        {

            return View(menuCategoryRepository.Where(x=> x.Id==id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateMenuCatalog(MenuCategory category)
        {
            menuCategoryRepository.Update(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMenuCatalog(int id)
        {
            return View(menuCategoryRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeleteMenuCatalog(MenuCategory category)
        {
            
            menuCategoryRepository.Delete(category);
            return RedirectToAction("Index");
        }
        public IActionResult GetMenu(int id)
        {
            
            try
            {
                if (menuCategoryRepository.GetById(id).Id == id)
                {
                    return View(menuProductRepository.GetAll());
                }
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }
        
    }
}
