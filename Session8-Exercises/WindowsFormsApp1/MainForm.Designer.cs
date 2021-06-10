
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
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.CtrlCourseIDListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlCourseCodeListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlCourseSubjectListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlStudentAgeListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlStudentNameListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlStudentIDListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlProfessorAgeListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlProfessorNameListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlProfessorIDListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlStudentRegistrationNumberListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.CtrlProfessorRankListBox = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseIDListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseCodeListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseSubjectListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentAgeListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentNameListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentIDListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorAgeListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorNameListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorIDListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentRegistrationNumberListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorRankListBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Management Application";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(20, 71);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(123, 41);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Add Course...";
            this.simpleButton1.Click += new System.EventHandler(this.CtrlAddCourse_click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(20, 300);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(123, 50);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Add Student...";
            this.simpleButton2.Click += new System.EventHandler(this.CtrlAddStudent_click);
            // 
            // gridControl3
            // 
            this.gridControl3.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.gridControl3.Location = new System.Drawing.Point(69, 1148);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(1757, 290);
            this.gridControl3.TabIndex = 15;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(1775, 2218);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(231, 70);
            this.simpleButton4.TabIndex = 16;
            this.simpleButton4.Text = "Exit";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(20, 530);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(12);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(140, 50);
            this.simpleButton5.TabIndex = 18;
            this.simpleButton5.Text = "Add Professor...";
            this.simpleButton5.Click += new System.EventHandler(this.CtrlAddProfessor_click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(948, 722);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(15);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(84, 32);
            this.simpleButton6.TabIndex = 19;
            this.simpleButton6.Text = "Exit";
            this.simpleButton6.Click += new System.EventHandler(this.CtrlExit_click);
            // 
            // CtrlCourseIDListBox
            // 
            this.CtrlCourseIDListBox.Location = new System.Drawing.Point(174, 71);
            this.CtrlCourseIDListBox.Name = "CtrlCourseIDListBox";
            this.CtrlCourseIDListBox.Size = new System.Drawing.Size(286, 178);
            this.CtrlCourseIDListBox.TabIndex = 20;
            // 
            // CtrlCourseCodeListBox
            // 
            this.CtrlCourseCodeListBox.Location = new System.Drawing.Point(470, 71);
            this.CtrlCourseCodeListBox.Name = "CtrlCourseCodeListBox";
            this.CtrlCourseCodeListBox.Size = new System.Drawing.Size(195, 178);
            this.CtrlCourseCodeListBox.TabIndex = 21;
            // 
            // CtrlCourseSubjectListBox
            // 
            this.CtrlCourseSubjectListBox.Location = new System.Drawing.Point(671, 71);
            this.CtrlCourseSubjectListBox.Name = "CtrlCourseSubjectListBox";
            this.CtrlCourseSubjectListBox.Size = new System.Drawing.Size(211, 178);
            this.CtrlCourseSubjectListBox.TabIndex = 22;
            // 
            // CtrlStudentAgeListBox
            // 
            this.CtrlStudentAgeListBox.Location = new System.Drawing.Point(653, 300);
            this.CtrlStudentAgeListBox.Name = "CtrlStudentAgeListBox";
            this.CtrlStudentAgeListBox.Size = new System.Drawing.Size(185, 178);
            this.CtrlStudentAgeListBox.TabIndex = 25;
            // 
            // CtrlStudentNameListBox
            // 
            this.CtrlStudentNameListBox.Location = new System.Drawing.Point(478, 300);
            this.CtrlStudentNameListBox.Name = "CtrlStudentNameListBox";
            this.CtrlStudentNameListBox.Size = new System.Drawing.Size(169, 178);
            this.CtrlStudentNameListBox.TabIndex = 24;
            // 
            // CtrlStudentIDListBox
            // 
            this.CtrlStudentIDListBox.Location = new System.Drawing.Point(174, 300);
            this.CtrlStudentIDListBox.Name = "CtrlStudentIDListBox";
            this.CtrlStudentIDListBox.Size = new System.Drawing.Size(298, 178);
            this.CtrlStudentIDListBox.TabIndex = 23;
            // 
            // CtrlProfessorAgeListBox
            // 
            this.CtrlProfessorAgeListBox.Location = new System.Drawing.Point(675, 530);
            this.CtrlProfessorAgeListBox.Name = "CtrlProfessorAgeListBox";
            this.CtrlProfessorAgeListBox.Size = new System.Drawing.Size(163, 178);
            this.CtrlProfessorAgeListBox.TabIndex = 28;
            // 
            // CtrlProfessorNameListBox
            // 
            this.CtrlProfessorNameListBox.Location = new System.Drawing.Point(487, 530);
            this.CtrlProfessorNameListBox.Name = "CtrlProfessorNameListBox";
            this.CtrlProfessorNameListBox.Size = new System.Drawing.Size(178, 178);
            this.CtrlProfessorNameListBox.TabIndex = 27;
            // 
            // CtrlProfessorIDListBox
            // 
            this.CtrlProfessorIDListBox.Location = new System.Drawing.Point(186, 530);
            this.CtrlProfessorIDListBox.Name = "CtrlProfessorIDListBox";
            this.CtrlProfessorIDListBox.Size = new System.Drawing.Size(295, 178);
            this.CtrlProfessorIDListBox.TabIndex = 26;
            // 
            // CtrlStudentRegistrationNumberListBox
            // 
            this.CtrlStudentRegistrationNumberListBox.Location = new System.Drawing.Point(844, 300);
            this.CtrlStudentRegistrationNumberListBox.Name = "CtrlStudentRegistrationNumberListBox";
            this.CtrlStudentRegistrationNumberListBox.Size = new System.Drawing.Size(188, 178);
            this.CtrlStudentRegistrationNumberListBox.TabIndex = 29;
            // 
            // CtrlProfessorRankListBox
            // 
            this.CtrlProfessorRankListBox.Location = new System.Drawing.Point(844, 530);
            this.CtrlProfessorRankListBox.Name = "CtrlProfessorRankListBox";
            this.CtrlProfessorRankListBox.Size = new System.Drawing.Size(188, 178);
            this.CtrlProfessorRankListBox.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 778);
            this.Controls.Add(this.CtrlProfessorRankListBox);
            this.Controls.Add(this.CtrlStudentRegistrationNumberListBox);
            this.Controls.Add(this.CtrlProfessorAgeListBox);
            this.Controls.Add(this.CtrlProfessorNameListBox);
            this.Controls.Add(this.CtrlProfessorIDListBox);
            this.Controls.Add(this.CtrlStudentAgeListBox);
            this.Controls.Add(this.CtrlStudentNameListBox);
            this.Controls.Add(this.CtrlStudentIDListBox);
            this.Controls.Add(this.CtrlCourseSubjectListBox);
            this.Controls.Add(this.CtrlCourseCodeListBox);
            this.Controls.Add(this.CtrlCourseIDListBox);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseIDListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseCodeListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseSubjectListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentAgeListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentNameListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentIDListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorAgeListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorNameListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorIDListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentRegistrationNumberListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorRankListBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        public DevExpress.XtraEditors.ListBoxControl CtrlCourseIDListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlCourseCodeListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlCourseSubjectListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlStudentAgeListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlStudentNameListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlStudentIDListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlProfessorAgeListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlProfessorNameListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlProfessorIDListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlStudentRegistrationNumberListBox;
        public DevExpress.XtraEditors.ListBoxControl CtrlProfessorRankListBox;
    }
}

