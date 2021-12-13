using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Waiter.Controllers
{
    [Area("Waiter")]
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
            var category = categoryRepository.GetAll();
            ViewBag.Categories = new SelectList(category, "Id", "CategoryName");
            return View(menuRepository.GetAll());
        }
    }
}
