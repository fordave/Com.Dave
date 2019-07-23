namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_PersonType
    {
        public long Id { get; set; }

        public long? PersonType { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long? AreaId { get; set; }

        public long? ShowIndex { get; set; }
    }
}
