namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_RoomReservation
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string RoomId { get; set; }

        [StringLength(50)]
        public string PersonId { get; set; }

        [StringLength(50)]
        public string BookTime { get; set; }

        public DateTime? BeginUseTime { get; set; }

        public DateTime? EndUseTime { get; set; }

        public short? Status { get; set; }
    }
}
