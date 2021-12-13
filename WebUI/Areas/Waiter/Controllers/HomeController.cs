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
    public class HomeController : Controller
    {
        private readonly IRepository<MenuProduct> menuRepository;
        private readonly IRepository<MenuCategory> categoryRepository;
        public HomeController(IRepository<MenuProduct> _menuRepository, IRepository<MenuCategory> _categoryRepository)
        {
            menuRepository = _menuRepository;
            categoryRepository = _categoryRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            return View(menuRepository.GetAll());
        }
    }
}
