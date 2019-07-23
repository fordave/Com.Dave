namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkFlowPermissionScope")]
    public partial class WorkFlowPermissionScope
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string ResourceCategory { get; set; }

        [StringLength(50)]
        public string ResourceId { get; set; }

        [StringLength(50)]
        public string TargetCategory { get; set; }

        [StringLength(50)]
        public string TargetId { get; set; }

        public long? PermissionId { get; set; }

        public long? ContainChild { get; set; }

        [StringLength(200)]
        public string PermissionConstraint { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public short Enabled { get; set; }

        public short DeletionStateCode { get; set; }

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
