using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceSystem.Model.Model;
using AttendanceSystem.Manager.Manager;

namespace AttendanceSystem
{
    public partial class StudentUserControl : UserControl
    {
        StudentManager _studentManager = new StudentManager();
        DepartmentManager _departmentManager = new DepartmentManager();
        SectionManager _sectionManager = new SectionManager();

        public StudentUserControl()
        {
            InitializeComponent();
            try
            {
                departmentComboBox.DataSource = _departmentManager.GetAllDepartments();
                sectionComboBox.DataSource = _sectionManager.GetAllSections();
                showDataGridView.DataSource = _studentManager.GetAllStudents();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private Student student=new Student();
        private void saveButton_Click(object sender, EventArgs e)
        {
            student.StudentId = studentIdTextBox.Text;
            student.DepartmentId = Convert.ToInt32(departmentComboBox.SelectedValue);
            student.SectionId = Convert.ToInt32(sectionComboBox.SelectedValue);
            student.Name = nameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.Contact = contactTextBox.Text;
            student.Address = addressTextBox.Text;

            if (_studentManager.Add(student))
            {
                showDataGridView.DataSource = null;
                showDataGridView.DataSource = _studentManager.GetAllStudents();
                MessageBox.Show("Added Successfully..!");
            }
            else
            {
                MessageBox.Show("Not Saved..!");
            }
        }
    }
}
