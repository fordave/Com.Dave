namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_BaseCity
    {
        public long Id { get; set; }

        [StringLength(6)]
        public string cityID { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(6)]
        public string father { get; set; }
    }
}
