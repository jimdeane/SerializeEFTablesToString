using System;
using System.ComponentModel.DataAnnotations;

namespace TestAsp.NetMvcFluentModelBinding.Models
{
    public partial class MoneyInToken
    {
        public int Id { get; set; }

        public int MoneyInTokenNumber { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? DueDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public DateTime? StatusDatetime { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        public decimal Amount { get; set; }

        [Required]
        [StringLength(3)]
        public string Currency { get; set; }

        public int? CollectionRequestId { get; set; }

        [Required]
        [StringLength(36)]
        public string PolicyNumber { get; set; }

        public int PolicyComponentSequence { get; set; }

        [Required]
        [StringLength(255)]
        public string PartyUniqueReference { get; set; }

        public int? AllocationTokenId { get; set; }

        public int? ReversesMoneyInToken { get; set; }

        public int? ReplacesMoneyInToken { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime ReplacedAt { get; set; }
    }
}
