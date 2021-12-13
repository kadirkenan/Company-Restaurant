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
    public class OrderController : Controller
    {
        private readonly IRepository<Table> tableRepository;
        private readonly IRepository<Employee> employeeRepository;
        private readonly IRepository<MenuProduct> menuRepository;
        private readonly IRepository<MenuCategory> categoryRepository;
        private readonly IRepository<CustomerOrder> customerOrderRepository;
        public OrderController(IRepository<Table> _tableRepository, IRepository<MenuProduct> _menuRepository, IRepository<MenuCategory> _categoryRepository, IRepository<Employee> _employeeRepository, IRepository<CustomerOrder> _customerOrderRepository)
        {
            tableRepository = _tableRepository;
            menuRepository = _menuRepository;
            categoryRepository = _categoryRepository;
            employeeRepository = _employeeRepository;
            customerOrderRepository = _customerOrderRepository;
        }


        public IActionResult Index()
        {
            var orders = customerOrderRepository.GetAll();
            var category = categoryRepository.GetAll();
            var tems = new SelectList(category, "Id", "CategoryName");
            ViewBag.Menu = menuRepository.GetAll();
            ViewBag.Categories = tems;
            return View(orders);
        }
        public IActionResult AddOrder()
        {
            ViewBag.TableNo = new SelectList(tableRepository.GetAll(), "Id", "TableNo");
            ViewBag.Table = tableRepository.GetAll();
            return View(menuRepository.GetAll());
        }
        [HttpPost]
        public IActionResult AddOrder(List<String> menuId,List<Boolean> Siparis,int masaId)
        {
            CustomerOrder customerOrder = new CustomerOrder();
            Table selectedTable = tableRepository.GetById(masaId);
            for (int i=0; i<Siparis.Count;i++)
            {
                if (Siparis[i].Equals(true))
                {
                    customerOrder.TableNo = selectedTable.TableNo;
                    customerOrder.Price = menuRepository.GetById(Convert.ToInt32(menuId[i])).MenuPrice;
                    customerOrder.EmployeeId = selectedTable.EmployeeId;
                    customerOrder.MenuId = Convert.ToInt32( menuId[i]);
                    customerOrder.TableId = masaId;
                    customerOrderRepository.Create(customerOrder);
                }
            }
     


            return RedirectToAction("Index");
        }
        public IActionResult TableUpdate(int id)
        {
            ViewBag.Table = tableRepository.GetAll();
            ViewBag.Employee = new SelectList(employeeRepository.GetAll(), "Id", "Nickname");
            return View(customerOrderRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult TableUpdate(CustomerOrder customerOrder)
        {
            ViewBag.Menu = menuRepository.GetAll();
            customerOrderRepository.Update(customerOrder);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteOrder(int id)
        {
            return View(customerOrderRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeleteOrder(CustomerOrder customerOrder)
        {
            customerOrderRepository.Delete(customerOrder);
            return RedirectToAction("Index");
        }
        public IActionResult SendOrder(int id)
        {
            ViewBag.Menu = new SelectList(menuRepository.GetAll(), "Id", "MenuName");
            ViewBag.Category = new SelectList(categoryRepository.GetAll(), "Id", "CategoryName");
            ViewBag.Employee = new SelectList(employeeRepository.GetAll(), "Id", "Nickname");
            return View(tableRepository.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
