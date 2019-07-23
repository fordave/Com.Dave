namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_RoomChannel
    {
        public long Id { get; set; }

        public long DeviceId { get; set; }

        public short ChannelDeviceIndex { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomId { get; set; }

        public short? ShowIndex { get; set; }
    }
}
