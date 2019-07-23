namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BaseContactDetail
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string ContactId { get; set; }

        [StringLength(40)]
        public string Category { get; set; }

        [StringLength(40)]
        public string ReceiverId { get; set; }

        [StringLength(40)]
        public string ReceiverRealName { get; set; }

        public long IsNew { get; set; }

        public long NewComment { get; set; }

        [StringLength(40)]
        public string LastViewIP { get; set; }

        [StringLength(40)]
        public string LastViewDate { get; set; }

        public long Enabled { get; set; }

        public long DeletionStateCode { get; set; }

        public long? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? CreateOn { get; set; }

        [StringLength(20)]
        public string CreateUserId { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(20)]
        public string ModifiedUserId { get; set; }

        [StringLength(20)]
        public string ModifiedBy { get; set; }
    }
}
