using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class StudentForm : Form {

        public Student student;
        public MainForm studentMainForm;

        public StudentForm() {

            InitializeComponent();
        }

        private void CtrlStudentOK_click(object sender, EventArgs e) {

            if (CtrlStudentNameTextEdit.Text == string.Empty) {

                MessageBox.Show("Name is required.");
            }
            else {

                student.Name = CtrlStudentNameTextEdit.Text;

                student.Age = (int)CtrlStudentAgeSpintEdit.Value;

                student.RegistrationNumber = (int)CtrlStudentRegistrationNumberSpinEdit.Value;

                studentMainForm.student = student;

                studentMainForm.CtrlStudentIDListBox.Items.Add(student.ID.ToString());

                studentMainForm.CtrlStudentNameListBox.Items.Add(student.Name);

                studentMainForm.CtrlStudentAgeListBox.Items.Add(student.Age);

                studentMainForm.CtrlStudentRegistrationNumberListBox.Items.Add(student.RegistrationNumber);

                this.Close();
            }

        }

        private void CtrlStudentCancel_click(object sender, EventArgs e) {

            student = null;

            GC.Collect();

            this.Close();

        }

        private void StudentForm_Load(object sender, EventArgs e) {

            CtrlStudentIDTextEdit.Text = studentMainForm.student.ID.ToString();

        }
    }
}
