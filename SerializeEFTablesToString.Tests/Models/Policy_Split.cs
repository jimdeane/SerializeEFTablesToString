using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerializeEFTablesToString.Tests.Models
{
    public partial class Policy_Split
    {
        [Key]
        public int policy_split_id { get; set; }

        public decimal? amount { get; set; }

        public DateTime? date_created { get; set; }

        public int? payment_response_id { get; set; }

        public int? expected_premium_id { get; set; }

        [StringLength(20)]
        public string policy_number { get; set; }

        public int? expected_premium_component_id { get; set; }

        [Required]
        [StringLength(20)]
        public string split_type_code { get; set; }

        [Required]
        [StringLength(50)]
        public string product_code { get; set; }

        [Required]
        [StringLength(50)]
        public string product_component_code { get; set; }

        [Required]
        [StringLength(50)]
        public string product_option_code { get; set; }

        [StringLength(20)]
        public string product_option_split_category_code { get; set; }

        [Required]
        [StringLength(20)]
        public string risk_type_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_date { get; set; }

        [StringLength(50)]
        public string destination { get; set; }
    }
}
