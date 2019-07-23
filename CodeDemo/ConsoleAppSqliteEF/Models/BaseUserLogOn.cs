namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserLogOn")]
    public partial class BaseUserLogOn
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(100)]
        public string UserPassword { get; set; }

        [Required]
        [StringLength(50)]
        public string OpenId { get; set; }

        public DateTime? AllowStartTime { get; set; }

        public DateTime? AllowEndTime { get; set; }

        public DateTime? LockStartDate { get; set; }

        public DateTime? LockEndDate { get; set; }

        public DateTime? FirstVisit { get; set; }

        public DateTime? PreviousVisit { get; set; }

        public DateTime? LastVisit { get; set; }

        public DateTime? ChangePasswordDate { get; set; }

        public long LogOnCount { get; set; }

        [StringLength(20)]
        public string Salt { get; set; }

        public DateTime? OpenIdTimeout { get; set; }

        public short? MultiUserLogin { get; set; }

        public long ShowCount { get; set; }

        public long PasswordErrorCount { get; set; }

        public short UserOnLine { get; set; }

        public short CheckIPAddress { get; set; }

        [StringLength(50)]
        public string VerificationCode { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string MACAddress { get; set; }

        [StringLength(50)]
        public string Question { get; set; }

        [StringLength(200)]
        public string AnswerQuestion { get; set; }

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

        public virtual BaseUser BaseUser { get; set; }
    }
}
