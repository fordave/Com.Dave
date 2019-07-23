namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserScore")]
    public partial class BaseUserScore
    {
        public long Id { get; set; }

        public long? UserId { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        public long? Score { get; set; }

        [StringLength(20)]
        public string FunctionCode { get; set; }

        [StringLength(50)]
        public string ObjectId { get; set; }

        [StringLength(200)]
        public string Contents { get; set; }

        public long DeletionStateCode { get; set; }

        public long Enabled { get; set; }

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
