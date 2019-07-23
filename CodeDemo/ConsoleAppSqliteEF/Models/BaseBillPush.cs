namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseBillPush")]
    public partial class BaseBillPush
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string BillCode { get; set; }

        [StringLength(50)]
        public string PushCategory { get; set; }

        [StringLength(50)]
        public string PushTarget { get; set; }

        [StringLength(50)]
        public string PushTime { get; set; }

        public decimal? SubscriptionCategory { get; set; }

        [StringLength(50)]
        public string SubscriptionSource { get; set; }

        public decimal? SubscriptionStatus { get; set; }

        public DateTime? CreateOn { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }
    }
}
