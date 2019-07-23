namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dtproperty
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public long? objectid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string property { get; set; }

        [StringLength(255)]
        public string value { get; set; }

        [StringLength(255)]
        public string uvalue { get; set; }

        [MaxLength(2147483647)]
        public byte[] lvalue { get; set; }

        public long version { get; set; }
    }
}
