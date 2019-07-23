namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_ViewGroup
    {
        public long Id { get; set; }

        public long? ViewGroupId { get; set; }

        [StringLength(50)]
        public string ViewGroupName { get; set; }

        public long ShowIndex { get; set; }
    }
}
