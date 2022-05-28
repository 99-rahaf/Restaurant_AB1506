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
            cmbOrder.Items.Add(new Price { Name = "biryani - $20", Value = 20 });
            cmbOrder.Items.Add(new Price { Name = "Bukhari - $23", Value = 23 });
            cmbOrder.Items.Add(new Price { Name = "Kabsa - $18", Value = 18 });
            cmbOrder.Items.Add(new Price { Name = "makloba - $26", Value = 26 });
            cmbOrder.Items.Add(new Price { Name = "uzy - $19", Value = 19 });
            cmbOrder.Items.Add(new Price { Name = "mansaf - $40", Value = 40 });
        }

        private void tsbtnShowTheOrder_Click(object sender, EventArgs e)
        {
            int x, y, d;

            x = Convert.ToInt32(((Price)cmbOrder.SelectedItem).Value);
            y = Convert.ToInt32(dmOrder.Value);

            d = x * y;

            lblAnswer.Text =" Order : \n" +  cmbOrder.SelectedItem + "\n Quantity : \n " + dmOrder.Text + "\n Price : " + d;


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
