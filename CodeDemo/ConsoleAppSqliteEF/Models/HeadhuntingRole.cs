namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HeadhuntingRole")]
    public partial class HeadhuntingRole
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string SystemId { get; set; }

        public long? OrganizeId { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(200)]
        public string Realname { get; set; }

        public long AllowEdit { get; set; }

        public long AllowDelete { get; set; }

        public long IsVisible { get; set; }

        public long? SortCode { get; set; }

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
