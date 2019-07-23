namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_RYWPDJXX
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? PId { get; set; }

        [StringLength(256)]
        public string wpmc { get; set; }

        [StringLength(256)]
        public string wpms { get; set; }

        [StringLength(256)]
        public string wptz { get; set; }

        [StringLength(512)]
        public string wpxxsm { get; set; }

        [StringLength(64)]
        public string zfdh { get; set; }

        [StringLength(64)]
        public string cwgh { get; set; }

        [Column(TypeName = "real")]
        public double? wpsl { get; set; }

        [StringLength(64)]
        public string wpsldw { get; set; }

        public DateTime? wpdjsj { get; set; }

        [StringLength(64)]
        public string djmj { get; set; }

        [StringLength(64)]
        public string djmjjh { get; set; }

        [StringLength(256)]
        public string wuply { get; set; }

        public long? sfsa { get; set; }

        [StringLength(128)]
        public string clfs { get; set; }

        public DateTime? wpclsj { get; set; }

        [StringLength(128)]
        public string wpclsm { get; set; }

        public long? sflq { get; set; }

        public DateTime? wplqsj { get; set; }

        [StringLength(64)]
        public string lqry { get; set; }

        [StringLength(64)]
        public string lqrysfzh { get; set; }

        [StringLength(64)]
        public string lqmj { get; set; }

        [StringLength(64)]
        public string lqmjjh { get; set; }

        public long? sfqblq { get; set; }

        [StringLength(256)]
        public string lqsm { get; set; }

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
