using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_AB1506
{
    public partial class frmRiceFood : Form
    {
        public frmRiceFood()
        {
            InitializeComponent();
        }

        private void tsbtnShowTheOrder_Click(object sender, EventArgs e)
        {

            
            lblAnswer.Text =" Order : \n" +  lbOrder.SelectedItem + "\n Quantity : \n " + comboBox1.Text;


        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            lbOrder.Items.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
