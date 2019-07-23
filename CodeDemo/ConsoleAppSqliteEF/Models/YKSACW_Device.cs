namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSACW_Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long DeviceID { get; set; }

        public long ParentDeviceID { get; set; }

        public long? KuID { get; set; }

        [Required]
        [StringLength(50)]
        public string DeviceName { get; set; }

        [StringLength(255)]
        public string LongDeviceName { get; set; }

        public long LieCount { get; set; }

        public long LieID { get; set; }

        public long LieRowCount { get; set; }

        public long LieRowID { get; set; }

        public long JieCount { get; set; }

        public long JieID { get; set; }

        public long LieColCount { get; set; }

        public long LieColID { get; set; }

        public long UseStyle { get; set; }

        public long UseCount { get; set; }

        public long UseStatus { get; set; }

        [StringLength(50)]
        public string ReaderDeviceId { get; set; }
    }
}
