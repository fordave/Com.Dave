namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_BaseDistrict
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string areaID { get; set; }

        [StringLength(60)]
        public string area { get; set; }

        [StringLength(6)]
        public string father { get; set; }
    }
}
