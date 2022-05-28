using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_AB1506
{
    public partial class frmChickenFood : Form
    {
        public frmChickenFood()
        {
            


            InitializeComponent();
            cmbOrder.Items.Add(new Price { Name = "Chicken on coal - $20", Value = 20 });
            cmbOrder.Items.Add(new Price { Name = "Roasted chicken - $23", Value = 23 });
            cmbOrder.Items.Add(new Price { Name = "Smoked chicken - $18", Value = 18 });
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

