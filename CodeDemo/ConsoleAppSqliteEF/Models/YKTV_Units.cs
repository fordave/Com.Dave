namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_Units
    {
        public long Id { get; set; }

        public long? TypeId { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public long? ShowIndex { get; set; }
    }
}
