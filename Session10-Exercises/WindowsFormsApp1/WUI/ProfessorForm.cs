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
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1 {
    public partial class ProfessorForm : DevExpress.XtraEditors.XtraForm {

        public Professor NewProfessor { get; set; }

        public University NewUniversity { get; set; }

        public ProfessorForm() {

            InitializeComponent();
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            AddProfessor();
        }

        private void AddProfessor() {

            if (Convert.ToString(ctrlName.EditValue).Length > 0 && Convert.ToString(ctrlSurname.EditValue).Length > 0) {

                NewProfessor.Name = string.Format("Dr. {0}", Convert.ToString(ctrlName.EditValue));

                NewProfessor.Surname = Convert.ToString(ctrlSurname.EditValue);

                NewProfessor.Age = Convert.ToInt32(ctrlAge.EditValue);

                NewProfessor.Rank = (ProfessorRank)Enum.Parse(typeof(ProfessorRank), ctrlRank.Text);

                NewProfessor.Courses.Clear();

                //populate list containing the courses a professor teaches
                foreach (int i in ctrlCourses.CheckedIndices) {

                    NewProfessor.Courses.Add(NewUniversity.Courses[i]);
                }



                NewUniversity.Professors.Add(NewProfessor);



                Close();
            }
            else {

                MessageBox.Show("Name and Surname are required.");
            }
        }

        private void ctrlCancel_Click(object sender, EventArgs e) {


            Close();
        }

        private void ProfessorForm_Load(object sender, EventArgs e) {

            InitiaizeRank();
        }

        private void InitiaizeRank() {

            DXPopupMenu popupMenu = new DXPopupMenu();

            foreach (ProfessorRank type in Enum.GetValues(typeof(ProfessorRank))) {

                popupMenu.Items.Add(new DXMenuItem() { Caption = type.ToString() });
            }

            ctrlRank.DropDownControl = popupMenu;

            foreach (DXMenuItem item in popupMenu.Items) {

                item.Click += item_Click;
            }

            ctrlRank.Text = popupMenu.Items[0].Caption;
        }

        private void item_Click(object sender, EventArgs e) {

            ctrlRank.Text = ((DXMenuItem)sender).Caption;
        }
    }
}
