namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_ProcessMode
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? TypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Name { get; set; }

        public long? ShowIndex { get; set; }
    }
}
