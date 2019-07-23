namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_ReaderRoom
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string ReaderDeviceId { get; set; }

        [StringLength(50)]
        public string RoomId { get; set; }

        [StringLength(50)]
        public string RoomName { get; set; }

        public long? RoomType { get; set; }

        public long? ShowIndex { get; set; }

        public long? AreaId { get; set; }
    }
}
