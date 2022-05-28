using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_AB1506
{/*
  grilled meet
roasted meat
sajya
Shawarma*/
    public partial class frmMeatFood : Form
    {
        public frmMeatFood()
        {
            InitializeComponent();
            cmbOrder.Items.Add(new Price { Name = "grilled meet - $15", Value = 15 });
            cmbOrder.Items.Add(new Price { Name = "roasted meat - $20", Value = 20 });
            cmbOrder.Items.Add(new Price { Name = "sajya - $30", Value = 30 });
            cmbOrder.Items.Add(new Price { Name = "Shawarma - $6", Value = 6 });
        }

        private void tsbtnShowTheOrder_Click(object sender, EventArgs e)
        {
            int x, y, d;

            x = Convert.ToInt32(((Price)cmbOrder.SelectedItem).Value);
            y = Convert.ToInt32(dmOrder.Value);

            d = x * y;
            lblAnswer.Text = " Order : \n" + cmbOrder.SelectedItem + "\n Quantity : \n " + dmOrder.Text + "\n Price : " + d;
        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            cmbOrder.Items.Clear();
            dmOrder.Value = 0;
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
