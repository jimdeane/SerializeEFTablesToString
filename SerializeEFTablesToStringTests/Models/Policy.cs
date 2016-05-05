using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SerializeEFTablesToString.Tests.Models;

namespace SerializeEFTablesToStringTests.Models
{
    [Table("Policy")]
    public partial class Policy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Policy()
        {
            Party_Role = new HashSet<Party_Role>();
            Policy_Component = new HashSet<Policy_Component>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int policy_id { get; set; }

        [Key]
        [StringLength(36)]
        public string policy_number { get; set; }

        [StringLength(50)]
        public string product_code { get; set; }

        [StringLength(50)]
        public string policy_status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expected_start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public int? count_of_consecutive_rejections { get; set; }

        public int? count_of_premiums { get; set; }

        [StringLength(10)]
        public string comm_party_code { get; set; }

        [StringLength(10)]
        public string branch_code { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(15)]
        public string initials { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string id_number { get; set; }

        [StringLength(20)]
        public string marital_status { get; set; }

        [StringLength(50)]
        public string postal_line_1 { get; set; }

        [StringLength(50)]
        public string postal_line_2 { get; set; }

        [StringLength(50)]
        public string postal_suburb { get; set; }

        [StringLength(50)]
        public string postal_city { get; set; }

        [StringLength(20)]
        public string postal_code { get; set; }

        [StringLength(50)]
        public string residential_line_1 { get; set; }

        [StringLength(50)]
        public string residential_line_2 { get; set; }

        [StringLength(50)]
        public string residential_suburb { get; set; }

        [StringLength(50)]
        public string residential_city { get; set; }

        [StringLength(20)]
        public string residential_code { get; set; }

        [StringLength(20)]
        public string telephone_home { get; set; }

        [StringLength(20)]
        public string telephone_work { get; set; }

        [StringLength(20)]
        public string telephone_cell { get; set; }

        [StringLength(20)]
        public string telephone_fax { get; set; }

        [Column(TypeName = "date")]
        public DateTime? requested_start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_birth { get; set; }

        [StringLength(50)]
        public string employer { get; set; }

        public decimal? total_monthly_income { get; set; }

        public int? deduction_day { get; set; }

        [StringLength(20)]
        public string bank_name { get; set; }

        [StringLength(20)]
        public string bank_branch_name { get; set; }

        [StringLength(20)]
        public string bank_branch_code { get; set; }

        [StringLength(255)]
        public string bank_account_name { get; set; }

        [StringLength(20)]
        public string bank_account_number { get; set; }

        [StringLength(20)]
        public string bank_account_type { get; set; }

        [StringLength(50)]
        public string account_holder_id_number { get; set; }

        [StringLength(20)]
        public string account_holder_telephone_number { get; set; }

        [StringLength(50)]
        public string account_holder_address_1 { get; set; }

        [StringLength(50)]
        public string account_holder_address_2 { get; set; }

        [StringLength(50)]
        public string account_holder_address_suburb { get; set; }

        [StringLength(50)]
        public string account_holder_address_city { get; set; }

        [StringLength(20)]
        public string account_holder_address_code { get; set; }

        [StringLength(20)]
        public string persal_initials { get; set; }

        [StringLength(50)]
        public string persal_surname { get; set; }

        [StringLength(50)]
        public string persal_number { get; set; }

        [StringLength(20)]
        public string persal_organisation_code { get; set; }

        [StringLength(20)]
        public string persal_paypoint_code { get; set; }

        public int? count_of_consecutive_unpaids { get; set; }

        [Column(TypeName = "date")]
        public DateTime? policy_status_changed_date { get; set; }

        [StringLength(20)]
        public string upfront_commission { get; set; }

        public int? sp_newbustask_id { get; set; }

        [StringLength(80)]
        public string comm_party_display_name { get; set; }

        [StringLength(50)]
        public string maiden_name { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(15)]
        public string gender { get; set; }

        [StringLength(50)]
        public string passport_number { get; set; }

        public decimal? debit_order_premium_captured { get; set; }

        [StringLength(20)]
        public string account_holder_fax_number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_account_holder_signature { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_insured_signature_debit_order { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_insured_signature_persal { get; set; }

        public decimal? persal_premium_captured { get; set; }

        [StringLength(50)]
        public string account_holder_passport_number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_captured { get; set; }

        [StringLength(500)]
        public string comment { get; set; }

        [StringLength(20)]
        public string form_application_ref { get; set; }

        [StringLength(30)]
        public string collection_method_code { get; set; }

        [StringLength(30)]
        public string collection_method_class_code { get; set; }

        [StringLength(50)]
        public string taken_over_from { get; set; }

        [StringLength(30)]
        public string bank_account_bic { get; set; }

        [StringLength(30)]
        public string bank_account_iban { get; set; }

        public int? underwriting_decision_type_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? underwriting_decision_date { get; set; }

        public string underwriting_decision_reason { get; set; }

        [Column(TypeName = "date")]
        public DateTime? postpone_to_date { get; set; }

        public int? payment_frequency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Party_Role> Party_Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policy_Component> Policy_Component { get; set; }
    }
}
