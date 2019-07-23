namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OptionItemsOilDataSource")]
    public partial class OptionItemsOilDataSource
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }

        [StringLength(40)]
        public string ItemCode { get; set; }

        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(100)]
        public string ItemValue { get; set; }

        public long Enabled { get; set; }

        public long AllowEdit { get; set; }

        public long AllowDelete { get; set; }

        public long IsPublic { get; set; }

        public long DeletionStateCode { get; set; }

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
