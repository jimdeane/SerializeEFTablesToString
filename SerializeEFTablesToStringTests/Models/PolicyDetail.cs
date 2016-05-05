using System;

namespace SerializeEFTablesToStringTests.Models
{
    public class PolicyDetail
    {
        public string policy_number { get; set; }
        public string party_unique_ref { get; set; }
        public int party_row_id { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public DateTime date_of_birth { get; set; }
        public string product_component_code { get; set; }
        public int policy_component_id { get; set; }
        public string product_code { get; set; }
        public int uw_decision_id { get; set; }
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public decimal sum_assurmed { get; set; }
        public int insured_term { get; set; }
        public decimal quoted_amount { get; set; }
        public DateTime requested_start_date { get; set; }
        public decimal calculated_total_premium { get; set; }
        public decimal calculated_base_premium { get; set; }
        public int payment_frequency { get; set; }
        public string IBAN { get; set; }
        public string risk_type_code { get; set; }
        public int entry_age { get; set; }
        public int last_usi_id { get; set; }
        public int last_usi { get; set; }
        public int PolicyComponentSequence { get; internal set; }
    }
}