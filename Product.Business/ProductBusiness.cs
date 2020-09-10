using Models;
using Product.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductDataRepository _dataRepo;
        public ProductBusiness(IProductDataRepository dataRepo)
        {
            _dataRepo = dataRepo;
        }
        public int Add(ProductModel model)
        {
            return _dataRepo.Add(model);
        }

        public int Update(ProductModel model)
        {
            return _dataRepo.Update(model);
        }
        public int Delete(int productID)
        {
            return _dataRepo.Delete(productID);
        }

        public IEnumerable<ProductModel> Find(Expression<Func<ProductModel, bool>> query)
        {
            return _dataRepo.Find(query);
        }

        public ProductModel Get(int productID)
        {
            return _dataRepo.Get(productID);
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return _dataRepo.GetAll();
        }


    }
}
