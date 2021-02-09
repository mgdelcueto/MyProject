using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyProject.Models
{
    [Table("Journal")]
    public partial class Journal
    {
        [Key]
        public int JourId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JourDate { get; set; }
        public int? JourItem { get; set; }
        [StringLength(255)]
        public string JourDesc { get; set; }
        public double? JourAmount { get; set; }
    }
}
