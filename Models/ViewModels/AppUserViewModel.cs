using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.ViewModels
{
    public class AppUserViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Lütfen 'Kullanıcı Adı' alanını doldurun...")]
        [StringLength(15, ErrorMessage = "Lütfen kullanıcı adını 4 ile 15 karakter arasında giriniz...", MinimumLength = 4)]
        [Display(Name = "UserName")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen 'Ad Soyad' alanını doldurun...")]
        [Display(Name = "NameSurname")]
        public string NameSurname { get; set; }


        [Required(ErrorMessage = "Lütfen 'Telefon Numarası' alanını doldurun...")]
        [Phone(ErrorMessage = "Lütfen bir telefon numarası giriniz...")]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Lütfen 'Email' alanını doldurun...")]
        [EmailAddress(ErrorMessage = "Lütfen uygun formatta eposta giriniz...")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Lütfen 'Adres' alanını doldurun...")]
        [Display(Name = "Adress")]
        public string Adress { get; set; }


        [Required(ErrorMessage = "Lütfen 'Şifre' alanını doldurun...")]
        [DataType(DataType.Password, ErrorMessage = "Lütfen şifreyi tüm kuralları göz önüne alarak giriniz...")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
