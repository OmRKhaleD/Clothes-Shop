using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    public class MockClothRepository : IClothRepository
    {
        private List<Cloth> Cloths;
        public MockClothRepository()
        {
            if (Cloths == null)
            {
                InitClothes();
            }
        }

        private void InitClothes()
        {
            Cloths = new List<Cloth>
            {
                new Cloth{Id=1,Name="T-shirt",Price=24.99M,ShortDescription="Very beautiful T-shirt",LongDescription="fgkjklf dhglkfhlk fhlgfkghlfl",IsClothOfTheWeek=true,ImageUrl="/images/boys1.png"},
                new Cloth{Id=2,Name="Pant",Price=30.66M,ShortDescription="Very beautiful pant",LongDescription="dhglkfhlk fgkjklf fhlgfkghlfl",IsClothOfTheWeek=false,ImageUrl="/images/men4.png"},
                new Cloth{Id=3,Name="Shoes",Price=20.24M,ShortDescription="Very beautiful shoes",LongDescription="fgkjklf fhlgfkghlfl dhglkfhlk",IsClothOfTheWeek=false,ImageUrl="/images/shoes.jpg"},
                new Cloth{Id=4,Name="Dress",Price=60.32M,ShortDescription="Very beautiful dress",LongDescription="dhglkfhlk fhlgfkghlfl fgkjklf",IsClothOfTheWeek=true,ImageUrl="/images/dress.png"}
            };
        }

        public Cloth GetCloth(int clothId)
        {
            return Cloths.FirstOrDefault(c => c.Id == clothId);
        }

        public IEnumerable<Cloth> GetCloths()
        {
            return Cloths;
        }
    }
}
