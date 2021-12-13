using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
    public class ProfileController : Controller
    {
        private readonly IRepository<Employee> employeeRepository;
        private readonly SignInManager<AppUser> signInManager;

        public ProfileController(SignInManager<AppUser> _signInManager, IRepository<Employee> _employeeRepository)
        {
            signInManager = _signInManager;
            employeeRepository = _employeeRepository;
        }
        public IActionResult Profile(String Name)
        {
            ViewBag.PhotoPath = new SelectList(employeeRepository.GetAll(), "Id", "Email");


            if (signInManager.IsSignedIn(User))
            {

                return View(employeeRepository.Where(x => x.Nickname == User.Identity.Name).FirstOrDefault());
            }
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit(int id)
        {
            ViewBag.PhotoPath = new SelectList(employeeRepository.GetAll(), "Id", "Email");


            return View(employeeRepository.Where(x => x.Nickname == User.Identity.Name).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}
