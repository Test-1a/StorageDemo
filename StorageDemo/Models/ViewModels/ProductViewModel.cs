﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageDemo.Models.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int Count { get; set; }
        public int InventoryValue { get; set; }


    }
}
