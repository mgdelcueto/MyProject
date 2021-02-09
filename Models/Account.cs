using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyProject.Models
{
    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int AccId { get; set; }
        public int? AccItem { get; set; }
       public int? AccOrder { get; set; }        
        public int? AccYear { get; set; }
        public int? AccMonth { get; set; }
        [StringLength(255)]
        public string AccDesc { get; set; }        
        public double? AccBudget { get; set; }
    }
    public partial class PAccView
    {
        public int AccId { get; set; }
        public int AccItem { get; set; }
       public int AccOrder { get; set; }        
        public int AccYear { get; set; }
        [StringLength(255)]
        public string AccDesc { get; set; }        
        public double? AccBud01 { get; set; }
        public double? AccBud02 { get; set; }
        public double? AccBud03 { get; set; }
        public double? AccBud04 { get; set; }
        public double? AccBud05 { get; set; }
        public double? AccBud06 { get; set; }
        public double? AccBud07 { get; set; }
        public double? AccBud08 { get; set; }
        public double? AccBud09 { get; set; }
        public double? AccBud10 { get; set; }
        public double? AccBud11 { get; set; }
        public double? AccBud12 { get; set; }
    }
    [Table("TAccount")]
    public partial class TAccount
    {
         [Key]
        public int AccId { get; set; }
        public int AccItem { get; set; }
       public int AccOrder { get; set; }        
        public int AccYear { get; set; }
        public int AccMonth { get; set; }   
        [StringLength(255)]
        public string AccDesc { get; set; }        
        public double? AccBud01 { get; set; }
        public double? AccBud02 { get; set; }
        public double? AccBud03 { get; set; }
        public double? AccBud04 { get; set; }
        public double? AccBud05 { get; set; }
        public double? AccBud06 { get; set; }
        public double? AccBud07 { get; set; }
        public double? AccBud08 { get; set; }
        public double? AccBud09 { get; set; }
        public double? AccBud10 { get; set; }
        public double? AccBud11 { get; set; }
        public double? AccBud12 { get; set; }
    }
    public partial class Repport
    {
        public int Year { get; set; }
       public double Enero { get; set; }        
        public double Febrero { get; set; }
        public double Marzo { get; set; }   
        public double Abril { get; set; }        
        public double? Mayo { get; set; }
        public double? Junio { get; set; }
        public double? Julio { get; set; }
        public double? Agosto { get; set; }
        public double? Septiembre { get; set; }
        public double? Octubre { get; set; }
        public double? Noviembre { get; set; }
        public double? Diciembre { get; set; }
        public double? Total { get; set; }
    }

}
