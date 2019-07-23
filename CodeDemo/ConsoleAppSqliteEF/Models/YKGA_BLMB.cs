namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_BLMB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(200)]
        public string blmc { get; set; }

        public long? bllx { get; set; }

        [MaxLength(2147483647)]
        public byte[] blwj { get; set; }

        public long? blwjlx { get; set; }

        public long? blfl { get; set; }
    }
}
