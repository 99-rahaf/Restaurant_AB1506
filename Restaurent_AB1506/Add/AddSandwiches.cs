using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Restaurant_AB1506
{
    public partial class AddSandwiches : Form
    {
        public AddSandwiches()
        {
            InitializeComponent();
        }
        string data = "Provider = Microsoft.ACE.OLEDB.12.0; " +
            "Data Source = Restaurant_AB1506.accdb";
        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection(data);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Sandwiches", con);
            con.Open();
            adapter.Fill(dt);
            con.Close();




        }
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(data);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Sandwiches values(@ID, @Sandwiches)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Sandwiches", txtName.Text);



            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is successfully");
            GetAllCourses();
        }

        private void tsbtnShowTheOrder_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(data);
            con.Open();
            string update = "Update Sandwiches " + " Set  Sandwiches=@Sandwiches" + " where ID=@ID ";
            OleDbCommand cmd = new OleDbCommand(update, con);

            cmd.Parameters.AddWithValue("@Sandwiches", txtName.Text);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update is successfully");
            GetAllCourses();
        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            string delete = "Delete From Sandwiches Where ID=@ID";
            OleDbConnection con = new OleDbConnection(data);

            OleDbCommand cmd = new OleDbCommand(delete, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete is successfully");
            GetAllCourses();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
