using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerializeEFTablesToStringTests.Models
{
    public partial class Underwriting_Decision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Underwriting_Decision()
        {
            Underwriting_Decision_Evidence_Code = new HashSet<Underwriting_Decision_Evidence_Code>();
            User_Saved_Item = new HashSet<User_Saved_Item>();
        }

        [Key]
        public int uw_decision_id { get; set; }

        [StringLength(36)]
        public string policy_number { get; set; }

        [StringLength(255)]
        public string party_unique_ref { get; set; }

        [Required]
        [StringLength(50)]
        public string uw_decision_type_code { get; set; }

        [StringLength(1000)]
        public string uw_decision_text { get; set; }

        [Column(TypeName = "date")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? end_date { get; set; }

        public string uw_decision_status { get; set; }

        [StringLength(50)]
        public string uw_decision_type_class { get; set; }

        [StringLength(50)]
        public string uw_decision_product_component_code { get; set; }

        public DateTime? uw_decision_date { get; set; }

        public virtual Party Party { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Underwriting_Decision_Evidence_Code> Underwriting_Decision_Evidence_Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Saved_Item> User_Saved_Item { get; set; }
    }
}
