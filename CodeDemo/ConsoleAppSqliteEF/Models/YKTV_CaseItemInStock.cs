namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_CaseItemInStock
    {
        public long Id { get; set; }

        public long ItemId { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseItem { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseId { get; set; }

        [Required]
        [StringLength(50)]
        public string CaseName { get; set; }

        [Required]
        [StringLength(255)]
        public string Feature { get; set; }

        public DateTime RecvTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Inquisitor { get; set; }

        [Required]
        [StringLength(50)]
        public string JudicialOrgan { get; set; }

        [Required]
        [StringLength(50)]
        public string PrevHolder { get; set; }

        [Required]
        [StringLength(50)]
        public string HolderInfo { get; set; }

        [Required]
        [StringLength(50)]
        public string StockPlace { get; set; }

        public short PhotoCount { get; set; }

        public DateTime ProcessTime { get; set; }

        [Required]
        [StringLength(50)]
        public string ProcessResult { get; set; }

        public long? AreaId { get; set; }

        public short? IsUpload { get; set; }

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
