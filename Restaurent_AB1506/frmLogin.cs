using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Restaurant_AB1506
{
    public partial class frmLogin : Form
    {
        private string usersname;
        public frmLogin(string Usersname)
        {
            usersname = Usersname;
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            frmRiceFood frm1 = new frmRiceFood();
            frm1.TopLevel = false;
            frm1.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(frm1);
            frm1.Show();
            
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            frmMeatFood frm2 = new frmMeatFood();
            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(frm2);
            frm2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            frmChickenFood frm3 = new frmChickenFood();
            frm3.TopLevel = false;
            frm3.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(frm3);
            frm3.Show();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            frmSandwiches frm4 = new frmSandwiches();
            frm4.TopLevel = false;
            frm4.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(frm4);
            frm4.Show();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + usersname;

            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            frmDataBase frmdata = new frmDataBase();
            frmdata.TopLevel = false;
            frmdata.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(frmdata);
            frmdata.Show();
        }
    }
}
