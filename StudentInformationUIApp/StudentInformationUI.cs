using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationUIApp
{
    public partial class StudentInformationUI : Form
    {
        List<StudentInfo> students = new List<StudentInfo>();
        public StudentInformationUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StudentInfo studentObj = new StudentInfo();
            studentObj.regNumber = regTextBox.Text;
            studentObj.firstName = firstNameTextBox.Text;
            studentObj.lastName = lastNameTextBox.Text;
            students.Add(studentObj);
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            regTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            string columns = "Registration Number " + "Full Name";
            string studentsInformation = "";

            foreach (StudentInfo aStudent in students)
            {
                studentsInformation += aStudent.regNumber + "\t";
                studentsInformation += aStudent.GetFullName();
                studentsInformation += "\n";
            }

            MessageBox.Show(columns + "\n" + studentsInformation);
        }
    }
}
