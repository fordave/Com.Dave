namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseMessageRecent")]
    public partial class BaseMessageRecent
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string TargetCategory { get; set; }

        [StringLength(100)]
        public string TargetId { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
