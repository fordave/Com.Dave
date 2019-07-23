namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_SACW
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

        [StringLength(64)]
        public string ajbh { get; set; }

        [StringLength(64)]
        public string jqbh { get; set; }

        public long? PId { get; set; }

        [StringLength(64)]
        public string wpbh { get; set; }

        [StringLength(128)]
        public string wpmc { get; set; }

        [StringLength(256)]
        public string wpjs { get; set; }

        [StringLength(128)]
        public string wply { get; set; }

        [Column(TypeName = "real")]
        public double? wpsl { get; set; }

        [StringLength(32)]
        public string sldw { get; set; }

        [Column(TypeName = "real")]
        public double? wpzzl { get; set; }

        [StringLength(128)]
        public string ccdx { get; set; }

        [StringLength(128)]
        public string xjcd { get; set; }

        [StringLength(128)]
        public string cwlb { get; set; }

        public DateTime? zkrq { get; set; }

        [StringLength(256)]
        public string cfdd { get; set; }

        [StringLength(128)]
        public string wpfl { get; set; }

        [StringLength(128)]
        public string wxcd { get; set; }

        [StringLength(128)]
        public string cwfs { get; set; }

        [StringLength(128)]
        public string cwgh { get; set; }

        [StringLength(128)]
        public string bqbh { get; set; }

        public long? sftx { get; set; }

        public DateTime? txrq { get; set; }

        public DateTime? gqsj { get; set; }

        [StringLength(256)]
        public string wpbz { get; set; }

        [StringLength(64)]
        public string clfs { get; set; }

        [StringLength(64)]
        public string clldw { get; set; }

        [StringLength(64)]
        public string yjdw { get; set; }

        [StringLength(64)]
        public string clr { get; set; }

        [StringLength(64)]
        public string clrbh { get; set; }

        [StringLength(64)]
        public string clrjh { get; set; }

        [StringLength(256)]
        public string clbz { get; set; }

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

        public long? wpzt { get; set; }

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
