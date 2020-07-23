namespace CommanderWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Wishlist")]
    public partial class Wishlist
    {
        [Key]
        public int Wishlist_ID { get; set; }

        public int? Product_ID { get; set; }

        public int? Customer_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateAdded { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        public virtual Product Product1 { get; set; }
    }
}
