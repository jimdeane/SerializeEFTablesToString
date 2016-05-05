using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerializeEFTablesToString.Tests.Models
{
    [Table("PolicyComponentStatusHistory")]
    public partial class PolicyComponentStatusHistory
    {
        public int Id { get; set; }

        public int PolicyComponentId { get; set; }

        public DateTime StatusChangeDate { get; set; }

        [Required]
        [StringLength(80)]
        public string PreviousStatus { get; set; }

        [Required]
        [StringLength(80)]
        public string NewStatus { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string SessionId { get; set; }

        [StringLength(36)]
        public string PolicyNumber { get; set; }

        [StringLength(50)]
        public string ProductComponentCode { get; set; }
    }
}
