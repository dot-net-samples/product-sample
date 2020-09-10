using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data
{
    public class ProductDataRepository : IProductDataRepository
    {

        public int Add(ProductModel model)
        {
            using (var context = new ProductDataContext())
            {
                context.Products.Add(model);
                var rowsAffected = context.SaveChanges();

                return rowsAffected;
            }
        }

        public int Delete(int productID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> Find(Expression<Func<ProductModel, bool>> query)
        {
            throw new NotImplementedException();
        }

        public ProductModel Get(int productID)
        {
            using (var context = new ProductDataContext())
            {
                var model = context.Products.Where(c => c.ProductID == productID).FirstOrDefault();
                return model;
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel model)
        {
            throw new NotImplementedException();
        }
    }
}
