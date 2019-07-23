namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_PersonRoomBind
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? AreaId { get; set; }

        [StringLength(64)]
        public string RoomId { get; set; }

        [StringLength(64)]
        public string PersonId { get; set; }

        public long? Status { get; set; }

        public long? Reserver { get; set; }

        public DateTime? AddTime { get; set; }

        [StringLength(64)]
        public string PersonName { get; set; }
    }
}
