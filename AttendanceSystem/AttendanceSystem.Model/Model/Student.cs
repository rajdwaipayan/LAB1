using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem.Model.Model
{
    public class Student
    {
        public int Id { set; get; }
        public string StudentId { set; get; }
        public int DepartmentId { set; get; }
        public int SectionId { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public string Address { set; get; }
    }
}
