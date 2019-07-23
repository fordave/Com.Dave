namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSACW_WPXX
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string dwbh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string bmbh { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(64)]
        public string baqbh { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(64)]
        public string jzbh { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(64)]
        public string ajbh { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(512)]
        public string ajmc { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(64)]
        public string jqbh { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(64)]
        public string wpbh { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(64)]
        public string wpmc { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long wzzl { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long wpdj { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(64)]
        public string wpcyr { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(64)]
        public string wpcyrzj { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "real")]
        public double wpsl { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(16)]
        public string wpdw { get; set; }

        public DateTime? yssj { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(256)]
        public string yjr { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(64)]
        public string jyh { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(256)]
        public string jzr { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long wply { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(64)]
        public string lydw { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(64)]
        public string djr { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(64)]
        public string bgy { get; set; }

        [Key]
        [Column(Order = 23)]
        public string bgdw { get; set; }

        public DateTime? gqsj { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long bgqx { get; set; }

        public DateTime? djsj { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(256)]
        public string wpxz { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(512)]
        public string beizhu { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(64)]
        public string cfwz { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long wpclzt { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long delflag { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long scbz { get; set; }

        public DateTime? clsj { get; set; }

        public long? cfwzbz { get; set; }
    }
}
