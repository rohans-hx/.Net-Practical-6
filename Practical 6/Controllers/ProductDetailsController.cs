using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class ProductDetailsController : Controller
    {
        // GET: ProductDetails
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProductData();

            return View("Product", P);
        }

        public ActionResult Details(int id)
        {
            List<Product> P = new List<Product>();
            Product p1 = new Product();
            P = GetProductData();
            p1 = P.FirstOrDefault(x => x.ProductID == id);
            return View("Details", p1);
        }

        public List<Product> GetProductData()
        {
            List<Product> P = new List<Product>();

            Product p1 = new Product();
            p1.ProductID = 101;
            p1.ProductName = "Macbook";
            p1.ProductCategory = "Electronics";
            p1.ProductPrice = 89999;
            p1.ProductQuantity = 99;
            p1.ImageUrl = "https://www.apple.com/newsroom/images/product/mac/standard/Apple_MacBook-Pro_14-16-inch_10182021_big.jpg.large.jpg";

            Product p2 = new Product();
            p2.ProductID = 102;
            p2.ProductName = "Iphone";
            p2.ProductCategory = "Electronics";
            p2.ProductPrice = 79999;
            p2.ProductQuantity = 500;
            p2.ImageUrl = "https://www.apple.com/newsroom/images/2024/09/apple-debuts-iphone-16-pro-and-iphone-16-pro-max/article/Apple-iPhone-16-Pro-hero-240909_inline.jpg.large.jpg";

            Product p3 = new Product();
            p3.ProductID = 103;
            p3.ProductName = "Watch";
            p3.ProductCategory = "Electronics";
            p3.ProductPrice = 129999;
            p3.ImageUrl = "https://m.media-amazon.com/images/I/81STyydHGCL._AC_UF1000,1000_QL80_.jpg";

            P.Add(p1);
            P.Add(p2);
            P.Add(p3);

            return P;
        }
    }
}