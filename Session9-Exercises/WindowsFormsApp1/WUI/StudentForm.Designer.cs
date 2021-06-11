
namespace WindowsFormsApp1 {
    partial class StudentForm {
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
            this.ctrlCancel = new System.Windows.Forms.Button();
            this.ctrlOK = new System.Windows.Forms.Button();
            this.CtrlStudentIDLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlID = new DevExpress.XtraEditors.TextEdit();
            this.ctrlRegistrationNumber = new DevExpress.XtraEditors.SpinEdit();
            this.CtrlStudentRegistrationNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlAge = new DevExpress.XtraEditors.SpinEdit();
            this.CtrlStudentAgeLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlStudentNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCoursesLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCourses = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegistrationNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(696, 501);
            this.ctrlCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(127, 39);
            this.ctrlCancel.TabIndex = 4;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(562, 501);
            this.ctrlOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(127, 39);
            this.ctrlOK.TabIndex = 3;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // CtrlStudentIDLabel
            // 
            this.CtrlStudentIDLabel.Location = new System.Drawing.Point(96, 60);
            this.CtrlStudentIDLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlStudentIDLabel.Name = "CtrlStudentIDLabel";
            this.CtrlStudentIDLabel.Size = new System.Drawing.Size(12, 16);
            this.CtrlStudentIDLabel.TabIndex = 26;
            this.CtrlStudentIDLabel.Text = "ID";
            // 
            // ctrlID
            // 
            this.ctrlID.Enabled = false;
            this.ctrlID.Location = new System.Drawing.Point(272, 57);
            this.ctrlID.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlID.Name = "ctrlID";
            this.ctrlID.Size = new System.Drawing.Size(307, 22);
            this.ctrlID.TabIndex = 25;
            // 
            // ctrlRegistrationNumber
            // 
            this.ctrlRegistrationNumber.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlRegistrationNumber.Location = new System.Drawing.Point(272, 322);
            this.ctrlRegistrationNumber.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlRegistrationNumber.Name = "ctrlRegistrationNumber";
            this.ctrlRegistrationNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlRegistrationNumber.Properties.IsFloatValue = false;
            this.ctrlRegistrationNumber.Properties.MaskSettings.Set("mask", "N00");
            this.ctrlRegistrationNumber.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ctrlRegistrationNumber.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlRegistrationNumber.Size = new System.Drawing.Size(156, 24);
            this.ctrlRegistrationNumber.TabIndex = 24;
            // 
            // CtrlStudentRegistrationNumberLabel
            // 
            this.CtrlStudentRegistrationNumberLabel.Location = new System.Drawing.Point(93, 326);
            this.CtrlStudentRegistrationNumberLabel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CtrlStudentRegistrationNumberLabel.Name = "CtrlStudentRegistrationNumberLabel";
            this.CtrlStudentRegistrationNumberLabel.Size = new System.Drawing.Size(117, 16);
            this.CtrlStudentRegistrationNumberLabel.TabIndex = 23;
            this.CtrlStudentRegistrationNumberLabel.Text = "Registration Number";
            // 
            // ctrlAge
            // 
            this.ctrlAge.EditValue = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ctrlAge.Location = new System.Drawing.Point(272, 263);
            this.ctrlAge.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlAge.Name = "ctrlAge";
            this.ctrlAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlAge.Properties.IsFloatValue = false;
            this.ctrlAge.Properties.MaskSettings.Set("mask", "N00");
            this.ctrlAge.Properties.MaxValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.ctrlAge.Properties.MinValue = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ctrlAge.Size = new System.Drawing.Size(156, 24);
            this.ctrlAge.TabIndex = 22;
            // 
            // CtrlStudentAgeLabel
            // 
            this.CtrlStudentAgeLabel.Location = new System.Drawing.Point(93, 267);
            this.CtrlStudentAgeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlStudentAgeLabel.Name = "CtrlStudentAgeLabel";
            this.CtrlStudentAgeLabel.Size = new System.Drawing.Size(22, 16);
            this.CtrlStudentAgeLabel.TabIndex = 21;
            this.CtrlStudentAgeLabel.Text = "Age";
            // 
            // CtrlStudentNameLabel
            // 
            this.CtrlStudentNameLabel.Location = new System.Drawing.Point(93, 124);
            this.CtrlStudentNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlStudentNameLabel.Name = "CtrlStudentNameLabel";
            this.CtrlStudentNameLabel.Size = new System.Drawing.Size(33, 16);
            this.CtrlStudentNameLabel.TabIndex = 20;
            this.CtrlStudentNameLabel.Text = "Name";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(272, 118);
            this.ctrlName.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(307, 22);
            this.ctrlName.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(93, 191);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 16);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Surname";
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(272, 185);
            this.ctrlSurname.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(307, 22);
            this.ctrlSurname.TabIndex = 27;
            // 
            // ctrlCoursesLabel
            // 
            this.ctrlCoursesLabel.Location = new System.Drawing.Point(93, 380);
            this.ctrlCoursesLabel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ctrlCoursesLabel.Name = "ctrlCoursesLabel";
            this.ctrlCoursesLabel.Size = new System.Drawing.Size(46, 16);
            this.ctrlCoursesLabel.TabIndex = 35;
            this.ctrlCoursesLabel.Text = "Courses";
            // 
            // ctrlCourses
            // 
            this.ctrlCourses.Location = new System.Drawing.Point(272, 376);
            this.ctrlCourses.Name = "ctrlCourses";
            this.ctrlCourses.Size = new System.Drawing.Size(189, 110);
            this.ctrlCourses.TabIndex = 34;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 555);
            this.Controls.Add(this.ctrlCoursesLabel);
            this.Controls.Add(this.ctrlCourses);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.CtrlStudentIDLabel);
            this.Controls.Add(this.ctrlID);
            this.Controls.Add(this.ctrlRegistrationNumber);
            this.Controls.Add(this.CtrlStudentRegistrationNumberLabel);
            this.Controls.Add(this.ctrlAge);
            this.Controls.Add(this.CtrlStudentAgeLabel);
            this.Controls.Add(this.CtrlStudentNameLabel);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlRegistrationNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlCancel;
        private System.Windows.Forms.Button ctrlOK;
        private DevExpress.XtraEditors.LabelControl CtrlStudentIDLabel;
        private DevExpress.XtraEditors.TextEdit ctrlID;
        private DevExpress.XtraEditors.SpinEdit ctrlRegistrationNumber;
        private DevExpress.XtraEditors.LabelControl CtrlStudentRegistrationNumberLabel;
        private DevExpress.XtraEditors.SpinEdit ctrlAge;
        private DevExpress.XtraEditors.LabelControl CtrlStudentAgeLabel;
        private DevExpress.XtraEditors.LabelControl CtrlStudentNameLabel;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.LabelControl ctrlCoursesLabel;
        public DevExpress.XtraEditors.CheckedListBoxControl ctrlCourses;
    }
}