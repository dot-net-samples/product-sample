using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<ProductModel> ProductList { get; set; }

    }
}