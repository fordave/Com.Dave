namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_DeviceTypeChannelIndexMap
    {
        public long Id { get; set; }

        public long? DeviceTypeId { get; set; }

        public short? ChannelIndex { get; set; }

        public short? ChannelDeviceIndex { get; set; }
    }
}
