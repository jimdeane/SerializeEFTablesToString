using System.ComponentModel.DataAnnotations;
using TestAsp.NetMvcFluentModelBinding.Models;

namespace SerializeEFTablesToString.Tests.Models
{
    public partial class Party_Role
    {
        [Key]
        public int party_role_id { get; set; }

        [Required]
        [StringLength(255)]
        public string party_unique_ref { get; set; }

        [StringLength(50)]
        public string role_type_code { get; set; }

        [StringLength(36)]
        public string policy_number { get; set; }

        public int? policy_component_id { get; set; }

        [StringLength(150)]
        public string relationship_to_policyholder { get; set; }

        public decimal? percentage_of_benefit { get; set; }

        public virtual Party Party { get; set; }

        public virtual Policy Policy { get; set; }

        public virtual Policy_Component Policy_Component { get; set; }
    }
}
