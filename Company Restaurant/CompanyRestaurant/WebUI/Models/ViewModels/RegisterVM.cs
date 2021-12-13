using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="kullanıcı adı boş geçilmez!")]
        [Display(Name= "Kullanıcı adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "email boş geçilmez!")]
        [Display(Name = "Eposta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "şifre boş geçilmez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "şifre(tekrar) boş geçilmez!")]
        [Display(Name = "Şifre(Tekrar)")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "role boş geçilmez!")]
        [Display(Name = "Role")]
        public string Role { get; set; }

       
        [Display(Name = "EmployeeEmail")]
        public string EmployeeEmail { get; set; }

    }
}
