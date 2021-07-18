using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.ViewModels
{
    public class BookViewModel
    {
        [Key]
        public int BookId { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Writer { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Publisher { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public int TotalPages { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public int PublishYear { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Language { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public int GenreId { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public int Stock { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public double Price { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string ImageURL { get; set; }

        public virtual GenreViewModel Genre { get; set; }
        public virtual CategoryViewModel Category { get; set; }

        
    }
}
