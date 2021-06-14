using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {
    public partial class MDIMainForm : Form {

        private const string _JsonFile = "UniversityData.json";

        private University CodingSchool = null;



        public MDIMainForm() {
            InitializeComponent();
        }

        private void ctrlExit_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            Application.Exit();
        }

        private void ctrlAddStudent_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddStudent();

            GetStudentsList();
        }

        private void ctrlAddCourse_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddCourse();

            GetCoursesList();
        }

        private void ctrlViewCourses_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            ViewForm viewForm = new ViewForm {
                MdiParent = this,


                ViewData = GetCoursesList()
            };

            viewForm.Show();

        }

        private void ctrlViewStudents_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            ViewForm viewForm = new ViewForm {
                MdiParent = this,


                ViewData = GetStudentsList()
            };

            viewForm.Show();
        }

        private void ctrlAddProfessor_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            AddProfessor();

            GetProfessorsList();
        }

        private void ctrlViewProfessors_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            ViewForm viewForm = new ViewForm {
                MdiParent = this,


                ViewData = GetProfessorsList()
            };

            viewForm.Show();
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

            if (File.Exists(path)) {

                data = File.ReadAllText(path);

                CodingSchool = serializer.Deserialize<University>(data);
            }
            else {


                File.Create(path).Dispose();

                CodingSchool = new University() {

                    Professors = new List<Professor>(),
                    Students = new List<Student>(),
                    Courses = new List<Course>()
                };

                SerializeToJson(CodingSchool);

            }





        }


        private void RetrieveObjectFromJson() {

            //the program attempts to deserialize object from json file
            //if the file does not exist, then it creates an empty file
            //and serializes an empty object to the json file
            DeserializeFromJson();

            GetCoursesList();

            GetStudentsList();

            GetProfessorsList();
        }



        private void AddCourse() {

            Course course = new Course();

            CourseForm courseForm = new CourseForm() {

                NewUniversity = CodingSchool,

                NewCourse = course
            };

            courseForm.Show();



        }

        private void AddStudent() {

            Student student = new Student();

            StudentForm studentForm = new StudentForm() {

                NewUniversity = CodingSchool,

                NewStudent = student
            };

            //popuate CheckedListBox
            foreach (Course course in CodingSchool.Courses) {

                studentForm.ctrlCourses.Items.Add(course.Code);
            }

            studentForm.Show();


        }

        private void AddProfessor() {

            Professor professor = new Professor();

            ProfessorForm professorForm = new ProfessorForm() {

                NewUniversity = CodingSchool,

                NewProfessor = professor
            };

            //popuate CheckedListBox
            foreach (Course course in CodingSchool.Courses) {

                professorForm.ctrlCourses.Items.Add(course.Code);
            }

            professorForm.Show();



        }

        private List<string> GetCoursesList() {


            List<string> coursesList = new List<string>();


            foreach (Course course in CodingSchool.Courses) {

                coursesList.Add(string.Format("Code={0} \t Subject={1} \t Hours={2} \t Category={3}", course.Code, course.Subject, course.Hours, course.Category));
            }

            return coursesList;

        }

        private List<string> GetStudentsList() {



            List<string> studentsList = new List<string>();


            string studentCoursesCodes = string.Empty;

            foreach (Student student in CodingSchool.Students) {

                foreach (Course course in student.Courses) {

                    studentCoursesCodes += string.Format("[ {0} ]", course.Code);
                }

                studentsList.Add(string.Format("Name={0} \t Surname={1} \t Age={2} \t Registration Number={3} \t Courses Codes={4}", student.Name, student.Surname, student.Age, student.RegistrationNumber, studentCoursesCodes));

                studentCoursesCodes = string.Empty;
            }

            return studentsList;

        }

        private List<string> GetProfessorsList() {


            List<string> professorsList = new List<string>();


            string professorCoursesCodes = string.Empty;

            foreach (Professor professor in CodingSchool.Professors) {

                foreach (Course course in professor.Courses) {

                    professorCoursesCodes = professorCoursesCodes + string.Format("[ {0} ]", course.Code);
                }

                professorsList.Add(string.Format("Name={0} \t Surname={1} \t Age={2} \t Rank={3} \t Courses Codes={4}", professor.Name, professor.Surname, professor.Age, professor.Rank, professorCoursesCodes));

                professorCoursesCodes = string.Empty;
            }
            return professorsList;


        }

        private void MDIMainForm_Load(object sender, EventArgs e) {

            RetrieveObjectFromJson();
        }

        private void MDIMainForm_Activated(object sender, EventArgs e) {

            SerializeToJson(CodingSchool);

        }
    }
}
