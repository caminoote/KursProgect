namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            addString = new HashSet<addString>();
        }

        [Key]
        public int idProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }

        public int? TimeUse { get; set; }

        public int idTypeGoods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<addString> addString { get; set; }

        public virtual typegoods typegoods { get; set; }
    }
}
