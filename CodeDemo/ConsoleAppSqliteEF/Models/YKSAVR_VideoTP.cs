namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_VideoTP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(50)]
        public string FileId { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        public short? FileType { get; set; }

        public DateTime? FileBeginTime { get; set; }

        public DateTime? FileEndTime { get; set; }

        public decimal? FileSize { get; set; }

        public DateTime? FileUploadTime { get; set; }

        public short? ServerId { get; set; }

        public long? AreaId { get; set; }

        public long? UserId { get; set; }

        public long? RightGroupId { get; set; }

        [StringLength(1073741823)]
        public string Description { get; set; }

        public short? IsUpload { get; set; }

        [StringLength(256)]
        public string VedioURL { get; set; }

        [StringLength(256)]
        public string VedioFileName { get; set; }

        [StringLength(256)]
        public string FileFTPURL { get; set; }
    }
}
