using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerializeEFTablesToStringTests.Models
{
    public partial class Mandate
    {
        [Key]
        public int Id { get; set; }
        
        public string MandateNumber { get; set; }

        //[Required]
        [StringLength(255)]
        public string PartyUniqueReference { get; set; }

        //[Required]
        //[StringLength(50)]
        public string PayorRelationship { get; set; }

        public int? PartyBankAccountId { get; set; }

        [StringLength(30)]
        public string IBAN { get; set; }

        //[Required]
        //[StringLength(36)]
        public string PolicyNumber { get; set; }

        public int PolicyComponentSequence { get; set; }

        //[Required]
        //[StringLength(10)]
        public string CollectionType { get; set; }

        [StringLength(10)]
        public string CollectionSubtype { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

       
        public DateTime? SignatureDate { get; set; }

        //[StringLength(50)]
        public string DebtorName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime ReplacedAt { get; set; }
    }
}
