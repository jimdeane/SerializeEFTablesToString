using System.ComponentModel.DataAnnotations;

namespace SerializeEFTablesToString.Tests.Models
{
    public partial class Underwriting_Decision_Evidence_Code
    {
        [Key]
        public int uw_decision_evidence_code_id { get; set; }

        public int? uw_decision_id { get; set; }

        [StringLength(50)]
        public string evidence_code { get; set; }

        [StringLength(1000)]
        public string evidence_text { get; set; }

        public decimal? additional_premium { get; set; }

        public decimal? additional_rate_per_mil { get; set; }

        public decimal? reduction_in_benefit { get; set; }

        public int? policy_component_id { get; set; }

        public virtual Policy_Component Policy_Component { get; set; }

        public virtual Underwriting_Decision Underwriting_Decision { get; set; }
    }
}
