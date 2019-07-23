namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_Trace
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        [StringLength(50)]
        public string CaseId { get; set; }

        [Required]
        [StringLength(50)]
        public string ReaderDeviceId { get; set; }

        public long? FirstTime { get; set; }

        public long? LastTime { get; set; }

        public DateTime? FirstTime2 { get; set; }

        public DateTime? LastTime2 { get; set; }

        public short? Status { get; set; }

        public short? IsUpload { get; set; }

        public long? AreaId { get; set; }

        public long? UserId { get; set; }

        public long? Func { get; set; }
    }
}
