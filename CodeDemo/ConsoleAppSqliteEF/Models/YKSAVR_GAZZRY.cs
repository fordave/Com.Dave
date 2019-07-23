namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_GAZZRY
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string CompanyId { get; set; }

        [StringLength(50)]
        public string DepartmentId { get; set; }

        public long? InnerUser { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Account { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Secretkey { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Spell { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Birthday { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string OICQ { get; set; }

        [StringLength(2147483647)]
        public string photo { get; set; }

        [StringLength(2147483647)]
        public string signature { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? ChangePasswordDate { get; set; }

        public long? OpenId { get; set; }

        public long? LogOnCount { get; set; }

        public DateTime? FirstVisit { get; set; }

        public DateTime? PreviousVisit { get; set; }

        public DateTime? LastVisit { get; set; }

        [StringLength(50)]
        public string AuditStatus { get; set; }

        [StringLength(50)]
        public string AuditUserId { get; set; }

        [StringLength(50)]
        public string AuditUserName { get; set; }

        public DateTime? AuditDateTime { get; set; }

        public long? Online { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public long? Enabled { get; set; }

        public long? SortCode { get; set; }

        [StringLength(50)]
        public string orgName { get; set; }

        [StringLength(50)]
        public string orgCode { get; set; }

        [StringLength(50)]
        public string regName { get; set; }

        [StringLength(50)]
        public string regCode { get; set; }

        public long? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }

        [StringLength(50)]
        public string cardId { get; set; }

        public DateTime? SendCardDate { get; set; }
    }
}
