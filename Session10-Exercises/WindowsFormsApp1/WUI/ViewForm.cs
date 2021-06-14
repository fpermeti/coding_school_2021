﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.WUI {
    public partial class ViewForm : Form {

            public List<string> ViewData { get; set; }

        public ViewForm() {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e) {

            foreach (string item in ViewData) {
                ctrlViewList.Items.Add(item);
            }
        }
    }
}
