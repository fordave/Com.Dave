namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_CaseTPLink
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FileId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CaseId { get; set; }

        public long? UserId { get; set; }

        public DateTime? LinkTime { get; set; }
    }
}
