namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ServerType
    {
        public long Id { get; set; }

        public long? ServerTypeId { get; set; }

        [StringLength(50)]
        public string ServerType { get; set; }

        [StringLength(50)]
        public string ServerTypeName { get; set; }

        public long? DefaultPort { get; set; }
    }
}
