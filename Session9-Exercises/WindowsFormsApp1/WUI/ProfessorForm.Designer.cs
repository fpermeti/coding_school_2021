
namespace WindowsFormsApp1 {
    partial class ProfessorForm {
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
            this.CtrlProfessorRankLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlRank = new DevExpress.XtraEditors.DropDownButton();
            this.ctrlAge = new DevExpress.XtraEditors.SpinEdit();
            this.CtrlProfessorAgeLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlProfessorNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlCourses = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.ctrlCoursesLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSurnameLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlProfessorRankLabel
            // 
            this.CtrlProfessorRankLabel.Location = new System.Drawing.Point(37, 178);
            this.CtrlProfessorRankLabel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CtrlProfessorRankLabel.Name = "CtrlProfessorRankLabel";
            this.CtrlProfessorRankLabel.Size = new System.Drawing.Size(29, 16);
            this.CtrlProfessorRankLabel.TabIndex = 29;
            this.CtrlProfessorRankLabel.Text = "Rank";
            // 
            // ctrlRank
            // 
            this.ctrlRank.Location = new System.Drawing.Point(138, 168);
            this.ctrlRank.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlRank.Name = "ctrlRank";
            this.ctrlRank.Size = new System.Drawing.Size(363, 36);
            this.ctrlRank.TabIndex = 28;
            // 
            // ctrlAge
            // 
            this.ctrlAge.EditValue = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ctrlAge.Location = new System.Drawing.Point(138, 124);
            this.ctrlAge.Margin = new System.Windows.Forms.Padding(5);
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
            25,
            0,
            0,
            0});
            this.ctrlAge.Size = new System.Drawing.Size(363, 24);
            this.ctrlAge.TabIndex = 27;
            // 
            // CtrlProfessorAgeLabel
            // 
            this.CtrlProfessorAgeLabel.Location = new System.Drawing.Point(37, 128);
            this.CtrlProfessorAgeLabel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CtrlProfessorAgeLabel.Name = "CtrlProfessorAgeLabel";
            this.CtrlProfessorAgeLabel.Size = new System.Drawing.Size(22, 16);
            this.CtrlProfessorAgeLabel.TabIndex = 26;
            this.CtrlProfessorAgeLabel.Text = "Age";
            // 
            // CtrlProfessorNameLabel
            // 
            this.CtrlProfessorNameLabel.Location = new System.Drawing.Point(40, 43);
            this.CtrlProfessorNameLabel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CtrlProfessorNameLabel.Name = "CtrlProfessorNameLabel";
            this.CtrlProfessorNameLabel.Size = new System.Drawing.Size(33, 16);
            this.CtrlProfessorNameLabel.TabIndex = 25;
            this.CtrlProfessorNameLabel.Text = "Name";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(138, 40);
            this.ctrlName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(363, 22);
            this.ctrlName.TabIndex = 24;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(408, 381);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 30);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(297, 381);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 30);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlCourses
            // 
            this.ctrlCourses.Location = new System.Drawing.Point(138, 232);
            this.ctrlCourses.Name = "ctrlCourses";
            this.ctrlCourses.Size = new System.Drawing.Size(363, 110);
            this.ctrlCourses.TabIndex = 32;
            // 
            // ctrlCoursesLabel
            // 
            this.ctrlCoursesLabel.Location = new System.Drawing.Point(41, 236);
            this.ctrlCoursesLabel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ctrlCoursesLabel.Name = "ctrlCoursesLabel";
            this.ctrlCoursesLabel.Size = new System.Drawing.Size(46, 16);
            this.ctrlCoursesLabel.TabIndex = 33;
            this.ctrlCoursesLabel.Text = "Courses";
            // 
            // ctrlSurnameLabel
            // 
            this.ctrlSurnameLabel.Location = new System.Drawing.Point(40, 88);
            this.ctrlSurnameLabel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ctrlSurnameLabel.Name = "ctrlSurnameLabel";
            this.ctrlSurnameLabel.Size = new System.Drawing.Size(52, 16);
            this.ctrlSurnameLabel.TabIndex = 35;
            this.ctrlSurnameLabel.Text = "Surname";
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(138, 85);
            this.ctrlSurname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(363, 22);
            this.ctrlSurname.TabIndex = 34;
            // 
            // ProfessorForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 437);
            this.Controls.Add(this.ctrlSurnameLabel);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlCoursesLabel);
            this.Controls.Add(this.ctrlCourses);
            this.Controls.Add(this.CtrlProfessorRankLabel);
            this.Controls.Add(this.ctrlRank);
            this.Controls.Add(this.ctrlAge);
            this.Controls.Add(this.CtrlProfessorAgeLabel);
            this.Controls.Add(this.CtrlProfessorNameLabel);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ProfessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorForm";
            this.Load += new System.EventHandler(this.ProfessorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl CtrlProfessorRankLabel;
        private DevExpress.XtraEditors.DropDownButton ctrlRank;
        private DevExpress.XtraEditors.SpinEdit ctrlAge;
        private DevExpress.XtraEditors.LabelControl CtrlProfessorAgeLabel;
        private DevExpress.XtraEditors.LabelControl CtrlProfessorNameLabel;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl ctrlCoursesLabel;
        private DevExpress.XtraEditors.LabelControl ctrlSurnameLabel;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        public DevExpress.XtraEditors.CheckedListBoxControl ctrlCourses;
    }
}