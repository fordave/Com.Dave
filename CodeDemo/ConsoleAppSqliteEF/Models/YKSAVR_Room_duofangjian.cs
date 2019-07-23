namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YKSAVR_Room-duofangjian")]
    public partial class YKSAVR_Room_duofangjian
    {
        public long Id { get; set; }

        public long AreaId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomId { get; set; }

        [StringLength(50)]
        public string RoomName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        public short? Status { get; set; }

        public short? Type { get; set; }

        public long? GroupNo { get; set; }

        public DateTime? BeginWork { get; set; }

        public DateTime? EndWork { get; set; }

        public DateTime? BeginReserve { get; set; }

        public DateTime? EndReserve { get; set; }

        public short? ShowIndex { get; set; }

        public short LEDStatus { get; set; }

        [StringLength(50)]
        public string PersonId { get; set; }
    }
}
