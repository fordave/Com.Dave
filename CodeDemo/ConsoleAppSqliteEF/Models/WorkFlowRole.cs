namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkFlowRole")]
    public partial class WorkFlowRole
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

        public short AllowEdit { get; set; }

        public short AllowDelete { get; set; }

        public short IsVisible { get; set; }

        public long? SortCode { get; set; }

        public short DeletionStateCode { get; set; }

        public short Enabled { get; set; }

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
