namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ServerRoom
    {
        public long Id { get; set; }

        public long AreaId { get; set; }

        public short ServerId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoomId { get; set; }
    }
}
