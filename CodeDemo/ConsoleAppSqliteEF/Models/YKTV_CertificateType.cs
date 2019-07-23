namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_CertificateType
    {
        public long Id { get; set; }

        public long? CertType { get; set; }

        [Required]
        [StringLength(50)]
        public string CertName { get; set; }

        public short? AutoScan { get; set; }

        public long? AreaId { get; set; }

        public long? ShowIndex { get; set; }
    }
}
