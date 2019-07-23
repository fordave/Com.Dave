namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_JQXX
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(64)]
        public string jqbh { get; set; }

        [StringLength(64)]
        public string jjr { get; set; }

        [StringLength(64)]
        public string jjrbh { get; set; }

        [StringLength(64)]
        public string jjrjh { get; set; }

        [StringLength(128)]
        public string gxdw { get; set; }

        [StringLength(64)]
        public string gxdwbh { get; set; }

        [StringLength(64)]
        public string bjfs { get; set; }

        [StringLength(64)]
        public string bjfsbh { get; set; }

        [StringLength(64)]
        public string jqxzbh { get; set; }

        [StringLength(64)]
        public string jqxz { get; set; }

        [StringLength(64)]
        public string jqlb { get; set; }

        [StringLength(64)]
        public string jqlbbh { get; set; }

        public DateTime? bjsj { get; set; }

        public DateTime? afsj { get; set; }

        [StringLength(256)]
        public string afdd { get; set; }

        [StringLength(64)]
        public string bjrxm { get; set; }

        [StringLength(64)]
        public string bjrxb { get; set; }

        [StringLength(64)]
        public string bjrxbbh { get; set; }

        [StringLength(64)]
        public string bjrlxdh { get; set; }

        [StringLength(128)]
        public string bjrgzdw { get; set; }

        [StringLength(256)]
        public string bjrzz { get; set; }

        [StringLength(2147483647)]
        public string bjnr { get; set; }

        [StringLength(64)]
        public string cjdw { get; set; }

        [StringLength(64)]
        public string cjdwbh { get; set; }

        [StringLength(512)]
        public string cjr { get; set; }

        [StringLength(64)]
        public string cjrjh { get; set; }

        [StringLength(64)]
        public string cjrbh { get; set; }

        [StringLength(2147483647)]
        public string cjnr { get; set; }

        [StringLength(64)]
        public string cbqy_bh { get; set; }

        [StringLength(64)]
        public string fljg { get; set; }

        [StringLength(64)]
        public string fljgbh { get; set; }

        [StringLength(64)]
        public string spr { get; set; }

        [StringLength(64)]
        public string sprbh { get; set; }

        public DateTime? spsj { get; set; }

        [StringLength(64)]
        public string ajbh { get; set; }

        [StringLength(64)]
        public string is_cfjq { get; set; }

        [StringLength(64)]
        public string gljqbh { get; set; }

        [StringLength(64)]
        public string jqzt { get; set; }

        [StringLength(64)]
        public string jqztbh { get; set; }

        [StringLength(64)]
        public string is_xctjaj { get; set; }

        [StringLength(64)]
        public string zbrbh { get; set; }

        [StringLength(64)]
        public string zbr { get; set; }

        [StringLength(64)]
        public string zbrjh { get; set; }

        [StringLength(64)]
        public string xbrbh { get; set; }

        [StringLength(64)]
        public string xbrjh { get; set; }

        [StringLength(64)]
        public string xbr { get; set; }

        [StringLength(64)]
        public string ysjsdwbh { get; set; }

        [StringLength(128)]
        public string ysjsdw { get; set; }

        [StringLength(64)]
        public string ysjsrbh { get; set; }

        [StringLength(64)]
        public string ysjsrjh { get; set; }

        [StringLength(64)]
        public string ysjsr { get; set; }

        public DateTime? djsj { get; set; }

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

        [StringLength(64)]
        public string qtsm { get; set; }

        [StringLength(64)]
        public string field1 { get; set; }

        [StringLength(64)]
        public string field2 { get; set; }

        [StringLength(64)]
        public string AreaId { get; set; }
    }
}
