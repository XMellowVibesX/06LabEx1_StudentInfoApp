using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentINfo : Form
    {
        public frmStudentINfo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentInfo Student = new StudentInfo(tbStudentID.Text, tbFirstName.Text, tbLastName.Text);

            lbStudentID.Items.Add(Student.StudentID);
            lbFirstName.Items.Add(Student.FirstName);
            lbLastName.Items.Add(Student.LastName);
        }
    }
}
