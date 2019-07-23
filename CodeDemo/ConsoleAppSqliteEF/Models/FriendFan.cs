namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FriendFan
    {
        public long Id { get; set; }

        public long? UserId { get; set; }

        [StringLength(50)]
        public string Nickname { get; set; }

        public long? FansUserId { get; set; }

        [StringLength(50)]
        public string FansNickname { get; set; }

        public long Enabled { get; set; }

        public long DeletionStateCode { get; set; }

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
