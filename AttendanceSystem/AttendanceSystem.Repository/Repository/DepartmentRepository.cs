using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AttendanceSystem.Model.Model;

namespace AttendanceSystem.Repository.Repository
{
    public class DepartmentRepository
    {
        SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);


        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            string commandString = $"SELECT * FROM Departments";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Department department = new Department();

                department.Id = Convert.ToInt32(sqlDataReader["Id"]);
                department.Name = sqlDataReader["Name"].ToString();

                departments.Add(department);
            }

            sqlConnection.Close();

            return departments;
        }
    }
}
