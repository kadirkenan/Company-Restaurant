using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Areas.WarehouseAttendant.Controllers
{
    [Area("WarehouseAttendant")]
    public class SupplierController : Controller
    {
        private readonly IRepository<Supplier> supplierRepository;

        public SupplierController(IRepository<Supplier> _supplierRepository)
        {
            supplierRepository = _supplierRepository;
        }
        public IActionResult Index()
        {
            return View(supplierRepository.GetAll());
        }
        public IActionResult AddSupplier()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSupplier(Supplier supplier)
        {
            supplierRepository.Create(supplier);
            return RedirectToAction("Index");
        }
        public IActionResult GetSupplier(int id)
        {
            try
            {
                if (supplierRepository.GetById(id).Id == id)
                {
                    return View(supplierRepository.GetById(id));
                }
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }
        public IActionResult UpdateSupplier(int id)
        {
            return View(supplierRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult UpdateSupplier(Supplier supplier)
        {
            supplierRepository.Update(supplier);
            return RedirectToAction("Index");
        }
    }
}
