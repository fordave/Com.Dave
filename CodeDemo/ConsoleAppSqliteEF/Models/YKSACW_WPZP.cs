namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSACW_WPZP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string zpbh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string wpbh { get; set; }

        [MaxLength(2147483647)]
        public byte[] zhaop { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long zplx { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(64)]
        public string zhpwj { get; set; }

        public DateTime? lrsj { get; set; }
    }
}
