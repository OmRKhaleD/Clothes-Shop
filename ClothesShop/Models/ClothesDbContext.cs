using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    public class ClothesDbContext : DbContext
    {
        public ClothesDbContext(DbContextOptions<ClothesDbContext> options) : base(options)
        {

        }
        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
