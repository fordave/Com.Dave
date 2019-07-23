namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_RYCJXX
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PId { get; set; }

        public DateTime? kscjsj { get; set; }

        public DateTime? jscjsj { get; set; }

        [StringLength(64)]
        public string cjmj { get; set; }

        [StringLength(64)]
        public string cjmjjh { get; set; }

        [StringLength(64)]
        public string cjfs { get; set; }

        [Column(TypeName = "real")]
        public double? rysg { get; set; }

        [Column(TypeName = "real")]
        public double? rytz { get; set; }

        [Column(TypeName = "real")]
        public double? ryzc { get; set; }

        [StringLength(512)]
        public string zhiwen { get; set; }

        [StringLength(512)]
        public string zhangwen { get; set; }

        [StringLength(512)]
        public string zuji { get; set; }

        [StringLength(512)]
        public string DNA { get; set; }

        [StringLength(512)]
        public string niaoye { get; set; }

        [StringLength(512)]
        public string jiujian { get; set; }

        [StringLength(512)]
        public string tmtz { get; set; }

        [StringLength(512)]
        public string qtjc { get; set; }

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
