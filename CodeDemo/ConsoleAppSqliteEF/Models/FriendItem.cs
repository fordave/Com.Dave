namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FriendItem
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string TargetTable { get; set; }

        public long IsTree { get; set; }

        [Required]
        [StringLength(50)]
        public string UseItemCode { get; set; }

        [Required]
        [StringLength(50)]
        public string UseItemName { get; set; }

        [Required]
        [StringLength(50)]
        public string UseItemValue { get; set; }

        public long Enabled { get; set; }

        public long AllowEdit { get; set; }

        public long AllowDelete { get; set; }

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
