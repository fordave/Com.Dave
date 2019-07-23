namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_Device
    {
        public long Id { get; set; }

        public long AreaId { get; set; }

        public long DeviceId { get; set; }

        public short? DeviceTypeId { get; set; }

        [StringLength(50)]
        public string DeviceName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public long? Port { get; set; }

        public short? ChannelNum { get; set; }

        public long StorageServerId { get; set; }

        public long MrServerId { get; set; }

        public long RTSPPort { get; set; }
    }
}
