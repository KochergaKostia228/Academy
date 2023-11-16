using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Академія.Domain.Teacher
{
    public class ListTeacher
    {
        private List<Teacher> teachers = new List<Teacher> { new Teacher("Jhon","Snow","jhonsnow123", "jhonsnow123") };

        public void AddUser(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public List<Teacher> GetUsers()
        {
            return teachers;
        }
    }
}
