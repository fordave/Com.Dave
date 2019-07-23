namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_DossierItem
    {
        public long Id { get; set; }

        public long? ItemIndex { get; set; }

        [StringLength(20)]
        public string ItemName { get; set; }

        public long? ItemBelong { get; set; }

        public long? AreaId { get; set; }
    }
}
