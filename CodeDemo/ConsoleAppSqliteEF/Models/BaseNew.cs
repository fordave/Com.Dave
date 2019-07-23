namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BaseNew
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string FolderId { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(200)]
        public string Source { get; set; }

        [StringLength(500)]
        public string Introduction { get; set; }

        [StringLength(500)]
        public string Keywords { get; set; }

        [StringLength(2147483647)]
        public string Contents { get; set; }

        public long ReadCount { get; set; }

        public long FileSize { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        public long? HomePage { get; set; }

        public long? SubPage { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        [StringLength(20)]
        public string AuditStatus { get; set; }

        public long Enabled { get; set; }

        public long? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public long DeletionStateCode { get; set; }

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
