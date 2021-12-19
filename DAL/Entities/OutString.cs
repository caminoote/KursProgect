namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutString")]
    public partial class OutString
    {
        [Key]
        public int idOutString { get; set; }

        public int OutKool { get; set; }

        [Column(TypeName = "date")]
        public DateTime OutDate { get; set; }

        public int idString { get; set; }

        public int? idOut { get; set; }

        public virtual addString addString { get; set; }

        public virtual Out Out { get; set; }
    }
}
