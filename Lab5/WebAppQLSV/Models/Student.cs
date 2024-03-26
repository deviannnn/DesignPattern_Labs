using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace WebAppQLSV.Models
{
    public class Student
    {
        [Required]
        [StringLength(10)]
        [RegularExpression(@"^\S*$", ErrorMessage = "Code must not contain spaces")]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Name must only contain letters and spaces")]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression(@"^\S*$", ErrorMessage = "Class must not contain spaces")]
        public string Class { get; set; }

        public Student() { }

        public Student(DbDataReader reader)
        {
            Code = (string)reader["Code"];
            Name = (string)reader["Name"];
            Birthday = (DateTime)reader["Birthday"];
            Class = (string)reader["Class"];
        }

        public Student(DataRow dataRow)
        {
            Code = (string)dataRow["Code"];
            Name = (string)dataRow["Name"];
            Birthday = (DateTime)dataRow["Birthday"];
            Class = (string)dataRow["Class"];
        }
    }
}