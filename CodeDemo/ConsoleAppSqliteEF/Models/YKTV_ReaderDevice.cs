namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_ReaderDevice
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ReaderDeviceId { get; set; }

        public long? ReaderDeviceTypeId { get; set; }

        public long? ReaderDeviceFuction { get; set; }

        [StringLength(50)]
        public string ReaderDeviceName { get; set; }

        public long? ReaderDeviceAddress { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        public long? Port { get; set; }

        public long? AreaId { get; set; }

        [StringLength(255)]
        public string Reserve { get; set; }

        public long? Param1 { get; set; }

        public long? Param2 { get; set; }

        public long? Param3 { get; set; }

        public long? Param4 { get; set; }

        public long? Param5 { get; set; }
    }
}
