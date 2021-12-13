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
    public class TableController : Controller
    {
        private readonly IRepository<Table> tableRepository;
        private readonly IRepository<Employee> employeeRepository;
        private readonly IRepository<CustomerOrder> customerOrderRepository;
        public TableController(IRepository<Table> _tableRepository, IRepository<Employee> _employeeRepository, IRepository<CustomerOrder> _customerOrderRepository)
        {
            tableRepository = _tableRepository;
            employeeRepository = _employeeRepository;
            customerOrderRepository = _customerOrderRepository;
        }

        public IActionResult Index()
        {
            return View(tableRepository.GetAll());
        }
        public IActionResult AddTable()
        {
            ViewBag.Employee = new SelectList(employeeRepository.GetAll(), "Id", "Nickname");
            return View();
        } 
        [HttpPost]
        public IActionResult AddTable(Table table)
        {
            tableRepository.Create(table);
            /*
            var deletePersonel = employeeRepository.Where(q => q.FirstName == null);

            if (deletePersonel != null)
            {
                foreach (var item in deletePersonel)
                {
                    employeeRepository.Delete(item);
                }
            }
            */
            return RedirectToAction("Index");
        }
        public IActionResult PayTable(int id)
        {
            var table = tableRepository.Where(x => x.Id == id).FirstOrDefault();

            if (table != null)
            {
                table.CloseDate = DateTime.Now;
                tableRepository.Update(table);
            }

            ViewBag.Employee = new SelectList(employeeRepository.GetAll(), "Id", "Nickname");
            return View(table);
        }
        [HttpPost]
        public IActionResult PayTable(Table table)
        {
            tableRepository.Update(table);
            return RedirectToAction("Index");
        }
    }
}
