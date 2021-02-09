using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable
namespace MyProject.Models
{
    public partial class Months
    {
        [Key]
        public int MoId { get; set; }
        public int MoNum { get; set; }
        [StringLength(25)]
        public string MoNam { get; set; }
    }
}
