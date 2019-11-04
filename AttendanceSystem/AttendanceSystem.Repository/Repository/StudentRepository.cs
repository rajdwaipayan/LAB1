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
    public class StudentRepository
    {
        SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);

        public bool Add(Student student)
        {
            string commandString = $"INSERT INTO Students (StudentId, DepartmentId, SectionId, Name, Email, Contact, Address) VALUES('{student.StudentId}', {student.DepartmentId}, {student.SectionId}, '{student.Name}', '{student.Email}', '{student.Contact}', '{student.Address}')";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isAdded = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (isAdded > 0)
                return true;
            return false;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            string commandString = $"SELECT * FROM Students";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Student student = new Student();

                student.Id = Convert.ToInt32(sqlDataReader["Id"]);
                student.StudentId = sqlDataReader["StudentId"].ToString();
                student.DepartmentId = Convert.ToInt32(sqlDataReader["DepartmentId"]);
                student.SectionId = Convert.ToInt32(sqlDataReader["SectionId"]);
                student.Name = sqlDataReader["Name"].ToString();
                student.Email = sqlDataReader["Email"].ToString();
                student.Contact = sqlDataReader["Contact"].ToString();
                student.Address = sqlDataReader["Address"].ToString();


                students.Add(student);
            }

            sqlConnection.Close();

            return students;
        }
    }
}
