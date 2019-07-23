namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_RYBL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(64)]
        public string dwbh { get; set; }

        [StringLength(64)]
        public string bmbh { get; set; }

        [StringLength(64)]
        public string baqbh { get; set; }

        [StringLength(64)]
        public string jzbh { get; set; }

        [StringLength(512)]
        public string ajmc { get; set; }

        [StringLength(64)]
        public string ajbh { get; set; }

        [StringLength(64)]
        public string jqbh { get; set; }

        [StringLength(64)]
        public string rybh { get; set; }

        public long? PId { get; set; }

        [StringLength(50)]
        public string PersonId { get; set; }

        [StringLength(50)]
        public string ryxm { get; set; }

        [StringLength(128)]
        public string rylx { get; set; }

        [StringLength(128)]
        public string rydafs { get; set; }

        [StringLength(64)]
        public string sfzh { get; set; }

        public long? xb { get; set; }

        public DateTime? csrq { get; set; }

        public DateTime? ryddsj { get; set; }

        [StringLength(64)]
        public string bamj1_xm { get; set; }

        [StringLength(64)]
        public string bamj1_jh { get; set; }

        [StringLength(64)]
        public string bamj2_xm { get; set; }

        [StringLength(64)]
        public string bamj2_jh { get; set; }

        public long? blcs { get; set; }

        public long? bllxid { get; set; }

        [StringLength(64)]
        public string bllxmc { get; set; }

        public DateTime? blkssj { get; set; }

        public DateTime? bljssj { get; set; }

        [StringLength(64)]
        public string lrr { get; set; }

        [StringLength(64)]
        public string lrrbh { get; set; }

        [StringLength(64)]
        public string lrrjh { get; set; }

        public long? lrrid { get; set; }

        public DateTime? lrsj { get; set; }

        [StringLength(64)]
        public string whr { get; set; }

        [StringLength(64)]
        public string whrbh { get; set; }

        [StringLength(64)]
        public string whrjh { get; set; }

        public long? whrid { get; set; }

        [StringLength(256)]
        public string blwjmc { get; set; }

        [MaxLength(2147483647)]
        public byte[] blwj { get; set; }

        public long? blwjlx { get; set; }

        public long? sfsc { get; set; }

        public long? blzt { get; set; }
    }
}
