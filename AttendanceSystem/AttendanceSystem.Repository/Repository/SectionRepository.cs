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
    public class SectionRepository
    {
        SqlConnection sqlConnection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"]);

        public List<Section> GetAllSections()
        {
            List<Section> sections = new List<Section>();

            string commandString = $"SELECT * FROM Sections";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Section section = new Section();

                section.Id = Convert.ToInt32(sqlDataReader["Id"]);
                section.Name = sqlDataReader["Name"].ToString();

                sections.Add(section);
            }

            sqlConnection.Close();

            return sections;
        }
    }
}
