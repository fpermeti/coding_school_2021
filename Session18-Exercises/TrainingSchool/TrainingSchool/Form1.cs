using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingSchool.EF.Context;
using TrainingSchool.Model;

namespace TrainingSchool
{
    public partial class Form1 : Form
    {


        private TrainingSchoolContext _TrainingSchoolContext;

       



        public Form1()
        {
            InitializeComponent();


            bindingSource1.DataSource = typeof(Student);


            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Surname", HeaderText = "Surname" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "BirthDate", HeaderText = "BirthDate" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Address", HeaderText = "Address" });



            dataGridView1.DataSource = bindingSource1;

            textBox1.DataBindings.Add("Text", bindingSource1, "Name");
            textBox2.DataBindings.Add("Text", bindingSource1, "Surname");
            dateTimePicker1.DataBindings.Add("Text", bindingSource1, "BirthDate");
            textBox3.DataBindings.Add("Text", bindingSource1, "Address");




            bindingSource2.DataSource = typeof(Course);

            dataGridView2.AutoGenerateColumns = false;

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Title", HeaderText = "Title" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Category", HeaderText = "Category" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Date", HeaderText = "Date" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Duration", HeaderText = "Duration" });



            dataGridView2.DataSource = bindingSource2;

            textBox6.DataBindings.Add("Text", bindingSource2, "Title");
            textBox5.DataBindings.Add("Text", bindingSource2, "Category");
            dateTimePicker2.DataBindings.Add("Text", bindingSource2, "Date");
            numericUpDown1.DataBindings.Add("Value", bindingSource2, "Duration");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var optionsBuilder = new DbContextOptionsBuilder<TrainingSchoolContext>();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBTrainingSchool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            _TrainingSchoolContext = new TrainingSchoolContext(optionsBuilder.Options);


            RefreshStudentsGrid();
            RefreshCoursesGrid();
        }





        private void RefreshStudentsGrid()
        {
            bindingSource1.Clear();
            _TrainingSchoolContext.ChangeTracker.Clear();
            foreach (var student in _TrainingSchoolContext.Students.ToList())
            {
                bindingSource1.Add(student);
            }
        }

        private void RefreshCoursesGrid()
        {
            bindingSource2.Clear();
            _TrainingSchoolContext.ChangeTracker.Clear();
            foreach (var course in _TrainingSchoolContext.Courses.ToList())
            {
                bindingSource2.Add(course);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _TrainingSchoolContext.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var student = bindingSource1.Current as Student;
            if (student is null)
                return;

            bindingSource1.RemoveCurrent();
            _TrainingSchoolContext.Students.Remove(student);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var course = bindingSource2.Current as Course;
            if (course is null)
                return;

            bindingSource2.RemoveCurrent();
            _TrainingSchoolContext.Courses.Remove(course);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newStudent = new Student();
            newStudent.Name = "New";

            bindingSource1.Insert(0, newStudent);
            _TrainingSchoolContext.Students.Add(newStudent);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newCourse = new Course();
            newCourse.Title = "New";

            bindingSource2.Insert(0, newCourse);
            _TrainingSchoolContext.Courses.Add(newCourse);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await _TrainingSchoolContext.SaveChangesAsync();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await _TrainingSchoolContext.SaveChangesAsync();
        }
    }
}
