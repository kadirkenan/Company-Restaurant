using DataAccess.Entity;
using Microsoft.AspNetCore.Identity;
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
    public class HomeController : Controller
    {
        private readonly IRepository<MenuCategory> menuCategoryRepository;

        public HomeController(IRepository<MenuCategory> _menuCategoryRepository)
        {
            menuCategoryRepository = _menuCategoryRepository;
        }

        public IActionResult Index()
        {
            return View(menuCategoryRepository.GetAll());
        }
    }
}
