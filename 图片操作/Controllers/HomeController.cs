using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 图片操作.Models;

namespace 图片操作.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            FileStream fs = new FileStream(@"D:\OneDrive\C#程序设计\图片操作\图片操作\image\2.jpg", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Byte[] byData = br.ReadBytes((int)fs.Length);
            fs.Close();


            var products = new List<Product>()
            {
                new Product { Name="Product1", ImageData=byData, ImageType="image/jpeg"},
                new Product { Name="Product2", ImageData=byData, ImageType="image/jpeg"}
            };



            return View();
        }

        [HttpPost]
        public ActionResult Index(Product product,HttpPostedFileBase image)
        {


            return View();
        }

        public FileContentResult GetImage()
        {
            FileStream fs = new FileStream(@"D:\OneDrive\C#程序设计\图片操作\图片操作\image\2.jpg", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Byte[] byData = br.ReadBytes((int)fs.Length);

            byte[] imageData = byData;
            string imageType = "image/jpeg";
            return File(imageData, imageType);
        }
    }
}