﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.ViewModels
{
    public class StatusViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
