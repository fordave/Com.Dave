namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessCard")]
    public partial class BusinessCard
    {
        [StringLength(40)]
        public string Id { get; set; }

        [StringLength(40)]
        public string FullName { get; set; }

        [StringLength(200)]
        public string Company { get; set; }

        [StringLength(40)]
        public string Title { get; set; }

        [StringLength(40)]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Postalcode { get; set; }

        [StringLength(40)]
        public string Mobile { get; set; }

        [StringLength(40)]
        public string Address { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(40)]
        public string OfficePhone { get; set; }

        [StringLength(40)]
        public string QQ { get; set; }

        [StringLength(40)]
        public string Fax { get; set; }

        [StringLength(40)]
        public string Web { get; set; }

        [StringLength(40)]
        public string BankName { get; set; }

        [StringLength(40)]
        public string BankAccount { get; set; }

        [StringLength(40)]
        public string TaxAccount { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public long? Personal { get; set; }

        public long Enabled { get; set; }

        public long DeletionStateCode { get; set; }

        public long? SortCode { get; set; }

        public DateTime CreateOn { get; set; }

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
