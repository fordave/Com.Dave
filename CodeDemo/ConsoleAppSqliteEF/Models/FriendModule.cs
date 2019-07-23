namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FriendModule")]
    public partial class FriendModule
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(200)]
        public string ImagUrl { get; set; }

        [StringLength(50)]
        public string ImageIndex { get; set; }

        [StringLength(50)]
        public string SelectedImageIndex { get; set; }

        [StringLength(200)]
        public string NavigateUrl { get; set; }

        [StringLength(100)]
        public string Target { get; set; }

        [StringLength(100)]
        public string FormName { get; set; }

        [StringLength(100)]
        public string AssemblyName { get; set; }

        [StringLength(50)]
        public string PermissionItemCode { get; set; }

        [StringLength(500)]
        public string PermissionScopeTables { get; set; }

        public long? SortCode { get; set; }

        public long Enabled { get; set; }

        public long DeletionStateCode { get; set; }

        public long? IsMenu { get; set; }

        public long IsPublic { get; set; }

        public long Expand { get; set; }

        public long IsScope { get; set; }

        public long IsVisible { get; set; }

        public DateTime? LastCall { get; set; }

        public long AllowEdit { get; set; }

        public long AllowDelete { get; set; }

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
