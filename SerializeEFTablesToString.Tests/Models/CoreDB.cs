using System.Data.Entity;



namespace SerializeEFTablesToString.Tests.Models
{
    public partial class CoreDB : DbContext
    {
        public CoreDB()
            : base("name=CoreDB")
        {
        }

        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<Party_Role> Party_Role { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<Policy_Component> Policy_Component { get; set; }
        public virtual DbSet<Policy_Option> Policy_Option { get; set; }
        public virtual DbSet<Policy_Split> Policy_Split { get; set; }
        public virtual DbSet<PolicyComponentStatusHistory> PolicyComponentStatusHistories { get; set; }
        public virtual DbSet<Underwriting_Decision> Underwriting_Decision { get; set; }
        public virtual DbSet<Underwriting_Decision_Evidence_Code> Underwriting_Decision_Evidence_Code { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Saved_Item> User_Saved_Item { get; set; }
        public virtual DbSet<WorkflowInitiationRequest> WorkflowInitiationRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>()
                .Property(e => e.party_unique_ref)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.initials)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.marital_status)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.maiden_name)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.id_number)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.postal_line1)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.postal_line2)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.postal_suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.postal_city)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.postal_code)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.residential_line1)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.residential_line2)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.residential_suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.residential_city)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.residential_code)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.telephone_home)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.telephone_work)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.telephone_cell)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.telephone_fax)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.skype_account)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.twitter_account)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.facebook_account)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.pinterest_account)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.employer)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_name)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_branch_name)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_branch_code)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_account_name)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_account_number)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_account_type)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_account_bic)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.bank_account_iban)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.persal_initials)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.persal_surname)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.persal_number)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.persal_organisation_code)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.persal_paypoint_code)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.doctor_address_line1)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.doctor_name)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.doctor_address_line2)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.doctor_address_suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.doctor_address_city)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.doctor_address_code)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.occupation_description)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.citizenship_string_from_magnum)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.place_of_birth)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.Identified)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.screeningUniqueId)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.screeningMatch)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.matchDecision)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.specialHandling)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.occupation_status)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.Party_Role)
                .WithRequired(e => e.Party)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Party_Role>()
                .Property(e => e.party_unique_ref)
                .IsUnicode(false);

            modelBuilder.Entity<Party_Role>()
                .Property(e => e.role_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<Party_Role>()
                .Property(e => e.policy_number)
                .IsUnicode(false);

            modelBuilder.Entity<Party_Role>()
                .Property(e => e.relationship_to_policyholder)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.policy_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.product_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.policy_status)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.comm_party_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.branch_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.initials)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.id_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.marital_status)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.postal_line_1)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.postal_line_2)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.postal_suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.postal_city)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.postal_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.residential_line_1)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.residential_line_2)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.residential_suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.residential_city)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.residential_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.telephone_home)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.telephone_work)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.telephone_cell)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.telephone_fax)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.employer)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_name)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_branch_name)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_branch_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_account_name)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_account_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_account_type)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_id_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_telephone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_address_1)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_address_2)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_address_suburb)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_address_city)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_address_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.persal_initials)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.persal_surname)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.persal_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.persal_organisation_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.persal_paypoint_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.upfront_commission)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.comm_party_display_name)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.maiden_name)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_fax_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.account_holder_passport_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.form_application_ref)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.collection_method_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.collection_method_class_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.taken_over_from)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_account_bic)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.bank_account_iban)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.underwriting_decision_reason)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .HasMany(e => e.Policy_Component)
                .WithRequired(e => e.Policy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Policy_Component>()
                .Property(e => e.product_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Component>()
                .Property(e => e.policy_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Component>()
                .Property(e => e.product_component_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Component>()
                .Property(e => e.risk_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Component>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Component>()
                .Property(e => e.beneficiary_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Option>()
                .Property(e => e.policy_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Option>()
                .Property(e => e.product_component_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Option>()
                .Property(e => e.product_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Option>()
                .Property(e => e.product_option_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Option>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Option>()
                .Property(e => e.occupation_class)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.policy_number)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.split_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.product_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.product_component_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.product_option_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.product_option_split_category_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.risk_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<Policy_Split>()
                .Property(e => e.destination)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyComponentStatusHistory>()
                .Property(e => e.PreviousStatus)
                .IsFixedLength();

            modelBuilder.Entity<PolicyComponentStatusHistory>()
                .Property(e => e.NewStatus)
                .IsFixedLength();

            modelBuilder.Entity<PolicyComponentStatusHistory>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyComponentStatusHistory>()
                .Property(e => e.SessionId)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyComponentStatusHistory>()
                .Property(e => e.PolicyNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PolicyComponentStatusHistory>()
                .Property(e => e.ProductComponentCode)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision>()
                .Property(e => e.policy_number)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision>()
                .Property(e => e.party_unique_ref)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision>()
                .Property(e => e.uw_decision_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision>()
                .Property(e => e.uw_decision_text)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision>()
                .Property(e => e.uw_decision_status)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision>()
                .Property(e => e.uw_decision_type_class)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision>()
                .Property(e => e.uw_decision_product_component_code)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision_Evidence_Code>()
                .Property(e => e.evidence_code)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision_Evidence_Code>()
                .Property(e => e.evidence_text)
                .IsUnicode(false);

            modelBuilder.Entity<Underwriting_Decision_Evidence_Code>()
                .Property(e => e.additional_rate_per_mil)
                .HasPrecision(18, 5);

            modelBuilder.Entity<User>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.bio)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.language_code)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.party_unique_ref)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.site_code)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.lastEmailPin)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.lastSMSPin)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.mobile_number)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.status)
                .IsFixedLength();

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.user_saved_item_type)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.occupation_description)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.occupation_class)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.payment_frequency)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_gender)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_marital_status)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_housing_type)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_education_type)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_education_contribution)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_gross_annual_income)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_auto_finance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_private_credit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_special_care_cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_burial_costs_and_other)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_bereaved_savings)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_other_savings)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_existing_disability_insurance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_existing_life_insurance)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.magnum_xml_log)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.product_component_code)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.json_beneficiaries)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.email_text)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.email_to)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.email_from)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.email_subject)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.callback_title)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.callback_firstname)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.callback_surname)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.callback_time)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.session_id)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.needs_analysis_amount_invested)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.data_share_data_consent1)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.data_share_data_consent2)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.callback_skype_name)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .Property(e => e.callback_video_method)
                .IsUnicode(false);

            modelBuilder.Entity<User_Saved_Item>()
                .HasMany(e => e.User_Saved_Item1)
                .WithOptional(e => e.User_Saved_Item2)
                .HasForeignKey(e => e.first_usi_id);

            modelBuilder.Entity<User_Saved_Item>()
                .HasMany(e => e.User_Saved_Item11)
                .WithOptional(e => e.User_Saved_Item3)
                .HasForeignKey(e => e.parent_usi_id);

            modelBuilder.Entity<WorkflowInitiationRequest>()
                .Property(e => e.PartyId)
                .IsUnicode(false);
        }
    }
}
