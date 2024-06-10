using GarzoApplication.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarzoApplication.Views
{
    public partial class Login : Form
    {
        private Database database;
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
            database = new Database();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            

            if (username == string.Empty || !database.ValidateUsername(username))
            {
                MessageBox.Show("Username is incorrect.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (password == string.Empty || !database.ValidatePass(password))
            {
                MessageBox.Show("Password is incorrect.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (database.ValidateUser(username, password))
            {
                AppointmentView appointmentView = new AppointmentView();

                appointmentView.Show();

                this.Hide();
            }
        }

        private void shwPass_CheckedChanged(object sender, EventArgs e)
        {
            if (!shwPass.Checked)
            {

                txtPassword.PasswordChar = '*';
            }
            else
            {

                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
