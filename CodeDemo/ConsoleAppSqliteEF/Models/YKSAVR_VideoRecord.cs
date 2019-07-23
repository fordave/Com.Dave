namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_VideoRecord
    {
        public long Id { get; set; }

        [Required]
        [StringLength(20)]
        public string VideoRecordId { get; set; }

        [StringLength(250)]
        public string FilePath { get; set; }

        public DateTime? BeginTime { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(50)]
        public string DossierInsideId { get; set; }

        public short? ServerId { get; set; }

        public long AreaId { get; set; }

        public long? UserId { get; set; }

        public long? RightGroupId { get; set; }

        [StringLength(2147483647)]
        public string Description { get; set; }

        public short? IsUpload { get; set; }

        public long Channel { get; set; }

        public long OrganizeId { get; set; }

        public long? FileSize { get; set; }

        public long? DeviceId { get; set; }

        [StringLength(50)]
        public string PersonId { get; set; }

        public short? Status { get; set; }
    }
}
