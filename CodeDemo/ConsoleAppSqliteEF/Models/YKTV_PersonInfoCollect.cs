namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_PersonInfoCollect
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseId { get; set; }

        [Required]
        [StringLength(50)]
        public string Collector { get; set; }

        public DateTime? Entry { get; set; }

        public DateTime? Leave { get; set; }

        public long? Height { get; set; }

        public long? Weight { get; set; }

        public short? FingerPrint { get; set; }

        [StringLength(50)]
        public string FPNo { get; set; }

        public short? PalmPrint { get; set; }

        [StringLength(50)]
        public string PPNo { get; set; }

        public short? FootPrint { get; set; }

        [StringLength(50)]
        public string FTNo { get; set; }

        public short? DNA { get; set; }

        [StringLength(50)]
        public string DNANo { get; set; }

        public short? TMTZ { get; set; }

        [StringLength(50)]
        public string TMTZNo { get; set; }

        public short? Urine { get; set; }

        [StringLength(50)]
        public string UrineNo { get; set; }

        public short? DrunkCheck { get; set; }

        [StringLength(50)]
        public string DrunkCheckNo { get; set; }

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

        public long? isruku { get; set; }

        public long? ischeck { get; set; }

        public long? iscaiji { get; set; }
    }
}
