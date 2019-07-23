namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSACW_WPCZ
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string czbh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string dwmc { get; set; }

        public DateTime? clrq { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long clfs { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(64)]
        public string cldw { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(64)]
        public string jsrjh { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(64)]
        public string jsrsfzh { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(64)]
        public string jsr { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(64)]
        public string clrjh { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(64)]
        public string clrsfzh { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(64)]
        public string clr { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(256)]
        public string clyy { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(512)]
        public string beizhu { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long shzt { get; set; }

        [Key]
        [Column(Order = 14)]
        public string shyj { get; set; }

        public DateTime? shrq { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(64)]
        public string shr { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long delflag { get; set; }
    }
}
