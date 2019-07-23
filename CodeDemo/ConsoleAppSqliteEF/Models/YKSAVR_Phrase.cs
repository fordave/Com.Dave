namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_Phrase
    {
        public long Id { get; set; }

        [StringLength(500)]
        public string Sentence { get; set; }

        public long? Type { get; set; }

        public long? TypeBelong { get; set; }

        public short? Flag { get; set; }

        public long? AreaId { get; set; }
    }
}
