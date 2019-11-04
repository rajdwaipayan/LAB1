using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ShowControl(Control control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            contentPanel.Controls.Add(control);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit..!", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StudentUserControl studentUserControl = new StudentUserControl();
            ShowControl(studentUserControl);
        }
    }
}
