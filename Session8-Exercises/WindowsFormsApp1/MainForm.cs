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

    public partial class MainForm : Form {

        public Course course;
        public CourseForm courseForm;

        public Student student;
        public StudentForm studentForm;

        public Professor professor;
        public ProfessorForm professorForm;

        public MainForm() {

            InitializeComponent();
        }

        private void CtrlAddCourse_click(object sender, EventArgs e) {

            courseForm = new CourseForm();

            courseForm.courseMainForm = this;

            course = new Course();

            courseForm.course = this.course;

            courseForm.ShowDialog();
        }

        private void CtrlAddStudent_click(object sender, EventArgs e) {

            studentForm = new StudentForm();

            studentForm.studentMainForm = this;

            student = new Student();

            studentForm.student = this.student;

            studentForm.ShowDialog();

        }

        private void CtrlExit_click(object sender, EventArgs e) {

            Application.Exit();
        }

        private void CtrlAddProfessor_click(object sender, EventArgs e) {

            professorForm = new ProfessorForm();

            professorForm.professorMainForm = this;

            professor = new Professor();

            professorForm.professor = this.professor;

            professorForm.ShowDialog();
        }
    }
}
