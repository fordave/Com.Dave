namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_Department
    {
        public long Id { get; set; }

        public long AreaId { get; set; }

        public long DepartmentId { get; set; }

        [StringLength(50)]
        public string DepartName { get; set; }

        public short? ShowIndex { get; set; }
    }
}
