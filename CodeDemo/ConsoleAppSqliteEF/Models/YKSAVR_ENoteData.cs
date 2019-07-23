namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ENoteData
    {
        public long Id { get; set; }

        [StringLength(255)]
        public string TaskName { get; set; }

        [StringLength(20)]
        public string TaskId { get; set; }

        [StringLength(20)]
        public string DossierInsideId { get; set; }

        public DateTime? BeginTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime? TrialBegin { get; set; }

        public DateTime? TrialEnd { get; set; }

        [MaxLength(2147483647)]
        public byte[] RecordBiLuHead { get; set; }

        [MaxLength(2147483647)]
        public byte[] RecordBiluContent { get; set; }

        public long? AreaId { get; set; }

        public long? UserId { get; set; }

        public long? RightGroupId { get; set; }

        public short? IsUpload { get; set; }

        public long? Type { get; set; }

        public long? TypeBelong { get; set; }
    }
}
