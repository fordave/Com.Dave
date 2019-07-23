namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKSAVR_DossierInside
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string DossierId { get; set; }

        [StringLength(50)]
        public string DossierName { get; set; }

        [StringLength(50)]
        public string DossierInsideId { get; set; }

        [StringLength(255)]
        public string DossierInsideName { get; set; }

        [StringLength(50)]
        public string DossierDepartment { get; set; }

        [StringLength(50)]
        public string DossierCase { get; set; }

        [StringLength(255)]
        public string DossierInquestPerson { get; set; }

        [StringLength(50)]
        public string DossierExamineApprovePerson { get; set; }

        [StringLength(50)]
        public string DossierRecordPerson { get; set; }

        public long? DossierFirstInquest { get; set; }

        [StringLength(50)]
        public string DossierWorkplace { get; set; }

        [StringLength(2147483647)]
        public string DossierDescription { get; set; }

        public long? DossierType { get; set; }

        public long? DossierTypeBelong { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(50)]
        public string InquestedName { get; set; }

        [StringLength(50)]
        public string InquestedSex { get; set; }

        [StringLength(50)]
        public string IquestedAge { get; set; }

        [StringLength(50)]
        public string InquestedNation { get; set; }

        [StringLength(50)]
        public string InquestedDuty { get; set; }

        [StringLength(50)]
        public string InquestedCompany { get; set; }

        [StringLength(50)]
        public string InquestedAddress { get; set; }

        [StringLength(2147483647)]
        public string InquestedDescription { get; set; }

        [StringLength(50)]
        public string InquestedUsedname { get; set; }

        public DateTime? InquestedBirthday { get; set; }

        [StringLength(50)]
        public string InquestedPolitycase { get; set; }

        [StringLength(50)]
        public string InquestedCultdegree { get; set; }

        [StringLength(50)]
        public string InquestedCertname { get; set; }

        [StringLength(50)]
        public string InquestedIdcard { get; set; }

        [StringLength(50)]
        public string InquestedResidaddr { get; set; }

        [StringLength(50)]
        public string InquestedPhone { get; set; }

        [StringLength(50)]
        public string InquestedParty { get; set; }

        [StringLength(50)]
        public string InquestedRelation { get; set; }

        [StringLength(50)]
        public string InquestedCounty { get; set; }

        public long? AreaId { get; set; }

        public long? UserId { get; set; }

        public long? RightGroupId { get; set; }

        public short? IsUpload { get; set; }

        [StringLength(50)]
        public string DossierFamily { get; set; }

        public long? InquestedIndex { get; set; }

        [StringLength(50)]
        public string dossier_index { get; set; }

        [StringLength(50)]
        public string dossier_police { get; set; }

        [StringLength(50)]
        public string police_name { get; set; }

        [StringLength(50)]
        public string police_no { get; set; }

        [StringLength(50)]
        public string police_idcard { get; set; }

        [StringLength(50)]
        public string inquested_index { get; set; }

        [StringLength(50)]
        public string inquested_type { get; set; }

        public long? IsDelete { get; set; }

        [StringLength(50)]
        public string CaseId { get; set; }

        public long OrganizeId { get; set; }

        [StringLength(50)]
        public string PoliceCaseId { get; set; }

        [StringLength(50)]
        public string FacePersonId { get; set; }
    }
}
