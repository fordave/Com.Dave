namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSACW_WPCZMX
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
        public string jzbh { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(64)]
        public string ajbh { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(64)]
        public string wpbh { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(64)]
        public string wpmc { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "real")]
        public double shuliang { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(16)]
        public string danwei { get; set; }

        [Key]
        [Column(Order = 8)]
        public string wpms { get; set; }

        [Key]
        [Column(Order = 9)]
        public string zpid { get; set; }

        public DateTime? clrq { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long delflag { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long czzt { get; set; }
    }
}
