namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Out")]
    public partial class Out
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Out()
        {
            OutString = new HashSet<OutString>();
        }

        [Key]
        public int idOut { get; set; }

        public DateTime OutDate { get; set; }

        public int idShop { get; set; }

        public int? IdUser { get; set; }

        public virtual Shops Shops { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutString> OutString { get; set; }
    }
}
