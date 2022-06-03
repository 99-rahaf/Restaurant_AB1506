using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Restaurant_AB1506
{
    public partial class frmSandwiches : Form
    {
        public frmSandwiches()
        {
            InitializeComponent();
            fill_ListBox();
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
            
            lblAnswer.Text = " Order : \n" + cmbOrder.SelectedItem + "\n Quantity : \n " + dmOrder.Text ;
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            AddSandwiches addsa = new AddSandwiches();
            addsa.Show();
        }
        string data = "Provider = Microsoft.ACE.OLEDB.12.0; " +
            "Data Source = Restaurant_AB1506.accdb";
        void fill_ListBox()
        {
            try
            {

                OleDbConnection con = new OleDbConnection(data);
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string selection = "Select Sandwiches from Sandwiches";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    cmbOrder.Items.Add(myReader["Sandwiches"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error  " + ex);
            }
        }
    }
}
