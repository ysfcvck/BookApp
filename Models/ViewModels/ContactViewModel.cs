using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Boş geçilemez !")]
        public string Subject { get; set; }


        [Required(ErrorMessage = "Boş geçilemez !")]
        public string Message { get; set; }


        [Required(ErrorMessage = "Boş geçilemez !")]
        public string NameSurname { get; set; }


        [Required, EmailAddress(ErrorMessage = "Lütfen ornek@ formatında bir mail giriniz.")]
        public string Email { get; set; }
    }
}
