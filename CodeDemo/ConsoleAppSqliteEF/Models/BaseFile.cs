namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseFile")]
    public partial class BaseFile
    {
        public long Id { get; set; }

        [StringLength(40)]
        public string FolderId { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        [StringLength(500)]
        public string ImageUrl { get; set; }

        [MaxLength(2147483647)]
        public byte[] Contents { get; set; }

        public long ReadCount { get; set; }

        public long FileSize { get; set; }

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
