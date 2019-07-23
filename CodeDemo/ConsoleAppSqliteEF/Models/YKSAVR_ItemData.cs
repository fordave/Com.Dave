namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ItemData
    {
        public long Id { get; set; }

        [StringLength(20)]
        public string DataName { get; set; }

        public long? ItemIndex { get; set; }

        [StringLength(20)]
        public string ItemData { get; set; }

        public long? AreaId { get; set; }
    }
}
