using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1 {

    public partial class MainForm : DevExpress.XtraEditors.XtraForm {

        private const string _JsonFile = "UniversityData.json";

        private University CodingSchool = null;

        private ProfessorForm professorForm = null;

        private StudentForm studentForm = null;

        public MainForm() {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            RetrieveObjectFromJson();
        }

        private void RetrieveObjectFromJson() {

            //the program attempts to deserialize object from json file
            //if the file does not exist, then it creates an empty file
            //and serializes an empty object to the json file
            DeserializeFromJson();

            RefreshCourseList();

            RefreshStudentList();

            RefreshProfessorList();
        }

        private void AddCourse() {

            Course course = new Course();

            CourseForm courseForm = new CourseForm() {

                NewCourse = course
            };

            DialogResult result = courseForm.ShowDialog();

            switch (result) {

                case DialogResult.OK:

                    CodingSchool.Courses.Add(courseForm.NewCourse);

                    SerializeToJson(CodingSchool);

                    break;
                default:
                    break;
            }
        }

        private void AddStudent() {

            Student student = new Student();

            studentForm = new StudentForm() {

                NewUniversity = CodingSchool,

                NewStudent = student
            };

            //popuate CheckedListBox
            foreach (Course course in CodingSchool.Courses) {

                studentForm.ctrlCourses.Items.Add(course.Code);
            }

            DialogResult result = studentForm.ShowDialog();

            switch (result) {

                case DialogResult.OK:

                    CodingSchool.Students.Add(studentForm.NewStudent);

                    SerializeToJson(CodingSchool);

                    break;
                default:
                    break;
            }
        }

        private void AddProfessor() {

            Professor professor = new Professor();

            professorForm = new ProfessorForm() {

                NewUniversity = CodingSchool,

                NewProfessor = professor
            };

            //popuate CheckedListBox
            foreach (Course course in CodingSchool.Courses) {

                professorForm.ctrlCourses.Items.Add(course.Code);
            }

            DialogResult result = professorForm.ShowDialog();

            switch (result) {

                case DialogResult.OK:

                    CodingSchool.Professors.Add(professorForm.NewProfessor);

                    SerializeToJson(CodingSchool);

                    break;
                default:
                    break;
            }
        }

        private void RefreshCourseList() {

            ctrlCourseList.Items.Clear();

            foreach (Course course in CodingSchool.Courses) {

                ctrlCourseList.Items.Add(string.Format("{0} \t {1} \t {2} \t {3}", course.Code, course.Subject, course.Hours, course.Category));
            }
        }

        private void RefreshStudentList() {

            ctrlStudentList.Items.Clear();

            string studentCoursesCodes = string.Empty;

            foreach (Student student in CodingSchool.Students) {

                foreach (Course course in student.Courses) {

                    studentCoursesCodes += string.Format("- {0} -", course.Code);
                }

                ctrlStudentList.Items.Add(string.Format("{0} \t {1} \t {2} \t {3} \t {4}", student.Name, student.Surname, student.Age, student.RegistrationNumber, studentCoursesCodes));

                studentCoursesCodes = string.Empty;
            }
        }

        private void RefreshProfessorList() {

            ctrlProfessorList.Items.Clear();

            string professorCoursesCodes = string.Empty;

            foreach (Professor professor in CodingSchool.Professors) {

                foreach (Course course in professor.Courses) {

                    professorCoursesCodes = professorCoursesCodes + string.Format("- {0} -", course.Code);
                }

                ctrlProfessorList.Items.Add(string.Format("{0} \t {1} \t {2} \t {3} \t {4}", professor.Name, professor.Surname, professor.Age, professor.Rank, professorCoursesCodes));

                professorCoursesCodes = string.Empty;
            }
        }

        private void ctrlSerialize_Click(object sender, EventArgs e) {

            SerializeToJson(CodingSchool);
        }

        private void SerializeToJson(object objectToBeSerialized) {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(objectToBeSerialized);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            File.WriteAllText(path, data);
        }

        private void DeserializeFromJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            string data = string.Empty;

            try {

                data = File.ReadAllText(path);

                CodingSchool = serializer.Deserialize<University>(data);
            }
            catch (Exception) {

                File.Create(path).Dispose();

                CodingSchool = new University() {

                    Professors = new List<Professor>(),
                    Students = new List<Student>(),
                    Courses = new List<Course>()
                };

                SerializeToJson(CodingSchool);

                //CodingSchool = null;

                //data = File.ReadAllText(path);

                //CodingSchool = serializer.Deserialize<University>(data);
            }
        }

        private void ctrlAddCourse_Click(object sender, EventArgs e) {

            AddCourse();

            RefreshCourseList();
        }

        private void ctrlAddStudent_Click(object sender, EventArgs e) {

            AddStudent();

            RefreshStudentList();
        }

        private void ctrlAddProfessor_Click(object sender, EventArgs e) {

            AddProfessor();

            RefreshProfessorList();
        }

        private void ctrlExit_Click(object sender, EventArgs e) {

            Application.Exit();
        }
    }
}
