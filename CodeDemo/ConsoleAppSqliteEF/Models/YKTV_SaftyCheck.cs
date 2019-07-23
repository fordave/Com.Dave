namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_SaftyCheck
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        [StringLength(50)]
        public string CaseId { get; set; }

        public DateTime? Entry { get; set; }

        public DateTime? Leave { get; set; }

        [StringLength(50)]
        public string Inspector { get; set; }

        [StringLength(50)]
        public string InspectionType { get; set; }

        [StringLength(50)]
        public string SelfDesc { get; set; }

        [StringLength(50)]
        public string Specials { get; set; }

        [StringLength(50)]
        public string Injury { get; set; }

        [StringLength(50)]
        public string Property { get; set; }

        [StringLength(50)]
        public string Inquiry { get; set; }

        [StringLength(50)]
        public string Misc { get; set; }

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
