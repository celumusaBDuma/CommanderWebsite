using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommanderWebsite.Models;

namespace CommanderWebsite.Controllers
{
    public class CategoryController
    {
        
        public static int getCatById(string type)
        {
            CommanderEDM db = new CommanderEDM();
            var cat = db.Categories.SingleOrDefault(c => c.Type == type).Category_ID;
       
            return cat;
        }

        public static List<int> getCategoryList()
        {
            CommanderEDM db = new CommanderEDM();
            var cap = 0;
            
            foreach (var c in db.Categories)
            {
                cap++;
            } 
            var li = new List<int>(cap);
            foreach (var c in db.Categories)
            {
                li.Add(c.Category_ID);
            }
            return li;
        }
    }
}