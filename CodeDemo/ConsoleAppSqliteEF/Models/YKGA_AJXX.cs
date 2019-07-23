namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_AJXX
    {
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

        [StringLength(512)]
        public string ajmc { get; set; }

        public long? ajlx { get; set; }

        [StringLength(64)]
        public string ajlxbh { get; set; }

        [StringLength(256)]
        public string ajly { get; set; }

        [StringLength(64)]
        public string ajlybh { get; set; }

        [StringLength(256)]
        public string abmc { get; set; }

        [StringLength(64)]
        public string abmcbh { get; set; }

        [StringLength(2147483647)]
        public string jyaq { get; set; }

        [StringLength(256)]
        public string ajzt { get; set; }

        [StringLength(64)]
        public string ajztbh { get; set; }

        [StringLength(256)]
        public string cbdw { get; set; }

        [StringLength(64)]
        public string cbdwbh { get; set; }

        [StringLength(64)]
        public string cbbmbh { get; set; }

        [StringLength(256)]
        public string fadd { get; set; }

        public DateTime? fasj { get; set; }

        public DateTime? slsj { get; set; }

        public DateTime? lasj { get; set; }

        public DateTime? jasj { get; set; }

        [StringLength(256)]
        public string sldw { get; set; }

        [StringLength(64)]
        public string sldwbh { get; set; }

        [StringLength(64)]
        public string slbmbh { get; set; }

        [StringLength(64)]
        public string zbr { get; set; }

        [StringLength(64)]
        public string zbrbh { get; set; }

        [StringLength(64)]
        public string zbrjh { get; set; }

        [StringLength(64)]
        public string jdzt { get; set; }

        [StringLength(64)]
        public string jdztbh { get; set; }

        [StringLength(64)]
        public string xyr { get; set; }

        [StringLength(64)]
        public string xyrbh { get; set; }

        [StringLength(64)]
        public string zbx { get; set; }

        [StringLength(64)]
        public string zby { get; set; }

        [StringLength(64)]
        public string jqbh { get; set; }

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

        public long? ajsxzt { get; set; }
    }
}
