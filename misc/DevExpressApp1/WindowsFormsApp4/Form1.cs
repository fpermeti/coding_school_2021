using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4 {
    public partial class Form1 : DevExpress.XtraBars.TabForm {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {

            string message1 = "Only alphabet characters are allowed.\n\n";

            string message2 = "Numbers, symbols and spacing are not allowed.";

            Regex onlyAlphabetLetters = new Regex(@"^[a-zA-Z]+$");

            MatchCollection matches = onlyAlphabetLetters.Matches(textEdit1.Text);

            if (matches.Count > 0) {

                int nameLength = textEdit1.Text.Length;

                string firstLetterOfName = textEdit1.Text.Substring(0, 1).ToUpper();

                string nameWithoutFirstLetter = textEdit1.Text.Substring(1, nameLength - firstLetterOfName.Length).ToLower();

                string processedName = string.Format("{0}{1}", firstLetterOfName, nameWithoutFirstLetter);

                if (!listBoxControl1.Items.Contains(processedName)) {

                    listBoxControl1.Items.Add(processedName);
                }
                else {

                    MessageBox.Show("The name you are trying to add already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else {

                MessageBox.Show(message1 + message2, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void listBoxControl1_MouseDoubleClick(object sender, MouseEventArgs e) {

            int index = this.listBoxControl1.IndexFromPoint(e.Location);

            if (index != -1) {

                MessageBox.Show(listBoxControl1.SelectedItem.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
