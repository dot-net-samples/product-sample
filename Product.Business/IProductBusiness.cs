using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business
{
    public interface IProductBusiness
    {
        int Add(ProductModel model);
        int Update(ProductModel model);
        int Delete(int productID);
        IEnumerable<ProductModel> GetAll();
        ProductModel Get(int productID);
        IEnumerable<ProductModel> Find(Expression<Func<ProductModel, bool>> query);
    }
}
