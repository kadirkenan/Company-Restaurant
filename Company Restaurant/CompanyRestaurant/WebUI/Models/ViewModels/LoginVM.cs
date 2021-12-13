using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "email boş geçilmez!")]
        [Display(Name = "Eposta")]
        public string Email { get; set; }

        [Required(ErrorMessage = "şifre boş geçilmez!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
