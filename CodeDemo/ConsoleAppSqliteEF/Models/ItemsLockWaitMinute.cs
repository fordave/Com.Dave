namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemsLockWaitMinute")]
    public partial class ItemsLockWaitMinute
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }

        [StringLength(40)]
        public string ItemCode { get; set; }

        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(100)]
        public string ItemValue { get; set; }

        public short Enabled { get; set; }

        public short AllowEdit { get; set; }

        public short AllowDelete { get; set; }

        public short IsPublic { get; set; }

        public short DeletionStateCode { get; set; }

        public long? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime CreateOn { get; set; }

        [StringLength(20)]
        public string CreateUserId { get; set; }

        [StringLength(20)]
        public string CreateBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        [StringLength(20)]
        public string ModifiedUserId { get; set; }

        [StringLength(20)]
        public string ModifiedBy { get; set; }
    }
}
