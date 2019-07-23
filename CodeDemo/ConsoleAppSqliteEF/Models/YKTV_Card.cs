namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_Card
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CardId { get; set; }

        [Required]
        [StringLength(50)]
        public string ECardId { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        public short? Status { get; set; }

        public long? ShowIndex { get; set; }

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

        [StringLength(50)]
        public string ECardId1 { get; set; }

        [StringLength(50)]
        public string ECardId2 { get; set; }

        [StringLength(50)]
        public string ECardId3 { get; set; }

        [StringLength(50)]
        public string IcCardId { get; set; }

        public long? CardType { get; set; }

        public long? ObjectType { get; set; }
    }
}
