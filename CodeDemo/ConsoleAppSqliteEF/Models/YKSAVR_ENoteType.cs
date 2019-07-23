namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ENoteType
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        public long? TypeId { get; set; }

        public long? TypeBelong { get; set; }
    }
}
