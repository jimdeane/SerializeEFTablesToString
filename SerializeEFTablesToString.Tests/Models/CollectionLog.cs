using System;
using System.ComponentModel.DataAnnotations;

namespace TestAsp.NetMvcFluentModelBinding.Models
{
    public partial class CollectionLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string EventType { get; set; }

        public DateTime EventDateTime { get; set; }

        [StringLength(20)]
        public string EventOutcome { get; set; }

        [StringLength(250)]
        public string Message { get; set; }

        [StringLength(100)]
        public string Filename { get; set; }

        [StringLength(30)]
        public string FileFormat { get; set; }

        public int? WorkflowRowId { get; set; }
    }
}
