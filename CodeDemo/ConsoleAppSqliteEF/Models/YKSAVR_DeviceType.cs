namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_DeviceType
    {
        public long Id { get; set; }

        public long? DeviceTypeId { get; set; }

        public long? VendorId { get; set; }

        [StringLength(50)]
        public string DeviceType { get; set; }

        [StringLength(50)]
        public string DeviceTypeName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public long? Port { get; set; }

        public short? ChannelNum { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
