using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirstPrac
{

    public class access_context: DbContext
    {
        public access_context():base()
        {

        }

        public DbSet<StudentModel> students { get; set; }
        public DbSet<TeacherModel> teachers { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using ( access_context ac=new access_context())
            {
                StudentModel std = new StudentModel() {Id=1, Name="Shoaib", Grade="A+"};
                try {
                    ac.students.Add(std);
                    ac.SaveChanges();
                }catch(Exception e)
                {
                    Console.Write(e.ToString());
                }

            }
        }
    }
}
