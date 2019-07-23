namespace ConsoleAppSqliteEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YKTV_PersonInCase
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        [StringLength(50)]
        public string CaseId { get; set; }

        [StringLength(50)]
        public string CardId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? Sex { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string CertId { get; set; }

        public short? CertType { get; set; }

        [StringLength(50)]
        public string RegPlace { get; set; }

        [StringLength(50)]
        public string Residence { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string Employer { get; set; }

        public DateTime? TimeGiven { get; set; }

        public short? IsLeave { get; set; }

        [StringLength(50)]
        public string CaseName { get; set; }

        public long? PersonType { get; set; }

        [StringLength(255)]
        public string ArriveCause { get; set; }

        public DateTime? Arrival { get; set; }

        public DateTime? Leave { get; set; }

        [StringLength(50)]
        public string Inquisitor { get; set; }

        [StringLength(50)]
        public string JudicialOrgan { get; set; }

        [StringLength(2147483647)]
        public string Note { get; set; }

        public short? IsUpload { get; set; }

        public long? AreaId { get; set; }

        public long? CreateUserId { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedUserId { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(50)]
        public string bary { get; set; }

        [StringLength(128)]
        public string badw { get; set; }

        public DateTime? rylslksj { get; set; }

        [StringLength(128)]
        public string rylslkyy { get; set; }

        public DateTime? ryfhsj { get; set; }

        [StringLength(50)]
        public string wplqrxm { get; set; }

        [StringLength(50)]
        public string wplqrsfzhm { get; set; }

        [StringLength(50)]
        public string wplqsj { get; set; }

        [StringLength(50)]
        public string zzlkyy { get; set; }

        public long? wpfhzt { get; set; }

        [StringLength(256)]
        public string wpfhjz { get; set; }

        [StringLength(128)]
        public string wsbh { get; set; }

        [StringLength(128)]
        public string tyr { get; set; }

        [StringLength(128)]
        public string tsr { get; set; }

        [StringLength(128)]
        public string anyou { get; set; }

        [StringLength(128)]
        public string jqbh { get; set; }

        [StringLength(128)]
        public string gabary1 { get; set; }

        [StringLength(128)]
        public string gabary2 { get; set; }

        public long? PersonObject { get; set; }

        public DateTime? rylslksj1 { get; set; }

        public DateTime? ryfhsj1 { get; set; }

        [StringLength(128)]
        public string rylslkyy1 { get; set; }

        [StringLength(128)]
        public string tyr1 { get; set; }

        [StringLength(128)]
        public string spry1 { get; set; }

        public DateTime? rylslksj2 { get; set; }

        public DateTime? ryfhsj2 { get; set; }

        [StringLength(128)]
        public string rylslkyy2 { get; set; }

        [StringLength(128)]
        public string tyr2 { get; set; }

        [StringLength(128)]
        public string spry2 { get; set; }

        public DateTime? rylslksj3 { get; set; }

        public DateTime? ryfhsj3 { get; set; }

        [StringLength(128)]
        public string rylslkyy3 { get; set; }

        [StringLength(128)]
        public string tyr3 { get; set; }

        [StringLength(128)]
        public string spry3 { get; set; }
    }
}
