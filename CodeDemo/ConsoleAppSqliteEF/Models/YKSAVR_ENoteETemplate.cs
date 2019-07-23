namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ENoteETemplate
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string TemplateName { get; set; }

        public DateTime? BeginTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        [MaxLength(2147483647)]
        public byte[] RecordBiLuHead { get; set; }

        [MaxLength(2147483647)]
        public byte[] RecordBiluContent { get; set; }

        public long? AreaId { get; set; }

        public long? Type { get; set; }

        public long? TypeBelong { get; set; }
    }
}
