
namespace WindowsFormsApp1 {
    partial class CourseForm {
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
            this.CtrlCourseSubjectLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlCourseCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSubject = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlHours = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlHoursLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCategoryLabel = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCategory = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlCourseSubjectLabel
            // 
            this.CtrlCourseSubjectLabel.Location = new System.Drawing.Point(34, 100);
            this.CtrlCourseSubjectLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseSubjectLabel.Name = "CtrlCourseSubjectLabel";
            this.CtrlCourseSubjectLabel.Size = new System.Drawing.Size(43, 16);
            this.CtrlCourseSubjectLabel.TabIndex = 13;
            this.CtrlCourseSubjectLabel.Text = "Subject";
            // 
            // CtrlCourseCodeLabel
            // 
            this.CtrlCourseCodeLabel.Location = new System.Drawing.Point(34, 37);
            this.CtrlCourseCodeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseCodeLabel.Name = "CtrlCourseCodeLabel";
            this.CtrlCourseCodeLabel.Size = new System.Drawing.Size(29, 16);
            this.CtrlCourseCodeLabel.TabIndex = 12;
            this.CtrlCourseCodeLabel.Text = "Code";
            // 
            // ctrlSubject
            // 
            this.ctrlSubject.Location = new System.Drawing.Point(135, 98);
            this.ctrlSubject.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSubject.Name = "ctrlSubject";
            this.ctrlSubject.Size = new System.Drawing.Size(307, 22);
            this.ctrlSubject.TabIndex = 11;
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(135, 34);
            this.ctrlCode.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(307, 22);
            this.ctrlCode.TabIndex = 10;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(349, 316);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 30);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(248, 316);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 30);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlHours
            // 
            this.ctrlHours.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlHours.Location = new System.Drawing.Point(135, 170);
            this.ctrlHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlHours.Properties.IsFloatValue = false;
            this.ctrlHours.Properties.MaskSettings.Set("mask", "N00");
            this.ctrlHours.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ctrlHours.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlHours.Size = new System.Drawing.Size(307, 24);
            this.ctrlHours.TabIndex = 25;
            // 
            // ctrlHoursLabel
            // 
            this.ctrlHoursLabel.Location = new System.Drawing.Point(34, 174);
            this.ctrlHoursLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlHoursLabel.Name = "ctrlHoursLabel";
            this.ctrlHoursLabel.Size = new System.Drawing.Size(33, 16);
            this.ctrlHoursLabel.TabIndex = 26;
            this.ctrlHoursLabel.Text = "Hours";
            // 
            // ctrlCategoryLabel
            // 
            this.ctrlCategoryLabel.Location = new System.Drawing.Point(34, 250);
            this.ctrlCategoryLabel.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCategoryLabel.Name = "ctrlCategoryLabel";
            this.ctrlCategoryLabel.Size = new System.Drawing.Size(51, 16);
            this.ctrlCategoryLabel.TabIndex = 27;
            this.ctrlCategoryLabel.Text = "Category";
            // 
            // ctrlCategory
            // 
            this.ctrlCategory.Location = new System.Drawing.Point(135, 240);
            this.ctrlCategory.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlCategory.Name = "ctrlCategory";
            this.ctrlCategory.Size = new System.Drawing.Size(307, 36);
            this.ctrlCategory.TabIndex = 28;
            // 
            // CourseForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 374);
            this.Controls.Add(this.ctrlCategory);
            this.Controls.Add(this.ctrlCategoryLabel);
            this.Controls.Add(this.ctrlHoursLabel);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.CtrlCourseSubjectLabel);
            this.Controls.Add(this.CtrlCourseCodeLabel);
            this.Controls.Add(this.ctrlSubject);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl CtrlCourseSubjectLabel;
        private DevExpress.XtraEditors.LabelControl CtrlCourseCodeLabel;
        private DevExpress.XtraEditors.TextEdit ctrlSubject;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SpinEdit ctrlHours;
        private DevExpress.XtraEditors.LabelControl ctrlHoursLabel;
        private DevExpress.XtraEditors.LabelControl ctrlCategoryLabel;
        private DevExpress.XtraEditors.DropDownButton ctrlCategory;
    }
}