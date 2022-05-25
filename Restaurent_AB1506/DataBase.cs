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
    public partial class frmDataBase : Form
    {
        public frmDataBase()
        {
            InitializeComponent();
        }

        void GetAllCourses()
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = C:\\Users\\SCHOOL\\Desktop\\rahaf\\Restaurant_AB1506.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from Courses", con);
            con.Open();
            adapter.Fill(dt);
            dgwcourses.DataSource = dt;
            con.Close();
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            GetAllCourses();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source=C:\\Users\\SCHOOL\\Desktop\\rahaf\\Restaurant_AB1506.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Courses values(@ID, @Student, @IdNumber)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Student", txtName.Text);
            cmd.Parameters.AddWithValue("@IdNumber", int.Parse(txtNumber.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved is successfully");
            GetAllCourses();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string update = "UPDATE courses" + " SET student=@Student, idnumber=@IdNumber " + "WHERE id=@ID";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source=C:\\Users\\SCHOOL\\Desktop\\rahaf\\Restaurant_AB1506.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand(update, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            cmd.Parameters.AddWithValue("@Student", txtName.Text);
            cmd.Parameters.AddWithValue("@IdNumber", int.Parse(txtNumber.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update is successfully");
            GetAllCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From courses Where ID=@ID";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + "Data Source=C:\\Users\\SCHOOL\\Desktop\\rahaf\\Restaurant_AB1506.accdb");

            OleDbCommand cmd = new OleDbCommand(delete, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete is successfully");
            GetAllCourses();
        }

        private void dgwcourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgwcourses.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgwcourses.CurrentRow.Cells[1].Value.ToString();
            txtNumber.Text = dgwcourses.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
