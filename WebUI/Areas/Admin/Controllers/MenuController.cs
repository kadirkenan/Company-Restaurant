using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Interface;
using System;
using System.Linq;


namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly IRepository<MenuProduct> menuRepository;
        private readonly IRepository<MenuCategory> categoryRepository;
        public MenuController(IRepository<MenuProduct> _menuRepository, IRepository<MenuCategory> _categoryRepository)
        {
            menuRepository = _menuRepository;
            categoryRepository = _categoryRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            return View(menuRepository.GetAll());
        }
        public IActionResult AddMenuProduct()
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult AddMenuProduct(MenuProduct menuproduct, IFormFile fileUpload)
        {
            
            menuRepository.Create(menuproduct);
            return RedirectToAction("Index");
        }
        
        public IActionResult GetMenuProduct(int id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            try
            {
                if (menuRepository.GetById(id).Id == id)
                {
                    return View(menuRepository.GetById(id));
                }
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }
        public IActionResult UpdateMenuProduct(int id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            return View(menuRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateMenuProduct(MenuProduct menuproduct)
        {
            menuRepository.Update(menuproduct);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMenuProduct(int id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            return View(menuRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeleteMenuProduct(MenuProduct menuproduct)
        {
            menuRepository.Delete(menuproduct);
            return RedirectToAction("Index");
        }

    }
}
