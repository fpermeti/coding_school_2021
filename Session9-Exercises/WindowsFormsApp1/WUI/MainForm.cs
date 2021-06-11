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

        private const string _TxtFile = "UniversityData.txt";
        private const string _JsonFile = "UniversityData.json";

        University CodingSchool = null;

        List<Student> Students = new List<Student>();
        List<Course> Courses = new List<Course>();
        List<Professor> Professors = new List<Professor>();

        public MainForm() {

            InitializeComponent();
        }

        //as soon as form loads an University object is created
        private void MainForm_Load(object sender, EventArgs e) {

            CodingSchool = new University() {

                Professors = Professors,
                Students = Students,
                Courses = Courses

            };
        }

        private void ctrlAddStudent_Click(object sender, EventArgs e) {

            // Add student using a form
            AddStudent();

            // refresh
            RefreshStudentList();
        }


        private void SerializeToJson(object objectToBeSerialized) {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(objectToBeSerialized);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            File.WriteAllText(path, data);

        }

        private void ctrlExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ctrlSave_Click(object sender, EventArgs e) {

            // Write ...
            WriteToTxt();
        }

        private void ctrlLoad_Click(object sender, EventArgs e) {

            // Read data
            ReadFromTxt();

            // refresh
            RefreshStudentList();
        }

        private void AddStudent() {

            Student student = new Student();

            StudentForm studentForm = new StudentForm();

            studentForm.NewCourses = Courses;

            studentForm.NewStudent = student;

            //popuate CheckedListBox
            foreach (Course course in Courses) {

                studentForm.ctrlCourses.Items.Add(course.Code);
            }

            DialogResult result = studentForm.ShowDialog();

            switch (result) {
                case DialogResult.OK:
                    Students.Add(student);
                    break;

                default:
                    break;
            }
        }

        private void AddProfessor() {

           

            Professor professor = new Professor();

            ProfessorForm professorForm = new ProfessorForm();

            professorForm.NewCourses = Courses;

            professorForm.NewProfessor = professor;

            //popuate CheckedListBox
            foreach (Course course in Courses) {

                professorForm.ctrlCourses.Items.Add(course.Code);
            }

            DialogResult result = professorForm.ShowDialog();

            switch (result) {
                case DialogResult.OK:
                    Professors.Add(professor);
                    break;

                default:
                    break;
            }


        }

        private void AddCourse() {

            Course course = new Course();

            CourseForm courseForm = new CourseForm();

            courseForm.NewCourse = course;

            DialogResult result = courseForm.ShowDialog();

            switch (result) {
                case DialogResult.OK:
                    Courses.Add(course);
                    break;

                default:
                    break;
            }
        }

        private void WriteToTxt() {
            string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

            string data = string.Empty;
            foreach (Student item in Students) {

                data += string.Format("{0};{1};{2};{3}", item.Name, item.Surname, item.RegistrationNumber, Environment.NewLine);
            }


            File.WriteAllText(path, data);
        }


        private void DeserializeFromJson() {


            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            string data = File.ReadAllText(path);

            CodingSchool = serializer.Deserialize<University>(data);

        }

        private void ReadFromTxt() {
            string path = Path.Combine(Environment.CurrentDirectory, _TxtFile);

            string s = File.ReadAllText(path);

            string[] parser = new string[] { Environment.NewLine };

            List<string> dataLines = s.Split(parser, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string line in dataLines) {

                string[] parserLine = new string[] { ";" };

                if (line.Length > 0) {

                    List<string> lineData = line.Split(parserLine, StringSplitOptions.None).ToList();

                    Student student = new Student();

                    student.Name = Convert.ToString(lineData[0]);
                    student.Surname = Convert.ToString(lineData[1]);
                    student.RegistrationNumber = Convert.ToInt32(lineData[2]);

                    Students.Add(student);

                }
            }
        }

        private void RefreshStudentList() {


            ctrlStudentList.Items.Clear();

            string studentCoursesCodes = string.Empty;

        

            foreach (Student student in Students) {

                foreach (Course course in student.Courses) {

                    studentCoursesCodes += string.Format("{0} ", course.Code);

                }
                ctrlStudentList.Items.Add(string.Format("{0} \t {1} \t {2} \t {3} \t {4}", student.Name, student.Surname, student.Age, student.RegistrationNumber, studentCoursesCodes));

            }
        }

        private void RefreshCourseList() {

            ctrlCourseList.Items.Clear();

 
            foreach (Course course in Courses) {

                ctrlCourseList.Items.Add(string.Format("{0} \t {1} \t {2} \t {3}", course.Code, course.Subject, course.Hours, course.Category));
            }
        }

        private void RefreshProfessorList() {

            ctrlProfessorList.Items.Clear();

            string professorCoursesCodes = string.Empty;


            foreach (Professor professor in Professors) {

                foreach (Course course in professor.Courses) {

                    professorCoursesCodes += string.Format("{0} ", course.Code);
                }

                ctrlProfessorList.Items.Add(string.Format("{0} \t {1} \t {2} \t {3} \t {4}", professor.Name, professor.Surname, professor.Age, professor.Rank, professorCoursesCodes));
            }
        }

        private void ctrlSerialize_Click(object sender, EventArgs e) {

            SerializeToJson(CodingSchool);
        }

        private void ctrlDeserialize_Click(object sender, EventArgs e) {

            DeserializeFromJson();

            RefreshStudentList();

            RefreshCourseList();

            RefreshProfessorList();
        }

        private void ctrlAddProfessor_Click(object sender, EventArgs e) {

            AddProfessor();

            RefreshProfessorList();
        }

        private void ctrlAddCourse_Click(object sender, EventArgs e) {

            AddCourse();

            RefreshCourseList();
        }
    }
}
