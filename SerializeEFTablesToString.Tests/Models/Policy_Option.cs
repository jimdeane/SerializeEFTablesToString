using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerializeEFTablesToString.Tests.Models
{
    public partial class Policy_Option
    {
        [Key]
        public int policy_option_id { get; set; }

        public int? policy_component_id { get; set; }

        [StringLength(36)]
        public string policy_number { get; set; }

        [Required]
        [StringLength(50)]
        public string product_component_code { get; set; }

        [Required]
        [StringLength(50)]
        public string product_code { get; set; }

        [Required]
        [StringLength(50)]
        public string product_option_code { get; set; }

        [StringLength(20)]
        public string status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? status_change_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expected_start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_created { get; set; }

        public decimal? premium_amount { get; set; }

        public decimal? benefit_amount { get; set; }

        public int? retirement_age { get; set; }

        public int? quote_id { get; set; }

        public decimal? additional_premium_component { get; set; }

        public int? payment_frequency { get; set; }

        public decimal? sum_assured { get; set; }

        public decimal? insured_term { get; set; }

        public decimal? additional_nominal_charge { get; set; }

        public decimal? additional_multiplicative_charge { get; set; }

        public bool? smoker { get; set; }

        [StringLength(250)]
        public string occupation_class { get; set; }

        [Column(TypeName = "date")]
        public DateTime? requested_start_date { get; set; }

        public virtual Policy_Component Policy_Component { get; set; }
    }
}
