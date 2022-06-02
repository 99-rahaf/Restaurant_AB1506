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
    public partial class frmChickenFood : Form
    {
        public frmChickenFood()
        {
            InitializeComponent();
            fill_ListBox();
        }

        private void tsbtnShowTheOrder_Click(object sender, EventArgs e)
        {

            lblAnswer.Text = " Order : \n" + cmbOrder.SelectedItem + "\n Quantity : \n " + dmOrder.Text ;
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

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            AddChickenFood addch = new AddChickenFood();
            addch.Show();
        }
        string data = "Provider = Microsoft.ACE.OLEDB.12.0; " +
            "Data Source = C:\\Users\\SCHOOL\\Desktop\\rahaf AB1506\\Restaurent_AB1506\\Restaurent_AB1506\\database\\Restaurant_AB1506.accdb";
        void fill_ListBox()
        {
            try
            {

                OleDbConnection con = new OleDbConnection(data);
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string selection = "Select Chicken_Food from ChickenFood";
                command.CommandText = selection;
                OleDbDataReader myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    cmbOrder.Items.Add(myReader["Chicken_Food"].ToString());
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

