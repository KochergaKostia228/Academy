using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Академія.Domain.Student
{
    public class ListStudent
    {
        private List<Student> students = new List<Student> { new Student("Kostia","Kocherga","kocherga228","12345")};

        public void AddUser(Student student)
        {
            students.Add(student);
        }
        public List<Student> GetUsers()
        {
            return students;
        }
    }
}
