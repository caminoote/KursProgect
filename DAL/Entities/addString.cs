namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("addString")]
    public partial class addString
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public addString()
        {
            OutString = new HashSet<OutString>();
        }

        [Key]
        public int idString { get; set; }

        public int AddKool { get; set; }

        public int StorageKool { get; set; }

        public int Price { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreate { get; set; }

        public int idSupply { get; set; }

        public int idProduct { get; set; }

        public virtual Product Product { get; set; }

        public virtual Supply Supply { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutString> OutString { get; set; }
    }
}
