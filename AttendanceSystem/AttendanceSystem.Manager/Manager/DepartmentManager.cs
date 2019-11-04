using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceSystem.Repository.Repository;
using AttendanceSystem.Model.Model;

namespace AttendanceSystem.Manager.Manager
{
    public class DepartmentManager
    {
        DepartmentRepository _departmentRepository = new DepartmentRepository();

        public List<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartments();
        }
    }
}
