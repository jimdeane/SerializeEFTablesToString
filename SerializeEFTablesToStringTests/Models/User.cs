using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SerializeEFTablesToString.Tests.Models;

namespace SerializeEFTablesToStringTests.Models
{
    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            User_Saved_Item = new HashSet<User_Saved_Item>();
        }

        [Key]
        public int user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string user_name { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [Required]
        [StringLength(500)]
        public string password { get; set; }

        [StringLength(1000)]
        public string bio { get; set; }

        [StringLength(15)]
        public string language_code { get; set; }

        public int? user_hierarchy_level { get; set; }

        [StringLength(255)]
        public string party_unique_ref { get; set; }

        [StringLength(50)]
        public string site_code { get; set; }

        public bool? read_privacy_policy { get; set; }

        public bool? read_terms_of_service { get; set; }

        public DateTime? created { get; set; }

        public DateTime? last_login { get; set; }

        public int? consecutive_failed_logins { get; set; }

        public int? user_registration_level { get; set; }

        [StringLength(150)]
        public string first_name { get; set; }

        [StringLength(150)]
        public string last_name { get; set; }

        public bool? email_verified { get; set; }

        public DateTime? datetime_level2_verified { get; set; }

        public bool? consent_data_protection { get; set; }

        public bool? consent_community_conduct { get; set; }

        public bool? consent_specs_of_electronic_comms { get; set; }

        [StringLength(10)]
        public string lastEmailPin { get; set; }

        [StringLength(10)]
        public string lastSMSPin { get; set; }

        public DateTime? datetime_last_page_view { get; set; }

        public DateTime? datetime_email_pin_sent { get; set; }

        public DateTime? datetime_sms_pin_sent { get; set; }

        [StringLength(50)]
        public string mobile_number { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public virtual Party Party { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Saved_Item> User_Saved_Item { get; set; }
    }
}
