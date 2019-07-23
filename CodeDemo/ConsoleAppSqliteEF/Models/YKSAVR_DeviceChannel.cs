namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_DeviceChannel
    {
        public long Id { get; set; }

        public long DeviceId { get; set; }

        [StringLength(50)]
        public string ChannelName { get; set; }

        public short? ChannelIndex { get; set; }

        public short? ChannelDeviceIndex { get; set; }

        public short? Record { get; set; }

        public short? PTZ { get; set; }

        public short? AutoRecord { get; set; }

        public short? Audio { get; set; }
    }
}
