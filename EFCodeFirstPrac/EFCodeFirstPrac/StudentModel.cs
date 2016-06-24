using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstPrac
{
    public class StudentModel
    {
        public StudentModel()
        {

        }
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public DateTime? DoB { get; set; }

        IList<TeacherModel> Teachers;
    }
}
