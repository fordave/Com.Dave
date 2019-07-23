namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_AreaBind
    {
        public long Id { get; set; }

        public long? AreaId { get; set; }

        [StringLength(64)]
        public string dwbh { get; set; }

        [StringLength(64)]
        public string bmbh { get; set; }

        [StringLength(64)]
        public string qybh { get; set; }

        [StringLength(256)]
        public string mc { get; set; }
    }
}
