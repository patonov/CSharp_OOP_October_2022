﻿using AquaShop.Models.Aquariums;
using AquaShop.Models.Fish;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public class FreshwaterAquarium : Aquarium
    {
        public FreshwaterAquarium(string name) : base(name, 50)
        {
        }
    }
}