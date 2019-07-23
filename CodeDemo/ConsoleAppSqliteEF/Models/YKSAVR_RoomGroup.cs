namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_RoomGroup
    {
        public long Id { get; set; }

        public long AreaId { get; set; }

        public long RoomGroupId { get; set; }

        [StringLength(2147483647)]
        public string RoomGroupName { get; set; }

        public short? ShowIndex { get; set; }
    }
}
