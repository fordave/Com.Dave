namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_RoomPoint
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomId { get; set; }

        public long Channel { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public short PointType { get; set; }

        [StringLength(250)]
        public string DefaultValue { get; set; }

        [StringLength(100)]
        public string Unit { get; set; }

        public short AlarmGrade { get; set; }

        [Column(TypeName = "real")]
        public double High { get; set; }

        [Column(TypeName = "real")]
        public double Low { get; set; }

        public short RoomCmd { get; set; }

        [StringLength(100)]
        public string Para1 { get; set; }

        [StringLength(100)]
        public string Para2 { get; set; }
    }
}
