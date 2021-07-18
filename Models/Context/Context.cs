using BookApp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-68O6AVP\\SQLEXPRESS;Database=BookAppDb;Trusted_Connection=True;");
        }

        public DbSet<GenreViewModel> Genres { get; set; }
        public DbSet<CategoryViewModel> Categories { get; set; }
        public DbSet<StatusViewModel> Statuses { get; set; }
        public DbSet<BookViewModel> Books { get; set; }
        public DbSet<CartViewModel> Carts { get; set; }
        public DbSet<OrderViewModel> Orders { get; set; }
        public DbSet<BillboardViewModel> Billboards { get; set; }
    }
}
