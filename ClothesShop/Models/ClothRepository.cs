using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    public class ClothRepository : IClothRepository
    {
        private readonly ClothesDbContext clothesDbContext;
        public ClothRepository(ClothesDbContext clothDbContext)
        {
            clothesDbContext = clothDbContext;
        }

        public Cloth GetCloth(int clothId)
        {
            return clothesDbContext.Clothes.FirstOrDefault(c => c.Id == clothId);
        }

        public IEnumerable<Cloth> GetCloths()
        {
            return clothesDbContext.Clothes.ToList();
        }
    }
}
