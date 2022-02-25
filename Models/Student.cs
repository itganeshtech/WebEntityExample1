using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEntityExample1.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        public string FullName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Mobile { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        
        [Column(TypeName = "nvarchar(max)")]
        public string Notes { get; set; }

    }
}
