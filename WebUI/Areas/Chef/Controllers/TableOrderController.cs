using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.Chef.Controllers
{
    [Area("Chef")]
    public class TableOrderController : Controller
    {
        private readonly IRepository<CustomerOrder> customerOrderRepository;
        private readonly IRepository<MenuProduct> menuRepository;
        public TableOrderController(IRepository<Table> _tableRepository, IRepository<CustomerOrder> _customerOrderRepository, IRepository<MenuProduct> _menuRepository)
        {
            customerOrderRepository = _customerOrderRepository;
            menuRepository = _menuRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Menu = menuRepository.GetAll();
            var orders = customerOrderRepository.GetAll();

            return View(orders);
        }
    }
}
