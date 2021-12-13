using DataAccess.Entity;
using Microsoft.AspNetCore.Identity;
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
    public class OrderController : Controller
    {
        private readonly IRepository<CustomerOrder> customerOrderRepository;
        private readonly IRepository<Table> tableRepository;
        private readonly UserManager<AppUser> appUserRepository;
        private readonly IRepository<Employee> employeeRepository;
        private readonly IRepository<MenuProduct> menuRepository;
        public OrderController(IRepository<CustomerOrder> _customerOrderRepository, IRepository<Table> _tableRepository, UserManager<AppUser> _appUserRepository, IRepository<Employee> _employeeRepository, IRepository<MenuProduct> _menuRepository)
        {
            customerOrderRepository = _customerOrderRepository;
            tableRepository = _tableRepository;
            appUserRepository = _appUserRepository;
            employeeRepository = _employeeRepository;
            menuRepository = _menuRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Menu = menuRepository.GetAll();
            ViewBag.TableNo = tableRepository.GetAll();
            ViewBag.Employee = employeeRepository.GetAll();

            return View(customerOrderRepository.GetAll());
        }       
        public IActionResult GetOrder(int id)
        {
            ViewBag.TableNo = new SelectList(tableRepository.GetAll(), "Id", "TableNo");
            ViewBag.Employee = employeeRepository.GetAll();
            ViewBag.Order = customerOrderRepository.GetAll();
            ViewBag.Menu = menuRepository.GetAll();
            try
            {
                if (customerOrderRepository.GetById(id).Id == id)
                {
                    return View(customerOrderRepository.GetById(id));
                }
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }
        public IActionResult UpdateOrder(int id)
        {
            ViewBag.TableNo = new SelectList(tableRepository.GetAll(), "Id", "TableNo");
            ViewBag.Employee = new SelectList(employeeRepository.GetAll(), "Id", "Nickname");
            return View(customerOrderRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateOrder(CustomerOrder order)
        {
            customerOrderRepository.Update(order);
            return RedirectToAction("Index");
        }
    }
}
