using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestAsp.NetMvcFluentModelBinding.Models;

namespace SerializeEFTablesToString.Tests.Models
{
    [Table("Party")]
    public partial class Party
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Party()
        {
            Party_Role = new HashSet<Party_Role>();
            Underwriting_Decision = new HashSet<Underwriting_Decision>();
            Users = new HashSet<User>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int party_row_id { get; set; }

        [Key]
        [StringLength(255)]
        public string party_unique_ref { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        [StringLength(20)]
        public string initials { get; set; }

        [Required]
        [StringLength(50)]
        public string firstname { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(20)]
        public string marital_status { get; set; }

        [StringLength(15)]
        public string gender { get; set; }

        [StringLength(50)]
        public string maiden_name { get; set; }

        [StringLength(50)]
        public string id_number { get; set; }

        [StringLength(50)]
        public string passport_number { get; set; }

        [StringLength(50)]
        public string postal_line1 { get; set; }

        [StringLength(50)]
        public string postal_line2 { get; set; }

        [StringLength(50)]
        public string postal_suburb { get; set; }

        [StringLength(50)]
        public string postal_city { get; set; }

        [StringLength(20)]
        public string postal_code { get; set; }

        public int? postal_country { get; set; }

        [StringLength(50)]
        public string residential_line1 { get; set; }

        [StringLength(50)]
        public string residential_line2 { get; set; }

        [StringLength(50)]
        public string residential_suburb { get; set; }

        [StringLength(50)]
        public string residential_city { get; set; }

        [StringLength(20)]
        public string residential_code { get; set; }

        public int? residential_country { get; set; }

        [StringLength(20)]
        public string telephone_home { get; set; }

        [StringLength(20)]
        public string telephone_work { get; set; }

        [StringLength(20)]
        public string telephone_cell { get; set; }

        [StringLength(20)]
        public string telephone_fax { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(50)]
        public string skype_account { get; set; }

        [StringLength(50)]
        public string twitter_account { get; set; }

        [StringLength(50)]
        public string facebook_account { get; set; }

        [StringLength(50)]
        public string pinterest_account { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_birth { get; set; }

        [StringLength(50)]
        public string employer { get; set; }

        public decimal? total_monthly_income { get; set; }

        [StringLength(20)]
        public string bank_name { get; set; }

        [StringLength(20)]
        public string bank_branch_name { get; set; }

        [StringLength(20)]
        public string bank_branch_code { get; set; }

        [StringLength(50)]
        public string bank_account_name { get; set; }

        [StringLength(20)]
        public string bank_account_number { get; set; }

        [StringLength(20)]
        public string bank_account_type { get; set; }

        [StringLength(30)]
        public string bank_account_bic { get; set; }

        [StringLength(30)]
        public string bank_account_iban { get; set; }

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

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public int? nationality_id { get; set; }

        public int? country_id { get; set; }

        public int? occupation_id { get; set; }

        [StringLength(50)]
        public string doctor_address_line1 { get; set; }

        [StringLength(50)]
        public string doctor_name { get; set; }

        [StringLength(50)]
        public string doctor_address_line2 { get; set; }

        [StringLength(50)]
        public string doctor_address_suburb { get; set; }

        [StringLength(50)]
        public string doctor_address_city { get; set; }

        [StringLength(20)]
        public string doctor_address_code { get; set; }

        [StringLength(250)]
        public string occupation_description { get; set; }

        [StringLength(250)]
        public string citizenship_string_from_magnum { get; set; }

        public bool? acting_on_own_behalf { get; set; }

        [StringLength(250)]
        public string place_of_birth { get; set; }

        [StringLength(50)]
        public string Identified { get; set; }

        [StringLength(250)]
        public string screeningUniqueId { get; set; }

        [StringLength(50)]
        public string screeningMatch { get; set; }

        public DateTime? screeningLastScreenDate { get; set; }

        public DateTime? identifedDate { get; set; }

        [StringLength(50)]
        public string matchDecision { get; set; }

        [StringLength(50)]
        public string specialHandling { get; set; }

        public bool? smoker { get; set; }

        [StringLength(50)]
        public string occupation_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Party_Role> Party_Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Underwriting_Decision> Underwriting_Decision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
