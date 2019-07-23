namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseContact")]
    public partial class BaseContact
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string ParentId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(400)]
        public string Contents { get; set; }

        [StringLength(40)]
        public string Priority { get; set; }

        public long? SendCount { get; set; }

        public long? ReadCount { get; set; }

        public long? ReplyCount { get; set; }

        public long? IsOpen { get; set; }

        [StringLength(40)]
        public string CommentUserId { get; set; }

        [StringLength(40)]
        public string CommentUserRealName { get; set; }

        public DateTime? CommentDate { get; set; }

        public long? DeletionStateCode { get; set; }

        public long? Enabled { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public long? SortCode { get; set; }

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
