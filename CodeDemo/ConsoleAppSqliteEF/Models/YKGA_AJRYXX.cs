namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_AJRYXX
    {
        public long Id { get; set; }

        [StringLength(64)]
        public string dwbh { get; set; }

        [StringLength(64)]
        public string bmbh { get; set; }

        [StringLength(64)]
        public string baqbh { get; set; }

        public long? djcs { get; set; }

        [StringLength(64)]
        public string jzbh { get; set; }

        [StringLength(64)]
        public string jqbh { get; set; }

        [StringLength(64)]
        public string ajbh { get; set; }

        [StringLength(64)]
        public string rybh { get; set; }

        [StringLength(64)]
        public string ryxm { get; set; }

        [StringLength(128)]
        public string rylx { get; set; }

        [StringLength(128)]
        public string rydafs { get; set; }

        [StringLength(128)]
        public string ryay { get; set; }

        [StringLength(64)]
        public string sfzh { get; set; }

        public long? xb { get; set; }

        [StringLength(128)]
        public string mz { get; set; }

        [StringLength(64)]
        public string mzbh { get; set; }

        public DateTime? csrq { get; set; }

        [StringLength(64)]
        public string hyzk { get; set; }

        [StringLength(64)]
        public string hydm { get; set; }

        [StringLength(64)]
        public string zzmm { get; set; }

        [StringLength(64)]
        public string zzmmdm { get; set; }

        [StringLength(64)]
        public string whcd { get; set; }

        [StringLength(64)]
        public string whcddm { get; set; }

        [StringLength(256)]
        public string hjd { get; set; }

        [StringLength(256)]
        public string hjdxz { get; set; }

        [StringLength(256)]
        public string xzd { get; set; }

        [StringLength(256)]
        public string xzdxz { get; set; }

        [StringLength(256)]
        public string lxfs { get; set; }

        [StringLength(256)]
        public string qtlxfs { get; set; }

        [StringLength(128)]
        public string zylb { get; set; }

        [StringLength(128)]
        public string qtzjlx { get; set; }

        [StringLength(64)]
        public string qtzjhm { get; set; }

        [StringLength(256)]
        public string gzdw { get; set; }

        [StringLength(128)]
        public string gj { get; set; }

        [StringLength(128)]
        public string cym { get; set; }

        [StringLength(128)]
        public string jkzk { get; set; }

        [StringLength(128)]
        public string ky { get; set; }

        [StringLength(128)]
        public string lx { get; set; }

        [StringLength(128)]
        public string tx { get; set; }

        [StringLength(128)]
        public string tstz { get; set; }

        [StringLength(128)]
        public string tbbj { get; set; }

        [StringLength(128)]
        public string qttz { get; set; }

        [StringLength(128)]
        public string bm { get; set; }

        [StringLength(128)]
        public string ch { get; set; }

        [StringLength(64)]
        public string bamj1_xm { get; set; }

        [StringLength(64)]
        public string bamj1_jh { get; set; }

        [StringLength(64)]
        public string bamj2_xm { get; set; }

        [StringLength(64)]
        public string bamj2_jh { get; set; }

        public long? ryzt { get; set; }

        [StringLength(64)]
        public string lrr { get; set; }

        [StringLength(64)]
        public string lrrbh { get; set; }

        [StringLength(64)]
        public string lrrjh { get; set; }

        public long? lrrid { get; set; }

        public DateTime? lrsj { get; set; }

        public DateTime? ryddsj { get; set; }

        public DateTime? rylksj { get; set; }

        public DateTime? kswhsj { get; set; }

        public DateTime? jswhsj { get; set; }

        public DateTime? ztlksj { get; set; }

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

        public long? rysxzt { get; set; }
    }
}
