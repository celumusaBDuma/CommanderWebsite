using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Controllers
{
    public class BrandsController
    {
        public static void insertBrand(string name, string desc, byte[] img)
        {
            CommanderEDM db = new CommanderEDM();
            var brand = new Brand()
            {
                Name = name,
                Descrption = desc,
                Admin_ID = 1,
                Picture = img
            };
            db.Brands.Add(brand);
            db.SaveChanges();
        }
    }
}