namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_Dossier
    {
        public long Id { get; set; }

        public long DossierId { get; set; }

        [StringLength(255)]
        public string DossierName { get; set; }

        public long? DossierNum { get; set; }

        [StringLength(50)]
        public string DossierCase { get; set; }

        [StringLength(50)]
        public string DossierDepartment { get; set; }

        [StringLength(50)]
        public string DossierInquestPerson { get; set; }

        [StringLength(50)]
        public string DossierExamineApprovePerson { get; set; }

        [StringLength(50)]
        public string DossierRecordPerson { get; set; }

        [StringLength(50)]
        public string InquestedSex { get; set; }

        [StringLength(50)]
        public string IquestedAge { get; set; }

        [StringLength(50)]
        public string InquestedNation { get; set; }

        [StringLength(50)]
        public string InquestedCultdegree { get; set; }

        [StringLength(50)]
        public string InquestedResidaddr { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public long? AreaId { get; set; }

        public long? RightGroupId { get; set; }

        public long? UserId { get; set; }

        public short? IsUpload { get; set; }

        public long? IsDelete { get; set; }

        [StringLength(50)]
        public string CaseId { get; set; }

        public long OrganizeId { get; set; }

        [StringLength(50)]
        public string PoliceCaseId { get; set; }

        [StringLength(50)]
        public string PersonId { get; set; }
    }
}
