
using APP.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Store
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            context = new TeamStoreContext();
        }
        TeamStoreContext context;
        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = username_textBox.Text;
                string password = password_textBox.Text;

                var sysUsers = context.Users.Select(x => x.UserName).ToList();
                var passwords = context.Users.Select(x => x.Password).ToList();
                if (sysUsers.Contains(username) && passwords.Contains(password))
                {
                    this.Hide();
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.ShowDialog();
                }
                else
                    MessageBox.Show("Wrong Password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception ex)
            {
                MessageBox.Show("ex", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
