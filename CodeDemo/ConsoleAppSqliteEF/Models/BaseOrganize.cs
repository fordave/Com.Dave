namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseOrganize")]
    public partial class BaseOrganize
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }

        [StringLength(50)]
        public string ParentName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string StandardName { get; set; }

        [StringLength(50)]
        public string StandardCode { get; set; }

        [StringLength(100)]
        public string QuickQuery { get; set; }

        [StringLength(50)]
        public string SimpleSpelling { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        [StringLength(100)]
        public string OuterPhone { get; set; }

        [StringLength(100)]
        public string InnerPhone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Postalcode { get; set; }

        public long? ProvinceId { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        public long? CityId { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public long? DistrictId { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        public long? StreetId { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string CompanyCode { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(50)]
        public string CostCenter { get; set; }

        [StringLength(50)]
        public string FinancialCenter { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        [StringLength(50)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        public long? Layer { get; set; }

        [StringLength(50)]
        public string JoiningMethods { get; set; }

        [StringLength(16)]
        public string Longitude { get; set; }

        [StringLength(16)]
        public string Latitude { get; set; }

        public short ContainChildNodes { get; set; }

        public short IsInnerOrganize { get; set; }

        public long? SortCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public short? DeletionStateCode { get; set; }

        public short Enabled { get; set; }

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

        public long OrganizeType { get; set; }

        public DateTime? EffectiveStartTime { get; set; }

        public DateTime? EffectiveEndTime { get; set; }

        public short EffectiveEnable { get; set; }
    }
}
