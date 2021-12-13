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
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> employeeRepository;

        public EmployeeController(IRepository<Employee> _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }
        public IActionResult Index()
        {
            return View(employeeRepository.GetAll());
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employeeRepository.Create(employee);
            return RedirectToAction("Index");
        }
        public IActionResult GetEmployee(int id)
        {
            try
            {
                if (employeeRepository.GetById(id).Id == id)
                {
                    return View(employeeRepository.GetById(id));
                }
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }
        public IActionResult DeleteEmployee(int id)
        {
            return View(employeeRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeleteEmployee(Employee employee)
        {
            employeeRepository.Delete(employee);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateEmployee(int id)
        {
            var result = employeeRepository.Where(x => x.Id == id).FirstOrDefault();

            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            employeeRepository.Update(employee);
            return RedirectToAction("Index");
        }
    }
}
