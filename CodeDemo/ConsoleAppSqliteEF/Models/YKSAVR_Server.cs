namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_Server
    {
        public long Id { get; set; }

        public long AreaId { get; set; }

        public short? ServerId { get; set; }

        public long ServerTypeId { get; set; }

        [StringLength(50)]
        public string ServerName { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        public long? Port { get; set; }
    }
}
