using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grocery_Management_System
{
    
    public partial class LoginPage : Form
    {
        private string constr = "Server=AAKASH;Database=dbGrocery;User Id=sa;Password=aakashdahal;";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty && txtUsername.Text == String.Empty)
            {
                MessageBox.Show("Please enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else if (txtUsername.Text == String.Empty)
            {
                MessageBox.Show("Please enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                SqlConnection conn = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username='"+txtUsername.Text+"' AND Password ='"+txtPassword.Text+"'",conn);
               // cmd.Connection = conn;

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                try
                {
                    conn.Open();
                    da.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid Credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                    else
                    { 
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                        this.Hide();
                        Loading ld = new Loading();
                        ld.ShowDialog();
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
