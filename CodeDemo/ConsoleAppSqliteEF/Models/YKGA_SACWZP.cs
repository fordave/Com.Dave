namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_SACWZP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long wpId { get; set; }

        [StringLength(64)]
        public string zpmc { get; set; }

        [StringLength(256)]
        public string zpsm { get; set; }

        [MaxLength(2147483647)]
        public byte[] zpsj { get; set; }

        [StringLength(256)]
        public string wjmc { get; set; }

        [StringLength(32)]
        public string wjhz { get; set; }

        [StringLength(64)]
        public string tjfs { get; set; }

        [StringLength(64)]
        public string lrr { get; set; }

        [StringLength(64)]
        public string lrrbh { get; set; }

        [StringLength(64)]
        public string lrrjh { get; set; }

        public long? lrrid { get; set; }

        public DateTime? lrsj { get; set; }

        [StringLength(64)]
        public string xgr { get; set; }

        [StringLength(64)]
        public string xgrbh { get; set; }

        [StringLength(64)]
        public string xgrjh { get; set; }

        public long? xgrid { get; set; }

        public DateTime? xgsj { get; set; }

        public long? sfsc { get; set; }

        public long? sczt { get; set; }

        [StringLength(128)]
        public string MD5 { get; set; }
    }
}
