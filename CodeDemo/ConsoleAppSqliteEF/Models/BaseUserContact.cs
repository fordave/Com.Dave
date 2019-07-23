namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaseUserContact")]
    public partial class BaseUserContact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public long EmailValiated { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public long? MobileValiated { get; set; }

        [StringLength(50)]
        public string ShortNumber { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Extension { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string WW { get; set; }

        [StringLength(50)]
        public string WeChat { get; set; }

        public long WeChatValiated { get; set; }

        [StringLength(50)]
        public string YiXin { get; set; }

        public long YiXinValiated { get; set; }

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
