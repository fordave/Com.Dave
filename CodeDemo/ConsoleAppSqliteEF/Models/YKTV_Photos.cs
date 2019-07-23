namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_Photos
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        [StringLength(50)]
        public string CaseId { get; set; }

        public long? PhotoType { get; set; }

        public DateTime? TakenTime { get; set; }

        public long? IsHavePhoto { get; set; }

        [MaxLength(2147483647)]
        public byte[] Data { get; set; }

        public short? IsUpload { get; set; }

        public long? AreaId { get; set; }

        public long? CreateUserId { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedUserId { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
