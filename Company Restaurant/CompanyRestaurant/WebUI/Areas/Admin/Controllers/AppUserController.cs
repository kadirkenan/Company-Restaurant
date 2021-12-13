using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using WebUI.Models.ViewModels;
using Common;
using System;
using System.Linq;
using System.Diagnostics;
using WebUI.Areas.Admin.Views;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> appUser;
        private readonly IUserRepository userRepository;
        private readonly UserManager<AppUser> userManager;
        public AppUserController(UserManager<AppUser> _appUser, IUserRepository _userRepository, UserManager<AppUser> _userManager)
        {
            appUser = _appUser;
            userRepository = _userRepository;
            userManager = _userManager;
        }

        public ActionResult Index()
        {

            return View(userRepository.GetUserForRole());
        }

        
        public ActionResult Details(int Id)
        {
            return View();
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int Id, string Role)
        {
            //appUser.IsInRoleAsync(Role);
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int Id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        public ActionResult Delete(int Id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                AppUser newUser = new AppUser();
                newUser.UserName = registerVM.UserName;
                newUser.Email = registerVM.Email;
                newUser.Role = registerVM.Role;
                var result = await userManager.CreateAsync(newUser, registerVM.Password);
                if (result.Succeeded)
                {
                    string mailMessage = $"Merhaba {newUser.FirstName} {newUser.FirstName}! {newUser.Role} olarak sisteme kaydınız yapılmıştır! Aşağıdaki linke tıklayarak {newUser.Role} hesabınızı aktif hale getirin. " +
                        $"/nhttps://localhost:44389/Home/Activation/{newUser.ActivationCode}";
                    MailSender.SendMail(registerVM.Email, "Hesap Aktivasyon", mailMessage);
                    return RedirectToAction("PendingAccount", newUser);
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            else
            {
                return View();
            }
            return View();
        }
        public IActionResult PendingAccount(AppUser user)
        {
            ViewBag.User = user;
            return View();
        }
        public async Task<IActionResult> Activation(Guid id)
        {
            if (userManager.Users.Any(x => x.ActivationCode == id))
            {
                AppUser user = userManager.Users.Where(x => x.ActivationCode == id).FirstOrDefault();
                user.EmailConfirmed = true;
                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    TempData["success"] = "Hesabınız aktifleştirildi!";
                    return RedirectToAction("Login");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View();
            }
        }
    }
}
