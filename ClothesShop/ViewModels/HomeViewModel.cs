using ClothesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Cloth> Clothes { get; set; }
    }
}
