using System;
using System.ComponentModel.DataAnnotations;

namespace TestAsp.NetMvcFluentModelBinding.Models
{
    public partial class CollectionFailureLog
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string CollectionType { get; set; }

        [StringLength(10)]
        public string CollectionSubtype { get; set; }

        [StringLength(20)]
        public string FailureCode { get; set; }

        [StringLength(100)]
        public string FailureDescription { get; set; }

        public DateTime EventDateTime { get; set; }

        [StringLength(100)]
        public string CollectionRequestFilename { get; set; }

        [StringLength(100)]
        public string CollectionRejectionFilename { get; set; }

        [Required]
        [StringLength(255)]
        public string PartyUniqueReference { get; set; }

        [Required]
        [StringLength(36)]
        public string PolicyNumber { get; set; }

        public int PolicyComponentSequence { get; set; }

        public int? WorkflowInstanceId { get; set; }

        [StringLength(20)]
        public string ReportedTo { get; set; }
    }
}
