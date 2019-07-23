namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_ReaderChannel
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ReaderDeviceId { get; set; }

        public long DeviceId { get; set; }

        public long ChannelDeviceIndex { get; set; }

        public long? ShowIndex { get; set; }

        public long? AreaId { get; set; }

        public long? TypeId { get; set; }

        [StringLength(128)]
        public string StreamHead { get; set; }

        [StringLength(128)]
        public string StreamBody { get; set; }
    }
}
