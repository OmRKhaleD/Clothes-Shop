using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothesShop.Models
{
    public class ClothesDbContext : IdentityDbContext<IdentityUser>
    {
        public ClothesDbContext(DbContextOptions<ClothesDbContext> options) : base(options)
        {

        }
        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
