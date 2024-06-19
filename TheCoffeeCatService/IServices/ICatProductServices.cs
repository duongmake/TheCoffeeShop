﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject.BusinessObject;

namespace TheCoffeeCatService.IServices
{
    public interface ICatProductServices
    {
        public List<CatProduct> GetCatProducts();
        public CatProduct GetCatProductById(Guid id);
        public void AddCatProdct(CatProduct catProduct);
        public void UpdateCatProdct(CatProduct catProduct);
        public bool ChangeStatus(CatProduct catProduct);
        public IQueryable<CatProduct> SearchCatProduct(string search);
    }
}
