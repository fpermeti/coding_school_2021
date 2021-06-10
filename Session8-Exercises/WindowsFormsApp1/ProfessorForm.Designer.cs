
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.CtrlProfessorRankLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlProfessorAgeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.CtrlProfessorAgeLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlProfessorNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlProfessorNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CtrlProfessorIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CtrlProfessorIDLabel = new DevExpress.XtraEditors.LabelControl();
            this.CtrlProfessorRankDropDownButton = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorAgeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorIDTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(305, 307);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 30);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.CtrlProfessorOK_click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(444, 307);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 30);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.CtrlProfessorCancel_click);
            // 
            // CtrlProfessorRankLabel
            // 
            this.CtrlProfessorRankLabel.Location = new System.Drawing.Point(49, 207);
            this.CtrlProfessorRankLabel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CtrlProfessorRankLabel.Name = "CtrlProfessorRankLabel";
            this.CtrlProfessorRankLabel.Size = new System.Drawing.Size(29, 16);
            this.CtrlProfessorRankLabel.TabIndex = 19;
            this.CtrlProfessorRankLabel.Text = "Rank";
            // 
            // CtrlProfessorAgeSpinEdit
            // 
            this.CtrlProfessorAgeSpinEdit.EditValue = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CtrlProfessorAgeSpinEdit.Location = new System.Drawing.Point(150, 153);
            this.CtrlProfessorAgeSpinEdit.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlProfessorAgeSpinEdit.Name = "CtrlProfessorAgeSpinEdit";
            this.CtrlProfessorAgeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CtrlProfessorAgeSpinEdit.Properties.IsFloatValue = false;
            this.CtrlProfessorAgeSpinEdit.Properties.MaskSettings.Set("mask", "N00");
            this.CtrlProfessorAgeSpinEdit.Properties.MaxValue = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CtrlProfessorAgeSpinEdit.Properties.MinValue = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CtrlProfessorAgeSpinEdit.Size = new System.Drawing.Size(156, 24);
            this.CtrlProfessorAgeSpinEdit.TabIndex = 17;
            // 
            // CtrlProfessorAgeLabel
            // 
            this.CtrlProfessorAgeLabel.Location = new System.Drawing.Point(49, 157);
            this.CtrlProfessorAgeLabel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CtrlProfessorAgeLabel.Name = "CtrlProfessorAgeLabel";
            this.CtrlProfessorAgeLabel.Size = new System.Drawing.Size(22, 16);
            this.CtrlProfessorAgeLabel.TabIndex = 16;
            this.CtrlProfessorAgeLabel.Text = "Age";
            // 
            // CtrlProfessorNameLabel
            // 
            this.CtrlProfessorNameLabel.Location = new System.Drawing.Point(49, 103);
            this.CtrlProfessorNameLabel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CtrlProfessorNameLabel.Name = "CtrlProfessorNameLabel";
            this.CtrlProfessorNameLabel.Size = new System.Drawing.Size(33, 16);
            this.CtrlProfessorNameLabel.TabIndex = 15;
            this.CtrlProfessorNameLabel.Text = "Name";
            // 
            // CtrlProfessorNameTextEdit
            // 
            this.CtrlProfessorNameTextEdit.Location = new System.Drawing.Point(150, 100);
            this.CtrlProfessorNameTextEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CtrlProfessorNameTextEdit.Name = "CtrlProfessorNameTextEdit";
            this.CtrlProfessorNameTextEdit.Size = new System.Drawing.Size(363, 22);
            this.CtrlProfessorNameTextEdit.TabIndex = 14;
            // 
            // CtrlProfessorIDTextEdit
            // 
            this.CtrlProfessorIDTextEdit.Enabled = false;
            this.CtrlProfessorIDTextEdit.Location = new System.Drawing.Point(150, 36);
            this.CtrlProfessorIDTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlProfessorIDTextEdit.Name = "CtrlProfessorIDTextEdit";
            this.CtrlProfessorIDTextEdit.Size = new System.Drawing.Size(363, 22);
            this.CtrlProfessorIDTextEdit.TabIndex = 20;
            // 
            // CtrlProfessorIDLabel
            // 
            this.CtrlProfessorIDLabel.Location = new System.Drawing.Point(49, 39);
            this.CtrlProfessorIDLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CtrlProfessorIDLabel.Name = "CtrlProfessorIDLabel";
            this.CtrlProfessorIDLabel.Size = new System.Drawing.Size(12, 16);
            this.CtrlProfessorIDLabel.TabIndex = 21;
            this.CtrlProfessorIDLabel.Text = "ID";
            // 
            // CtrlProfessorRankDropDownButton
            // 
            this.CtrlProfessorRankDropDownButton.Location = new System.Drawing.Point(150, 197);
            this.CtrlProfessorRankDropDownButton.Margin = new System.Windows.Forms.Padding(5);
            this.CtrlProfessorRankDropDownButton.Name = "CtrlProfessorRankDropDownButton";
            this.CtrlProfessorRankDropDownButton.Size = new System.Drawing.Size(192, 36);
            this.CtrlProfessorRankDropDownButton.TabIndex = 18;
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 366);
            this.Controls.Add(this.CtrlProfessorIDLabel);
            this.Controls.Add(this.CtrlProfessorIDTextEdit);
            this.Controls.Add(this.CtrlProfessorRankLabel);
            this.Controls.Add(this.CtrlProfessorRankDropDownButton);
            this.Controls.Add(this.CtrlProfessorAgeSpinEdit);
            this.Controls.Add(this.CtrlProfessorAgeLabel);
            this.Controls.Add(this.CtrlProfessorNameLabel);
            this.Controls.Add(this.CtrlProfessorNameTextEdit);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ProfessorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorAgeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlProfessorIDTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl CtrlProfessorRankLabel;
        private DevExpress.XtraEditors.SpinEdit CtrlProfessorAgeSpinEdit;
        private DevExpress.XtraEditors.LabelControl CtrlProfessorAgeLabel;
        private DevExpress.XtraEditors.LabelControl CtrlProfessorNameLabel;
        private DevExpress.XtraEditors.TextEdit CtrlProfessorNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CtrlProfessorIDTextEdit;
        private DevExpress.XtraEditors.LabelControl CtrlProfessorIDLabel;
        private DevExpress.XtraEditors.DropDownButton CtrlProfessorRankDropDownButton;
    }
}