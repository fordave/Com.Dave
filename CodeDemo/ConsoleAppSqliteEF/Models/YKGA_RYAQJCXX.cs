namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_RYAQJCXX
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PId { get; set; }

        public DateTime? ksjcsj { get; set; }

        public DateTime? jsjcsj { get; set; }

        public long? jclx { get; set; }

        [StringLength(64)]
        public string jcmj { get; set; }

        [StringLength(64)]
        public string jcmjjh { get; set; }

        [StringLength(512)]
        public string zsqk { get; set; }

        [StringLength(512)]
        public string tsqk { get; set; }

        [StringLength(512)]
        public string sqqk { get; set; }

        [StringLength(512)]
        public string ccqk { get; set; }

        [StringLength(512)]
        public string xwqk { get; set; }

        [StringLength(512)]
        public string qtqk { get; set; }

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

        [StringLength(256)]
        public string qtsm { get; set; }

        [StringLength(64)]
        public string field1 { get; set; }

        [StringLength(64)]
        public string field2 { get; set; }

        [StringLength(64)]
        public string AreaId { get; set; }

        [StringLength(50)]
        public string PersonId { get; set; }
    }
}
