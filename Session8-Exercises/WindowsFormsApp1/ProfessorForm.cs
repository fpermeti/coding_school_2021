using DevExpress.Utils.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class ProfessorForm : Form {

        public Professor professor;
        public MainForm professorMainForm;

        public ProfessorForm() {

            InitializeComponent();
        }

        private void CtrlProfessorOK_click(object sender, EventArgs e) {

            if (CtrlProfessorNameTextEdit.Text == string.Empty) {

                MessageBox.Show("Name is required.");
            }
            else {

                professor = professorMainForm.professor;

                professor.Name = CtrlProfessorNameTextEdit.Text;

                professor.Age = (int)CtrlProfessorAgeSpinEdit.Value;

                professor.Rank = CtrlProfessorRankDropDownButton.Text;

                professorMainForm.professor = professor;

                professorMainForm.CtrlProfessorIDListBox.Items.Add(professor.ID.ToString());

                professorMainForm.CtrlProfessorNameListBox.Items.Add(professor.Name);

                professorMainForm.CtrlProfessorAgeListBox.Items.Add(professor.Age);

                professorMainForm.CtrlProfessorRankListBox.Items.Add(professor.Rank);

                this.Close();
            }
        }

        private void CtrlProfessorCancel_click(object sender, EventArgs e) {

            professor = null;

            GC.Collect();

            this.Close();

        }

        private void ProfessorForm_Load(object sender, EventArgs e) {

            CtrlProfessorIDTextEdit.Text = professorMainForm.professor.ID.ToString();

            DXPopupMenu popupMenu = new DXPopupMenu();

            foreach (ProfessorRank type in Enum.GetValues(typeof(ProfessorRank))) {

                popupMenu.Items.Add(new DXMenuItem() { Caption = type.ToString() });
            }

            CtrlProfessorRankDropDownButton.DropDownControl = popupMenu;

            foreach (DXMenuItem item in popupMenu.Items) {

                item.Click += item_Click;
            }

            CtrlProfessorRankDropDownButton.Text = popupMenu.Items[0].Caption;
        }

        private void item_Click(object sender, EventArgs e) {

            CtrlProfessorRankDropDownButton.Text = ((DXMenuItem)sender).Caption;
        }
    }
}
