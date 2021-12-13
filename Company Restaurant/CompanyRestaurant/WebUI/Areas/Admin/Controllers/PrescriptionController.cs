using DataAccess.Entity;
using DataAccess.Enum;
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
    public class PrescriptionController : Controller
    {
        private readonly IRepository<Prescription> prescriptionRepository;
        private readonly IRepository<MenuProduct> menuProductRepository;
        private readonly IRepository<StorageProduct> storageProductRepository;
        private readonly IRepository<Gauge> gaugeRepository;
        
        public PrescriptionController(IRepository<Prescription> _prescriptionRepository, IRepository<MenuProduct> _menuProductRepository, IRepository<StorageProduct> _storageProductRepository, IRepository<Gauge> _gaugeRepository)
        {
            prescriptionRepository = _prescriptionRepository;
            menuProductRepository = _menuProductRepository;
            storageProductRepository = _storageProductRepository;
            gaugeRepository = _gaugeRepository;
           
        }
        public IActionResult Index()
        {
            ViewBag.MenuProduct = new SelectList(menuProductRepository.GetAll(), "Id", "MenuName");
            ViewBag.StorageProduct = new SelectList(storageProductRepository.GetAll(), "Id", "StorageProductName");
            ViewBag.Gauge = new SelectList(gaugeRepository.GetAll(), "Id", "GaugeName");

            var model = prescriptionRepository.GetAll();
            
            return View(model);
        }
        public IActionResult AddPrescription()
        {

            ViewBag.MenuProduct = new SelectList(menuProductRepository.GetAll(), "Id", "MenuName");
            ViewBag.StorageProduct = new SelectList(storageProductRepository.GetAll(), "Id", "StorageProductName");
            ViewBag.Gauge = new SelectList(gaugeRepository.GetAll(), "Id", "GaugeName");
            return View();
        }
        [HttpPost]
        public IActionResult AddPrescription(Prescription prescription)
        {
            prescriptionRepository.Create(prescription);
            return RedirectToAction("Index");
        }
        public IActionResult GetPrescription(int id)
        {
            ViewBag.MenuProduct = new SelectList(menuProductRepository.GetAll(), "Id", "MenuName");
            ViewBag.StorageProduct = new SelectList(storageProductRepository.GetAll(), "Id", "StorageProductName");
            ViewBag.Gauge = new SelectList(gaugeRepository.GetAll(), "Id", "GaugeName");
            try
            {
                if (prescriptionRepository.GetById(id).Id == id)
                {
                    return View(prescriptionRepository.GetById(id));
                }
                return View();
            }
            catch (Exception ex)
            {

                return View(ex.Message);
            }
        }
        public IActionResult UpdatePrescription(int id)
        {
            var model = prescriptionRepository.Where(x => x.Id == id).FirstOrDefault();

            ViewBag.MenuProduct = new SelectList(menuProductRepository.GetAll(), "Id", "MenuName", model.MenuProductId);
            ViewBag.StorageProduct = new SelectList(storageProductRepository.GetAll(), "Id", "StorageProductName",model.StorageProductId);
            ViewBag.Gauge = new SelectList(gaugeRepository.GetAll(), "Id", "GaugeName",model.GaugeId);
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdatePrescription(Prescription prescription)
        {
            prescriptionRepository.Update(prescription);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePrescription(int id)
        {
            ViewBag.MenuProduct = new SelectList(menuProductRepository.GetAll(), "Id", "MenuName");
            ViewBag.StorageProduct = new SelectList(storageProductRepository.GetAll(), "Id", "StorageProductName");
            ViewBag.Gauge = new SelectList(gaugeRepository.GetAll(), "Id", "GaugeName");
            return View(prescriptionRepository.Where(x => x.Id == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult DeletePrescription(Prescription prescription)
        {
            prescriptionRepository.Delete(prescription);
            return RedirectToAction("Index");
        }

    }
}
