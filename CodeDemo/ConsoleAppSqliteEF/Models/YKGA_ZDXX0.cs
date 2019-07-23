namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_ZDXX0
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long lxId { get; set; }

        [StringLength(64)]
        public string lxmc { get; set; }

        [StringLength(32)]
        public string dm { get; set; }

        [StringLength(64)]
        public string mc { get; set; }

        [StringLength(64)]
        public string qtsm { get; set; }
    }
}
