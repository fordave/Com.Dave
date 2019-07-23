namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_Belongings
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        [StringLength(50)]
        public string CaseId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? Quantity { get; set; }

        public long? UnitType { get; set; }

        [StringLength(255)]
        public string Feature { get; set; }

        [StringLength(50)]
        public string VBNo { get; set; }

        [StringLength(50)]
        public string LockerNo { get; set; }

        [StringLength(255)]
        public string Misc { get; set; }

        [StringLength(50)]
        public string Mode { get; set; }

        public DateTime? ProcessDate { get; set; }

        [StringLength(2147483647)]
        public string Note { get; set; }

        [StringLength(50)]
        public string Inquisitor { get; set; }

        [StringLength(50)]
        public string Witness { get; set; }

        public long? AreaId { get; set; }

        public short? IsTakeAway { get; set; }

        public short? IsUpload { get; set; }

        public long? CreateUserId { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedUserId { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public long? SheAn { get; set; }
    }
}
