using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstPrac
{
    public class TeacherModel
    {
        public TeacherModel()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public DateTime? DoB { get; set; }

        IList<StudentModel> Students;
    }
}
