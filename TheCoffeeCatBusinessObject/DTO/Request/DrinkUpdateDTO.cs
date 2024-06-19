﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeeCatBusinessObject.DTO.Request
{
    public class DrinkUpdateDTO
    {

        public string? DrinkName { get; set; }
        public double? UnitPrice { get; set; }
        public bool? Status { get; set; }
        public IFormFile? Image { get; set; }
    }
}
