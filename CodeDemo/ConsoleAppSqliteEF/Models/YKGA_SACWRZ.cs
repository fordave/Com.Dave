namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_SACWRZ
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(64)]
        public string czrmc { get; set; }

        [StringLength(64)]
        public string czrnc { get; set; }

        [StringLength(64)]
        public string czrbh { get; set; }

        [StringLength(64)]
        public string czrjh { get; set; }

        public long? czrid { get; set; }

        public DateTime? czsj { get; set; }

        [StringLength(64)]
        public string czb { get; set; }

        public long? czbId { get; set; }

        [StringLength(64)]
        public string sjbh { get; set; }

        [StringLength(64)]
        public string czlx { get; set; }

        [StringLength(128)]
        public string czsm { get; set; }

        [StringLength(128)]
        public string MD5 { get; set; }
    }
}
