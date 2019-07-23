namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_BLCYY
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? lx { get; set; }

        public long? PId { get; set; }

        [StringLength(200)]
        public string nr { get; set; }

        public DateTime? lrsj { get; set; }
    }
}
