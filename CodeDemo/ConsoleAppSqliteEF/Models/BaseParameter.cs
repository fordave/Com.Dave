namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseParameter")]
    public partial class BaseParameter
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string CategoryCode { get; set; }

        [StringLength(40)]
        public string ParameterId { get; set; }

        [StringLength(40)]
        public string ParameterCode { get; set; }

        [StringLength(2000)]
        public string ParameterContent { get; set; }

        public long Worked { get; set; }

        public long Enabled { get; set; }

        public long? DeletionStateCode { get; set; }

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
