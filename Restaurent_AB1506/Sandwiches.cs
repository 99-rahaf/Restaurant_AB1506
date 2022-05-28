using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_AB1506
{
    public partial class frmSandwiches : Form
    {
        public frmSandwiches()
        {
            InitializeComponent();
            cmbOrder.Items.Add(new Price { Name = "Shawarma - $3", Value = 3 });
            cmbOrder.Items.Add(new Price { Name = "hamburger - $4", Value = 4 });
            cmbOrder.Items.Add(new Price { Name = "fajita - $5", Value = 5 });
            cmbOrder.Items.Add(new Price { Name = "zinger - $4", Value = 4 });
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

        private void tsbtnShowTheOrder_Click(object sender, EventArgs e)
        {
            int x, y, d;

            x = Convert.ToInt32(((Price)cmbOrder.SelectedItem).Value);
            y = Convert.ToInt32(dmOrder.Value);

            d = x * y;
            lblAnswer.Text = " Order : \n" + cmbOrder.SelectedItem + "\n Quantity : \n " + dmOrder.Text + "\n Price : " + d;
        }
    }
}
