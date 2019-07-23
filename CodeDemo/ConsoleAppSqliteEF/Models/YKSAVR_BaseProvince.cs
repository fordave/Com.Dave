namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_BaseProvince
    {
        public long Id { get; set; }

        [StringLength(6)]
        public string provinceID { get; set; }

        [StringLength(40)]
        public string province { get; set; }
    }
}
