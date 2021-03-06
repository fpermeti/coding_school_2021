using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1 {

    public partial class StudentForm : DevExpress.XtraEditors.XtraForm {

        public Student NewStudent = null;

        public University NewUniversity = null;

        public StudentForm() {

            InitializeComponent();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            AddStudent();
        }

        private void AddStudent() {

            if (Convert.ToString(ctrlName.EditValue).Length > 0 && Convert.ToString(ctrlSurname.EditValue).Length > 0) {

                NewStudent.Name = Convert.ToString(ctrlName.EditValue);

                NewStudent.Surname = Convert.ToString(ctrlSurname.EditValue);

                NewStudent.Age = Convert.ToInt32(ctrlAge.EditValue);

                NewStudent.RegistrationNumber = Convert.ToInt32(ctrlRegistrationNumber.EditValue);

                //populate list containing the courses a student attends
                foreach (int i in ctrlCourses.CheckedIndices) {

                    NewStudent.Courses.Add(NewUniversity.Courses[i]); //= studentCourses;
                }

                DialogResult = DialogResult.OK;

                Close();
            }
            else {

                MessageBox.Show("Name and Surname are required.");
            }
        }

        private void ctrlCancel_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
