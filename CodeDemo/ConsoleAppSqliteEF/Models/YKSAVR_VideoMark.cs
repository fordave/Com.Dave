namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_VideoMark
    {
        public long Id { get; set; }

        [StringLength(20)]
        public string DossierInsideId { get; set; }

        public DateTime? BeginTime { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public long? AreaId { get; set; }

        public long? RightGroupId { get; set; }

        public long? UserId { get; set; }

        public short? IsUpload { get; set; }
    }
}
