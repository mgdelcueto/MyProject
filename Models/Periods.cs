using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable
namespace MyProject.Models
{
    public partial class Periods
    {
        [Key]
        public int PerId { get; set; }
        public int PerNum { get; set; }
        [StringLength(25)]
        public string PerNam { get; set; }
    }
}
