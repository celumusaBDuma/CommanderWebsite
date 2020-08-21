using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CommanderWebsite.Models
{
    public class Cart
    {
        
            [Key]
            public string Cart_ID { get; set; }
            public string CartId { get; set; }
            public int Customer_ID  { get; set; }
            public int Quantity { get; set; }
            public System.DateTime DateCreated { get; set; }
            public int Product_ID { get; set; }
            public virtual Product Product { get; set; }
            public virtual Customer Customer { get; set; }
    }
}

