﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeeCatBusinessObject.DTO
{
    public class MenuUpdateDTO
    {
        public bool? Status { get; set; }
        public Guid? CoffeeID { get; set; }
        public Guid? DrinkID { get; set; }
        public Guid? CatProductID { get; set; }
    }
}
