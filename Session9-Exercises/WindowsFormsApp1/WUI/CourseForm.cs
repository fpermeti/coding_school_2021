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
    public partial class CourseForm : DevExpress.XtraEditors.XtraForm {

        public Course NewCourse { get; set; }


        public CourseForm() {

            InitializeComponent();
        }

        private void AddCourse() {


            if (Convert.ToString(ctrlCode.EditValue).Length > 0 && Convert.ToString(ctrlSubject.EditValue).Length > 0) {


                NewCourse.Code = Convert.ToString(ctrlCode.EditValue);

                NewCourse.Subject = Convert.ToString(ctrlSubject.EditValue);

                NewCourse.Hours = Convert.ToInt32(ctrlHours.EditValue);

                NewCourse.Category = (CourseCategory)Enum.Parse(typeof(CourseCategory), ctrlCategory.Text);

                DialogResult = DialogResult.OK;

                Close();
            }
            else {

                MessageBox.Show("All fields are required.");
            }
        }

        private void ctrlOK_Click(object sender, EventArgs e) {

            AddCourse();
        }

        private void ctrlCancel_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void InitializeCategory() {

            DXPopupMenu popupMenu = new DXPopupMenu();

            foreach (CourseCategory type in Enum.GetValues(typeof(CourseCategory))) {

                popupMenu.Items.Add(new DXMenuItem() { Caption = type.ToString() });
            }

            ctrlCategory.DropDownControl = popupMenu;

            foreach (DXMenuItem item in popupMenu.Items) {

                item.Click += item_Click;
            }

            ctrlCategory.Text = popupMenu.Items[0].Caption;
        }

        private void item_Click(object sender, EventArgs e) {

            ctrlCategory.Text = ((DXMenuItem)sender).Caption;
        }

        private void CourseForm_Load(object sender, EventArgs e) {

            InitializeCategory();
        }
    }
}
