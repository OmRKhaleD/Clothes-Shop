using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(ClothesDbContext clothes)
        {
            if (!clothes.Clothes.Any())
            {
                clothes.AddRange(
                   new Cloth { Name = "Boys T-shirt", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "fgkjklf dhglkfhlk fhlgfkghlfl", ImageUrl = "boys1.png", IsClothOfTheWeek = true},
                    new Cloth { Name = "Men Pants", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "dhglkfhlk fgkjklf fhlgfkghlfl", ImageUrl = "men4.png", IsClothOfTheWeek = false },
                    new Cloth { Name = "Women Shoes", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription = "fgkjklf fhlgfkghlfl dhglkfhlk", ImageUrl = "shoes.jpg", IsClothOfTheWeek = false},
                    new Cloth { Name = "Women Dress", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription = "dhglkfhlk fhlgfkghlfl fgkjklf", ImageUrl = "dress.png", IsClothOfTheWeek = false },
                    new Cloth { Name = "Women Bag", Price = 13.95M, ShortDescription = "Happy holidays with this pie!", LongDescription = "fgkjklf dhglkfhlk fhlgfkghlfl", ImageUrl = "women5.png", IsClothOfTheWeek = false },
                    new Cloth { Name = "Men belt", Price = 17.95M, ShortDescription = "A Christmas favorite", LongDescription = "dhglkfhlk fgkjklf fhlgfkghlfl", ImageUrl = "men7.png", IsClothOfTheWeek = false},
                    new Cloth { Name = "Women Skrit", Price = 15.95M, ShortDescription = "Sweet as peach", LongDescription = "fgkjklf fhlgfkghlfl dhglkfhlk", ImageUrl = "women3.png", IsClothOfTheWeek = false },
                    new Cloth { Name = "Women Blouse", Price = 12.95M, ShortDescription = "Our Halloween favorite", LongDescription = "dhglkfhlk fhlgfkghlfl fgkjklf", ImageUrl = "women2.png", IsClothOfTheWeek = true },
                    new Cloth { Name = "Girls Toy", Price = 15.95M, ShortDescription = "My God, so sweet!", LongDescription = "fgkjklf dhglkfhlk fhlgfkghlfl", ImageUrl = "bunny.jpg", IsClothOfTheWeek = true },
                    new Cloth { Name = "Girls Dress", Price = 15.95M, ShortDescription = "Our delicious strawberry pie!", LongDescription = "dhglkfhlk fgkjklf fhlgfkghlfl", ImageUrl = "girls1.png", IsClothOfTheWeek = false },
                    new Cloth { Name = "Men Shirt", Price = 18.95M, ShortDescription = "You'll love it!", LongDescription = "fgkjklf fhlgfkghlfl dhglkfhlk", ImageUrl = "men2.png", IsClothOfTheWeek = false }
                );
                clothes.SaveChanges();
            }
        }
    }
}
