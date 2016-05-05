using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SerializeEFTablesToString.Tests.Models;

namespace SerializeEFTablesToStringTests.Models
{
    public partial class Policy_Component
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Policy_Component()
        {
            Party_Role = new HashSet<Party_Role>();
            Policy_Option = new HashSet<Policy_Option>();
            Underwriting_Decision_Evidence_Code = new HashSet<Underwriting_Decision_Evidence_Code>();
        }

        [Key]
        public int policy_component_id { get; set; }

        [Required]
        [StringLength(50)]
        public string product_code { get; set; }

        [Required]
        [StringLength(36)]
        public string policy_number { get; set; }

        public int policy_component_sequence { get; set; }

        [Required]
        [StringLength(50)]
        public string product_component_code { get; set; }

        [Required]
        [StringLength(20)]
        public string risk_type_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expected_start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        [StringLength(80)]
        public string status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? status_change_date { get; set; }

        public int? count_of_premiums { get; set; }

        public int? count_of_arrears { get; set; }

        public int? previous_policy_component_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_created { get; set; }

        [Column(TypeName = "date")]
        public DateTime? effective_date_on_status_change_trigger { get; set; }

        [StringLength(100)]
        public string beneficiary_type_code { get; set; }

        public int? last_usi_id { get; set; }

        public int? entry_age { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Party_Role> Party_Role { get; set; }

        public virtual Policy Policy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policy_Option> Policy_Option { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Underwriting_Decision_Evidence_Code> Underwriting_Decision_Evidence_Code { get; set; }
    }
}
