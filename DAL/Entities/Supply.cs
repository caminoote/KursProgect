namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supply")]
    public partial class Supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supply()
        {
            addString = new HashSet<addString>();
        }

        [Key]
        public int idSupply { get; set; }

        [Column(TypeName = "date")]
        public DateTime EnterDate { get; set; }

        public int idTrader { get; set; }

        public int idUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<addString> addString { get; set; }

        public virtual Trader Trader { get; set; }

        public virtual User User { get; set; }
    }
}
