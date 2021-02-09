using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyProject.Models
{
    public partial class Item
    {
        [Key]
        public int ItemId { get; set; }
        public int ItemOrder { get; set; }
        public int ItemMonth { get; set; }       
        public int ItemYearM { get; set; }
        [StringLength(255)]
        public string ItemDesc { get; set; }
        public double? ItemBudget { get; set; }
    }
    public partial class ItemView
    {
        [Key]
        public int ItemId { get; set; }
        public int ItemOrder { get; set; }
        public int ItemMonth { get; set; }       
        public int ItemYearM { get; set; }
        [StringLength(255)]
        public string ItemDesc { get; set; }
        public double? ItemBudget { get; set; }
        [StringLength(255)]
        public string ItemMoNam { get; set; }
        [StringLength(255)]
        public string ItemYMNam { get; set; }
    }
}
