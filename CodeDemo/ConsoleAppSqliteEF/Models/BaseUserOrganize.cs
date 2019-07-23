namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserOrganize")]
    public partial class BaseUserOrganize
    {
        public long Id { get; set; }

        public long? UserId { get; set; }

        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string SubCompanyId { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string SubDepartmentId { get; set; }

        [StringLength(50)]
        public string WorkgroupId { get; set; }

        public long Enabled { get; set; }

        public long? DeletionStateCode { get; set; }

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
