namespace CommanderWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        [StringLength(50)]
        public string Cart_ID { get; set; }

        public int? Customer_ID { get; set; }

      
        public int? Product_ID { get; set; }

        [StringLength(50)]
        public string cartId { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        
        public decimal? Price { get; set; }
    }
}
