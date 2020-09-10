using Models;
using Product.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        IProductBusiness _productBusiness;
        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }
        // GET: Product
        public ActionResult Index()
        {
            _productBusiness.Add(new ProductModel() { UnitID = 1, CategoryID = 1, CurrencyID = 1, Price = 10, ProductName = "Laptop" });
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            _productBusiness.Get(id);
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            _productBusiness.Get(1);
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel model)
        {
            try
            {
                _productBusiness.Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
