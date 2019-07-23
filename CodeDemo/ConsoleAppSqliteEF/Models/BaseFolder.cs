namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseFolder")]
    public partial class BaseFolder
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string ParentId { get; set; }

        [Required]
        [StringLength(200)]
        public string FolderName { get; set; }

        [StringLength(40)]
        public string StateCode { get; set; }

        public long SortCode { get; set; }

        public long AllowEdit { get; set; }

        public long AllowDelete { get; set; }

        public long? IsPublic { get; set; }

        public long Enabled { get; set; }

        public long DeletionStateCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime? CreateOn { get; set; }

        [StringLength(40)]
        public string CreateUserId { get; set; }

        [StringLength(40)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(40)]
        public string ModifiedUserId { get; set; }

        [StringLength(40)]
        public string ModifiedBy { get; set; }
    }
}
