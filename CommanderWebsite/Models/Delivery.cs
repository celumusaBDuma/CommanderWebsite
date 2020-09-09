namespace CommanderWebsite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Delivery")]
    public partial class Delivery
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Delivery()
        {
            Orders = new HashSet<Order>();
            Orders1 = new HashSet<Order>();
        }

        [Key]
        public int Delivery_ID { get; set; }

        public int? Admin_ID { get; set; }

        [Column(TypeName = "text")]
        public string dAddress { get; set; }

        public decimal? Cost { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        public int? Delivered { get; set; }

        public int? Customer_ID { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders1 { get; set; }
    }
}
