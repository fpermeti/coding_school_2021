
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.CtrlStudentAgeLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlStudentNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlStudentNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CtrlStudentAgeSpintEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CtrlStudentRegistrationNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlStudentRegistrationNumberSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CtrlStudentIDLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlStudentIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentAgeSpintEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentRegistrationNumberSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentIDTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(307, 297);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 30);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.CtrlStudentOK_click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(442, 297);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 30);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.CtrlStudentCancel_click);
            // 
            // CtrlStudentAgeLabel
            // 
            this.CtrlStudentAgeLabel.Location = new System.Drawing.Point(49, 136);
            this.CtrlStudentAgeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlStudentAgeLabel.Name = "CtrlStudentAgeLabel";
            this.CtrlStudentAgeLabel.Size = new System.Drawing.Size(22, 16);
            this.CtrlStudentAgeLabel.TabIndex = 10;
            this.CtrlStudentAgeLabel.Text = "Age";
            // 
            // CtrlStudentNameLabel
            // 
            this.CtrlStudentNameLabel.Location = new System.Drawing.Point(49, 90);
            this.CtrlStudentNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlStudentNameLabel.Name = "CtrlStudentNameLabel";
            this.CtrlStudentNameLabel.Size = new System.Drawing.Size(33, 16);
            this.CtrlStudentNameLabel.TabIndex = 9;
            this.CtrlStudentNameLabel.Text = "Name";
            // 
            // CtrlStudentNameTextEdit
            // 
            this.CtrlStudentNameTextEdit.Location = new System.Drawing.Point(228, 84);
            this.CtrlStudentNameTextEdit.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlStudentNameTextEdit.Name = "CtrlStudentNameTextEdit";
            this.CtrlStudentNameTextEdit.Size = new System.Drawing.Size(307, 22);
            this.CtrlStudentNameTextEdit.TabIndex = 7;
            // 
            // CtrlStudentAgeSpintEdit
            // 
            this.CtrlStudentAgeSpintEdit.EditValue = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.CtrlStudentAgeSpintEdit.Location = new System.Drawing.Point(228, 132);
            this.CtrlStudentAgeSpintEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlStudentAgeSpintEdit.Name = "CtrlStudentAgeSpintEdit";
            this.CtrlStudentAgeSpintEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlStudentAgeSpintEdit.Properties.IsFloatValue = false;
            this.CtrlStudentAgeSpintEdit.Properties.MaskSettings.Set("mask", "N00");
            this.CtrlStudentAgeSpintEdit.Properties.MaxValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CtrlStudentAgeSpintEdit.Properties.MinValue = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.CtrlStudentAgeSpintEdit.Size = new System.Drawing.Size(156, 24);
            this.CtrlStudentAgeSpintEdit.TabIndex = 11;
            // 
            // CtrlStudentRegistrationNumberLabel
            // 
            this.CtrlStudentRegistrationNumberLabel.Location = new System.Drawing.Point(49, 195);
            this.CtrlStudentRegistrationNumberLabel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CtrlStudentRegistrationNumberLabel.Name = "CtrlStudentRegistrationNumberLabel";
            this.CtrlStudentRegistrationNumberLabel.Size = new System.Drawing.Size(117, 16);
            this.CtrlStudentRegistrationNumberLabel.TabIndex = 13;
            this.CtrlStudentRegistrationNumberLabel.Text = "Registration Number";
            // 
            // CtrlStudentRegistrationNumberSpinEdit
            // 
            this.CtrlStudentRegistrationNumberSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrlStudentRegistrationNumberSpinEdit.Location = new System.Drawing.Point(228, 191);
            this.CtrlStudentRegistrationNumberSpinEdit.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlStudentRegistrationNumberSpinEdit.Name = "CtrlStudentRegistrationNumberSpinEdit";
            this.CtrlStudentRegistrationNumberSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlStudentRegistrationNumberSpinEdit.Properties.MaxValue = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.CtrlStudentRegistrationNumberSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CtrlStudentRegistrationNumberSpinEdit.Size = new System.Drawing.Size(156, 24);
            this.CtrlStudentRegistrationNumberSpinEdit.TabIndex = 14;
            // 
            // CtrlStudentIDLabel
            // 
            this.CtrlStudentIDLabel.Location = new System.Drawing.Point(52, 38);
            this.CtrlStudentIDLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlStudentIDLabel.Name = "CtrlStudentIDLabel";
            this.CtrlStudentIDLabel.Size = new System.Drawing.Size(12, 16);
            this.CtrlStudentIDLabel.TabIndex = 16;
            this.CtrlStudentIDLabel.Text = "ID";
            // 
            // CtrlStudentIDTextEdit
            // 
            this.CtrlStudentIDTextEdit.Enabled = false;
            this.CtrlStudentIDTextEdit.Location = new System.Drawing.Point(228, 35);
            this.CtrlStudentIDTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlStudentIDTextEdit.Name = "CtrlStudentIDTextEdit";
            this.CtrlStudentIDTextEdit.Size = new System.Drawing.Size(307, 22);
            this.CtrlStudentIDTextEdit.TabIndex = 15;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 386);
            this.Controls.Add(this.CtrlStudentIDLabel);
            this.Controls.Add(this.CtrlStudentIDTextEdit);
            this.Controls.Add(this.CtrlStudentRegistrationNumberSpinEdit);
            this.Controls.Add(this.CtrlStudentRegistrationNumberLabel);
            this.Controls.Add(this.CtrlStudentAgeSpintEdit);
            this.Controls.Add(this.CtrlStudentAgeLabel);
            this.Controls.Add(this.CtrlStudentNameLabel);
            this.Controls.Add(this.CtrlStudentNameTextEdit);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentAgeSpintEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentRegistrationNumberSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlStudentIDTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl CtrlStudentAgeLabel;
        private DevExpress.XtraEditors.LabelControl CtrlStudentNameLabel;
        private DevExpress.XtraEditors.TextEdit CtrlStudentNameTextEdit;
        private DevExpress.XtraEditors.SpinEdit CtrlStudentAgeSpintEdit;
        private DevExpress.XtraEditors.LabelControl CtrlStudentRegistrationNumberLabel;
        private DevExpress.XtraEditors.SpinEdit CtrlStudentRegistrationNumberSpinEdit;
        private DevExpress.XtraEditors.LabelControl CtrlStudentIDLabel;
        private DevExpress.XtraEditors.TextEdit CtrlStudentIDTextEdit;
    }
}