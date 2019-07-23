namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKGA_VideoProcess
    {
        public long Id { get; set; }

        [StringLength(100)]
        public string wjid { get; set; }

        [StringLength(250)]
        public string wjmc { get; set; }

        public long? wjdx { get; set; }

        public DateTime? wjkssj { get; set; }

        public DateTime? wjjssj { get; set; }

        [StringLength(50)]
        public string jzbh { get; set; }

        [StringLength(512)]
        public string wjsm { get; set; }

        [StringLength(50)]
        public string rybh { get; set; }

        [StringLength(20)]
        public string wjlx { get; set; }

        [StringLength(20)]
        public string spbm { get; set; }

        [StringLength(20)]
        public string ypbm { get; set; }

        public long? splx { get; set; }

        public short? spqxd { get; set; }

        public long? DeviceId { get; set; }

        public long? Channel { get; set; }

        public long? RightGroupId { get; set; }

        public long? OrganizeId { get; set; }

        public long? UserId { get; set; }

        public long? AreaId { get; set; }

        public long? ServerId { get; set; }

        [StringLength(512)]
        public string FileSource { get; set; }

        [StringLength(512)]
        public string FileObject { get; set; }

        [StringLength(20)]
        public string DeviceVendor { get; set; }

        [StringLength(20)]
        public string DeviceType { get; set; }

        [StringLength(50)]
        public string DossierInsideId { get; set; }

        public short? IsStandard { get; set; }

        public short? IsUpload { get; set; }

        public short? IsDelete { get; set; }

        public short? Status { get; set; }
    }
}
