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
    public class InvoiceController : Controller
    {
        private readonly IRepository<CustomerOrder> customerOrderRepository;
        private readonly IRepository<Table> tableRepository;
        private readonly UserManager<AppUser> appUserRepository;

        public InvoiceController(IRepository<CustomerOrder> _customerOrderRepository, IRepository<Table> _tableRepository, UserManager<AppUser> _appUserRepository)
        {
            customerOrderRepository = _customerOrderRepository;
            tableRepository = _tableRepository;
            appUserRepository = _appUserRepository;
        }

        public IActionResult Index()
        {
            ViewBag.TableNo = new SelectList(tableRepository.GetAll(), "Id", "CloseDate");
            ViewBag.Customer = new SelectList(customerOrderRepository.GetAll(), "Id", "EmployeeId");
            return View(customerOrderRepository.GetAll());
        }
        public IActionResult GetInvoice(int id)
        {
            ViewBag.TableNo = new SelectList(tableRepository.GetAll(), "Id", "TableNo");
            ViewBag.Customer = new SelectList(customerOrderRepository.GetAll(), "Id", "EmployeeId");
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
        public IActionResult UpdateInvoice(int id)
        {
            ViewBag.TableNo = new SelectList(tableRepository.GetAll(), "Id", "TableNo");
            ViewBag.Customer = new SelectList(customerOrderRepository.GetAll(), "Id", "EmployeeId");
            return View(customerOrderRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateInvoice(CustomerOrder customerOrder)
        {
            customerOrderRepository.Update(customerOrder);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteInvoice(int id)
        {
            ViewBag.TableNo = new SelectList(tableRepository.GetAll(), "Id", "TableNo");
            ViewBag.Customer = new SelectList(customerOrderRepository.GetAll(), "Id", "EmployeeId");
            return View(customerOrderRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeleteInvoice(CustomerOrder customerOrder)
        {
            customerOrderRepository.Delete(customerOrder);
            return RedirectToAction("Index");
        }
    }
}
