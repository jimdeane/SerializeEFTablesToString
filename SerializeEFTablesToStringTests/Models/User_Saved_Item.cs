using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SerializeEFTablesToString.Tests.Models;

namespace SerializeEFTablesToStringTests.Models
{
    public partial class User_Saved_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Saved_Item()
        {
            User_Saved_Item1 = new HashSet<User_Saved_Item>();
            User_Saved_Item11 = new HashSet<User_Saved_Item>();
        }

        [Key]
        public int user_saved_item_id { get; set; }

        [StringLength(50)]
        public string user_saved_item_type { get; set; }

        public DateTime? created { get; set; }

        public int? user_id { get; set; }

        public bool? smoker { get; set; }

        public decimal? sum_assured { get; set; }

        public decimal? insured_term { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_birth { get; set; }

        public decimal? quoted_amount { get; set; }

        [StringLength(250)]
        public string occupation_description { get; set; }

        [StringLength(50)]
        public string occupation_class { get; set; }

        [StringLength(50)]
        public string payment_frequency { get; set; }

        public int? occupation_id { get; set; }

        public int? assure_till_age { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expected_start_date { get; set; }

        [StringLength(50)]
        public string needs_analysis_gender { get; set; }

        [StringLength(50)]
        public string needs_analysis_marital_status { get; set; }

        public int? needs_analysis_age { get; set; }

        [StringLength(50)]
        public string needs_analysis_housing_type { get; set; }

        public decimal? needs_analysis_outstanding_home_loan { get; set; }

        public decimal? needs_analysis_monthly_rent { get; set; }

        public int? needs_analysis_number_of_children { get; set; }

        public int? needs_analysis_child_1_age { get; set; }

        public int? needs_analysis_child_2_age { get; set; }

        public int? needs_analysis_child_3_age { get; set; }

        public int? needs_analysis_child_4_age { get; set; }

        public int? needs_analysis_child_5_age { get; set; }

        public bool? needs_analysis_finance_education { get; set; }

        [StringLength(50)]
        public string needs_analysis_education_type { get; set; }

        public decimal? needs_analysis_education_contribution { get; set; }

        public decimal? needs_analysis_gross_annual_income { get; set; }

        public decimal? needs_analysis_auto_finance { get; set; }

        public decimal? needs_analysis_private_credit { get; set; }

        public decimal? needs_analysis_special_care_cost { get; set; }

        public decimal? needs_analysis_burial_costs_and_other { get; set; }

        public decimal? needs_analysis_bereaved_savings { get; set; }

        public decimal? needs_analysis_other_savings { get; set; }

        public decimal? needs_analysis_existing_disability_insurance { get; set; }

        public decimal? needs_analysis_existing_life_insurance { get; set; }

        public string magnum_xml_log { get; set; }

        public int? uw_decision_id { get; set; }

        public bool? Ref16LegalAgreement { get; set; }

        public bool? Ref17LegalAgreement { get; set; }

        public bool? Ref18LegalAgreement { get; set; }

        public bool? Ref25GDVPart2Options { get; set; }

        public bool? Ref25GDVPart1Optons { get; set; }

        public bool? Ref25GDVPart3Options { get; set; }

        public bool? saved_by_user { get; set; }

        public int? parent_usi_id { get; set; }

        public int? first_usi_id { get; set; }

        [StringLength(50)]
        public string product_component_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? requested_start_date { get; set; }

        public string json_beneficiaries { get; set; }

        public string email_text { get; set; }

        [StringLength(250)]
        public string email_to { get; set; }

        [StringLength(250)]
        public string email_from { get; set; }

        [StringLength(250)]
        public string email_subject { get; set; }

        public decimal? calculated_additional_premium { get; set; }

        public decimal? calculated_total_premium { get; set; }

        public decimal? calculated_base_premium { get; set; }

        public decimal? total_benefit_reduction { get; set; }

        [StringLength(50)]
        public string callback_title { get; set; }

        [StringLength(50)]
        public string callback_firstname { get; set; }

        [StringLength(50)]
        public string callback_surname { get; set; }

        [StringLength(50)]
        public string callback_time { get; set; }

        [StringLength(500)]
        public string session_id { get; set; }

        public decimal? grossSalary { get; set; }

        [StringLength(250)]
        public string occupationStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? callback_date { get; set; }

        [StringLength(50)]
        public string callback_telephone { get; set; }

        public decimal? sum_assured_disability { get; set; }

        public decimal? needs_analysis_amount_invested { get; set; }

        public string callWrapUP { get; set; }

        public int? callWrapUpCategory { get; set; }

        public bool? requestForManualUW { get; set; }

        public bool? Ref6LegalAgreement { get; set; }

        public bool? Ref7LegalAgreement { get; set; }

        public bool? Ref14LegalAgreement { get; set; }

        public DateTime? callWrapUpDateTime { get; set; }

        public bool? Ref6and7LegalAgreement { get; set; }

        public bool? Ref16and17LegalAgreement { get; set; }

        public bool? data_privacy_consent { get; set; }

        [StringLength(50)]
        public string data_share_data_consent1 { get; set; }

        [StringLength(50)]
        public string data_share_data_consent2 { get; set; }

        [StringLength(100)]
        public string callback_skype_name { get; set; }

        [StringLength(50)]
        public string callback_video_method { get; set; }

        public virtual Underwriting_Decision Underwriting_Decision { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Saved_Item> User_Saved_Item1 { get; set; }

        public virtual User_Saved_Item User_Saved_Item2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Saved_Item> User_Saved_Item11 { get; set; }

        public virtual User_Saved_Item User_Saved_Item3 { get; set; }
    }
}
