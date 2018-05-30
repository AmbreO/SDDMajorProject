﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDDMajorProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //If "Other" is selected, make the text visible, otherwise make is invisible
        private void isOthrSlctd(object sender, System.EventArgs e){
            string slctdOptn = (cmboBxEvnt.SelectedItem).ToString();/*Assigning to slctdOptn the selected option if the combo box
            https://stackoverflow.com/a/18830040 */
            if (slctdOptn == "Other"){
                txtBxOthr.Visible = true;
            }
            else{
                txtBxOthr.Visible = false;
            }
        }
    }
}
