using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace session11.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]
        public String Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(20)")]
        public String Gender { get; set; }
        public int Age { get; set; }

        public int Fee { get; set; }
    }
}
