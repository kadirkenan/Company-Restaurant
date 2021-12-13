using Common;
using DataAccess.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;
using WebUI.Models.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<MenuProduct> menuRepository;
        private readonly IRepository<MenuCategory> categoryRepository;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IRepository<Employee> employeeRepository;
        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> __userManager, SignInManager<AppUser> _signInManager, IRepository<Employee> _employeeRepository, IRepository<MenuProduct> _menuRepository, IRepository<MenuCategory> _categoryRepository)
        {
            _logger = logger;
            userManager = __userManager;
            signInManager = _signInManager;
            employeeRepository = _employeeRepository;
            menuRepository = _menuRepository;
            categoryRepository = _categoryRepository;
        }

        public IActionResult Index()
        {
            return View(menuRepository.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Register()
        {
            ViewBag.Employee = new SelectList(employeeRepository.GetAll(), "Id", "Email");
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
            if(userManager.Users.Any(x=> x.ActivationCode == id))
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
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByEmailAsync(loginVM.Email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        TempData["success"] = $"Hoşgeldin {user.UserName}";
                        return RedirectToAction("Index", user.Role);
                    }
                    else
                    {
                        ModelState.AddModelError("failedLogin", "şifre hatalı!");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("notFound", "böyle bir kullanıcı bulunamadı!");
                }
            }
            return View();
        }
        public IActionResult Denied(string url)
        {
            ViewBag.Url = url;
            return View();
        }
    }
}
