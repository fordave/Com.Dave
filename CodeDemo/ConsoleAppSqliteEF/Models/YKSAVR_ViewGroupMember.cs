namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ViewGroupMember
    {
        public long Id { get; set; }

        public long? ViewMemberId { get; set; }

        [StringLength(50)]
        public string ViewMemberName { get; set; }

        public long? ViewGroupId { get; set; }

        public long? DeviceId { get; set; }

        public long? ChannelDeviceIndex { get; set; }
    }
}
