using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAsp.NetMvcFluentModelBinding.Models
{
    public partial class CollectionRequest
    {
        public int Id { get; set; }

        public int RequestNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string PartyUniqueReference { get; set; }

        [Required]
        [StringLength(36)]
        public string PolicyNumber { get; set; }

        public int PolicyComponentSequence { get; set; }

        [Required]
        [StringLength(10)]
        public string CollectionType { get; set; }

        [StringLength(10)]
        public string CollectionSubtype { get; set; }

        public int MandateNumber { get; set; }

        public int AllocationRequestId { get; set; }

        [StringLength(10)]
        public string Mode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TargetDueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TargetRequestDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActualRequestDate { get; set; }

        [StringLength(100)]
        public string RequestFilename { get; set; }

        [StringLength(4)]
        public string RejectionCode { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }

        public decimal? ExpectedAmount { get; set; }

        public decimal? InstructedAmount { get; set; }

        [StringLength(3)]
        public string Currency { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime ReplacedAt { get; set; }
    }
}
