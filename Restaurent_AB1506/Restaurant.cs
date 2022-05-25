using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_AB1506
{
    public partial class frmRestaurant : Form
    {
        private List<Users> UserslList = new List<Users>();
        public frmRestaurant()
        {
            Users user1 = new Users("rahaf", "150600");
            Users user2 = new Users("ibrahem", "150601");
            UserslList.Add(user1);
            UserslList.Add(user2);
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            foreach (Users user in UserslList)
            {
                if (username == user.UserName && password == user.Password)
                {
                    frmLogin frml = new frmLogin(txtUserName.Text);
                    frml.Show();
                    return;

                }
            }
            MessageBox.Show("Worng Try Again");
        }
    }
}
