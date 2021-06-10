using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class CourseForm : Form {

        public Course course;
        public MainForm courseMainForm;

        public CourseForm() {
            InitializeComponent();
        }

        private void CtrlCourseOK_click(object sender, EventArgs e) {


            if (CtrlCourseCodeTextEdit.Text == string.Empty || CtrlCourseSubjectTextEdit.Text == string.Empty) {

                MessageBox.Show("All fields are required.");
            }
            else {

                course.Code = CtrlCourseCodeTextEdit.Text;

                course.Subject = CtrlCourseSubjectTextEdit.Text;

                courseMainForm.course = course;

                courseMainForm.CtrlCourseIDListBox.Items.Add(course.ID.ToString());

                courseMainForm.CtrlCourseCodeListBox.Items.Add(course.Code);

                courseMainForm.CtrlCourseSubjectListBox.Items.Add(course.Subject);

                this.Close();
            }

        }

        private void CourseForm_Load(object sender, EventArgs e) {

            CtrlCourseIDTextEdit.Text = courseMainForm.course.ID.ToString();
        }

        private void CtrlCourseCancel_click(object sender, EventArgs e) {

            course = null;

            GC.Collect();

            this.Close();
        }
    }
}
