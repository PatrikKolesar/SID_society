namespace StationLogWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        public int TaskID { get; set; }

        [Required]
        [StringLength(100)]
        public string Content { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public int StationID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Instrument { get; set; }

        [Required]
        [StringLength(50)]
        public string Schedule { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Instrument Instrument1 { get; set; }

        public virtual Station Station { get; set; }
    }
}
