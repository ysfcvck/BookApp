using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.ViewModels
{
    public class BillboardViewModel
    {
        [Key]
        public int Id { get; set; }
        public string MainTitle1 { get; set; }
        public string MainTitle2 { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
