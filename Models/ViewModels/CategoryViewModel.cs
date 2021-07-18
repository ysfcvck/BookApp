using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.ViewModels
{
    public class CategoryViewModel
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public bool Status { get; set; }
    }
}
