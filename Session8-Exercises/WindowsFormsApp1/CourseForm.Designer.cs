
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.CtrlCourseCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CtrlCourseSubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CtrlCourseCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlCourseSubjectLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlCourseIDLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlCourseIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseSubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseIDTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(247, 217);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 30);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.CtrlCourseOK_click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(387, 217);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 30);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.CtrlCourseCancel_click);
            // 
            // CtrlCourseCodeTextEdit
            // 
            this.CtrlCourseCodeTextEdit.Location = new System.Drawing.Point(161, 69);
            this.CtrlCourseCodeTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseCodeTextEdit.Name = "CtrlCourseCodeTextEdit";
            this.CtrlCourseCodeTextEdit.Size = new System.Drawing.Size(307, 22);
            this.CtrlCourseCodeTextEdit.TabIndex = 2;
            // 
            // CtrlCourseSubjectTextEdit
            // 
            this.CtrlCourseSubjectTextEdit.Location = new System.Drawing.Point(161, 133);
            this.CtrlCourseSubjectTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseSubjectTextEdit.Name = "CtrlCourseSubjectTextEdit";
            this.CtrlCourseSubjectTextEdit.Size = new System.Drawing.Size(307, 22);
            this.CtrlCourseSubjectTextEdit.TabIndex = 3;
            // 
            // CtrlCourseCodeLabel
            // 
            this.CtrlCourseCodeLabel.Location = new System.Drawing.Point(60, 72);
            this.CtrlCourseCodeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseCodeLabel.Name = "CtrlCourseCodeLabel";
            this.CtrlCourseCodeLabel.Size = new System.Drawing.Size(29, 16);
            this.CtrlCourseCodeLabel.TabIndex = 4;
            this.CtrlCourseCodeLabel.Text = "Code";
            // 
            // CtrlCourseSubjectLabel
            // 
            this.CtrlCourseSubjectLabel.Location = new System.Drawing.Point(60, 135);
            this.CtrlCourseSubjectLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseSubjectLabel.Name = "CtrlCourseSubjectLabel";
            this.CtrlCourseSubjectLabel.Size = new System.Drawing.Size(43, 16);
            this.CtrlCourseSubjectLabel.TabIndex = 5;
            this.CtrlCourseSubjectLabel.Text = "Subject";
            // 
            // CtrlCourseIDLabel
            // 
            this.CtrlCourseIDLabel.Location = new System.Drawing.Point(60, 16);
            this.CtrlCourseIDLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseIDLabel.Name = "CtrlCourseIDLabel";
            this.CtrlCourseIDLabel.Size = new System.Drawing.Size(12, 16);
            this.CtrlCourseIDLabel.TabIndex = 7;
            this.CtrlCourseIDLabel.Text = "ID";
            // 
            // CtrlCourseIDTextEdit
            // 
            this.CtrlCourseIDTextEdit.Enabled = false;
            this.CtrlCourseIDTextEdit.Location = new System.Drawing.Point(161, 13);
            this.CtrlCourseIDTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlCourseIDTextEdit.Name = "CtrlCourseIDTextEdit";
            this.CtrlCourseIDTextEdit.Size = new System.Drawing.Size(307, 22);
            this.CtrlCourseIDTextEdit.TabIndex = 6;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 309);
            this.Controls.Add(this.CtrlCourseIDLabel);
            this.Controls.Add(this.CtrlCourseIDTextEdit);
            this.Controls.Add(this.CtrlCourseSubjectLabel);
            this.Controls.Add(this.CtrlCourseCodeLabel);
            this.Controls.Add(this.CtrlCourseSubjectTextEdit);
            this.Controls.Add(this.CtrlCourseCodeTextEdit);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseSubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlCourseIDTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit CtrlCourseCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit CtrlCourseSubjectTextEdit;
        private DevExpress.XtraEditors.LabelControl CtrlCourseCodeLabel;
        private DevExpress.XtraEditors.LabelControl CtrlCourseSubjectLabel;
        private DevExpress.XtraEditors.LabelControl CtrlCourseIDLabel;
        private DevExpress.XtraEditors.TextEdit CtrlCourseIDTextEdit;
    }
}