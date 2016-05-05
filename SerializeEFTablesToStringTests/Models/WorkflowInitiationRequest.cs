using System;
using System.ComponentModel.DataAnnotations;

namespace SerializeEFTablesToString.Tests.Models
{
    public partial class WorkflowInitiationRequest
    {
        public int Id { get; set; }

        public DateTime RequestDateTime { get; set; }

        [Required]
        public string WorkflowName { get; set; }

        public int? UserSavedITemId { get; set; }

        [StringLength(255)]
        public string PartyId { get; set; }

        public int? User_Id { get; set; }

        public DateTime? RequestCompletedDateTime { get; set; }
    }
}
