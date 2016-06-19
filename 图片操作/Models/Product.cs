using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 图片操作.Models
{
    public class Product
    {
        [HiddenInput(DisplayValue =false)]
        public int ProductID { get; set; }

        public string Name { get; set; }

        public byte[] ImageData { get; set; }

        [HiddenInput(DisplayValue =false)]
        public string ImageType { get; set; }
    }
}