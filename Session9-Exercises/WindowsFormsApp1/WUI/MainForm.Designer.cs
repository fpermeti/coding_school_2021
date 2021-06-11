
namespace WindowsFormsApp1 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ctrlAddStudent = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ctrlStudentList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlSerialize = new System.Windows.Forms.Button();
            this.ctrlDeserialize = new System.Windows.Forms.Button();
            this.ctrlCourseList = new DevExpress.XtraEditors.ListBoxControl();
            this.ctrlProfessorList = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorList)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(978, 566);
            this.ctrlExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(167, 39);
            this.ctrlExit.TabIndex = 2;
            this.ctrlExit.Text = "Exit";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 104);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 94);
            this.button3.TabIndex = 7;
            this.button3.Text = "Add Course...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ctrlAddCourse_Click);
            // 
            // ctrlAddStudent
            // 
            this.ctrlAddStudent.Location = new System.Drawing.Point(28, 240);
            this.ctrlAddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlAddStudent.Name = "ctrlAddStudent";
            this.ctrlAddStudent.Size = new System.Drawing.Size(132, 110);
            this.ctrlAddStudent.TabIndex = 8;
            this.ctrlAddStudent.Text = "Add Student...";
            this.ctrlAddStudent.UseVisualStyleBackColor = true;
            this.ctrlAddStudent.Click += new System.EventHandler(this.ctrlAddStudent_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 409);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 110);
            this.button5.TabIndex = 9;
            this.button5.Text = "Add Professor...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ctrlAddProfessor_Click);
            // 
            // ctrlStudentList
            // 
            this.ctrlStudentList.Location = new System.Drawing.Point(201, 240);
            this.ctrlStudentList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlStudentList.Name = "ctrlStudentList";
            this.ctrlStudentList.Size = new System.Drawing.Size(944, 110);
            this.ctrlStudentList.TabIndex = 10;
            // 
            // ctrlSave
            // 
            this.ctrlSave.Enabled = false;
            this.ctrlSave.Location = new System.Drawing.Point(805, 566);
            this.ctrlSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlSave.Name = "ctrlSave";
            this.ctrlSave.Size = new System.Drawing.Size(167, 39);
            this.ctrlSave.TabIndex = 11;
            this.ctrlSave.Text = "Save...";
            this.ctrlSave.UseVisualStyleBackColor = true;
            this.ctrlSave.Click += new System.EventHandler(this.ctrlSave_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(631, 566);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ctrlLoad_Click);
            // 
            // ctrlSerialize
            // 
            this.ctrlSerialize.Location = new System.Drawing.Point(427, 566);
            this.ctrlSerialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlSerialize.Name = "ctrlSerialize";
            this.ctrlSerialize.Size = new System.Drawing.Size(167, 39);
            this.ctrlSerialize.TabIndex = 13;
            this.ctrlSerialize.Text = "Serialize to Json";
            this.ctrlSerialize.UseVisualStyleBackColor = true;
            this.ctrlSerialize.Click += new System.EventHandler(this.ctrlSerialize_Click);
            // 
            // ctrlDeserialize
            // 
            this.ctrlDeserialize.Location = new System.Drawing.Point(254, 566);
            this.ctrlDeserialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlDeserialize.Name = "ctrlDeserialize";
            this.ctrlDeserialize.Size = new System.Drawing.Size(167, 39);
            this.ctrlDeserialize.TabIndex = 14;
            this.ctrlDeserialize.Text = "Deserialize from Json";
            this.ctrlDeserialize.UseVisualStyleBackColor = true;
            this.ctrlDeserialize.Click += new System.EventHandler(this.ctrlDeserialize_Click);
            // 
            // ctrlCourseList
            // 
            this.ctrlCourseList.Location = new System.Drawing.Point(201, 101);
            this.ctrlCourseList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlCourseList.Name = "ctrlCourseList";
            this.ctrlCourseList.Size = new System.Drawing.Size(944, 97);
            this.ctrlCourseList.TabIndex = 15;
            // 
            // ctrlProfessorList
            // 
            this.ctrlProfessorList.Location = new System.Drawing.Point(201, 409);
            this.ctrlProfessorList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlProfessorList.Name = "ctrlProfessorList";
            this.ctrlProfessorList.Size = new System.Drawing.Size(944, 110);
            this.ctrlProfessorList.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 618);
            this.Controls.Add(this.ctrlProfessorList);
            this.Controls.Add(this.ctrlCourseList);
            this.Controls.Add(this.ctrlDeserialize);
            this.Controls.Add(this.ctrlSerialize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSave);
            this.Controls.Add(this.ctrlStudentList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ctrlAddStudent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ctrlExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ctrlAddStudent;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraEditors.ListBoxControl ctrlStudentList;
        private System.Windows.Forms.Button ctrlSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ctrlSerialize;
        private System.Windows.Forms.Button ctrlDeserialize;
        private DevExpress.XtraEditors.ListBoxControl ctrlCourseList;
        private DevExpress.XtraEditors.ListBoxControl ctrlProfessorList;
    }
}

