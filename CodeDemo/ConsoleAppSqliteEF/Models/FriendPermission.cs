namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FriendPermission")]
    public partial class FriendPermission
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string ResourceCategory { get; set; }

        [StringLength(50)]
        public string ResourceId { get; set; }

        [StringLength(50)]
        public string PermissionId { get; set; }

        [StringLength(200)]
        public string PermissionConstraint { get; set; }

        public long? Enabled { get; set; }

        public long DeletionStateCode { get; set; }

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
