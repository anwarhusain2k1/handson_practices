using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06._10._22.Controllers
{
    public class productController : Controller
    {
        static List<Product> productlist = new List<Product>();

        // GET: product
        public ActionResult Index()
        {
            return View(productlist);
        }

        // GET: product/Details/5
        public ActionResult Details(int id)
        {
            Product found = productlist.Find(product => product.proid == id);

            return View(found);
        }

        // GET: product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                productlist.Add(product);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: product/Edit/5
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

        // GET: product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: product/Delete/5
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
