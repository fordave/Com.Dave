namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserAddress")]
    public partial class BaseUserAddress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string ProvinceId { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string CityId { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string DistrictId { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(400)]
        public string Address { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(50)]
        public string DeliverCategory { get; set; }

        public long? SortCode { get; set; }

        public long? DeletionStateCode { get; set; }

        public long? Enabled { get; set; }

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
