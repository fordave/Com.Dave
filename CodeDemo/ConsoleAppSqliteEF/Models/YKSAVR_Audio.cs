namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_Audio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(50)]
        public string AudioId { get; set; }

        [StringLength(50)]
        public string DeviceChannelId { get; set; }

        [Column(TypeName = "real")]
        public double? MaxFre { get; set; }

        [Column(TypeName = "real")]
        public double? MinFre { get; set; }

        [Column(TypeName = "real")]
        public double? ReferenceRange { get; set; }

        [StringLength(256)]
        public string BeepIP { get; set; }

        public long? BeepPort { get; set; }

        public long? Reserve1 { get; set; }

        public long? Reserve2 { get; set; }
    }
}
