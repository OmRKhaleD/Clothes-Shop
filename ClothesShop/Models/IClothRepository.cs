﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothesShop.Models
{
    public interface IClothRepository
    {
        IEnumerable<Cloth> GetCloths();
        Cloth GetCloth(int clothId);
    }
}
