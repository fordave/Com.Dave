namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_Vendor
    {
        public long Id { get; set; }

        public long? VendorId { get; set; }

        [StringLength(50)]
        public string VendorName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
