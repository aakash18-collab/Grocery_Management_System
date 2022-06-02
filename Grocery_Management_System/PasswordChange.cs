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
    public partial class PasswordChange : Form
    {
        String str = "Server=AAKASH;Database=dbGrocery;User Id=sa;Password=aakashdahal;";
        public PasswordChange()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            txtOldPassword.Focus();

        }
        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == String.Empty && txtNewPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Fill in the boxes", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtNewPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Enter New Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtOldPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Old Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtConfirmPassword.Text == String.Empty)
            {
                MessageBox.Show("Confirm Password Box is Empty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("New Password and Confirm Password doesn't match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Password ='" + txtOldPassword.Text + "'", conn);

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    conn.Open();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Your old password doesn't matches the record", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtOldPassword.Focus();
                    }
                    else
                    {
                        SqlCommand cd = new SqlCommand("UPDATE Login SET Password ='" + txtNewPassword.Text + "'", conn);
                        cd.Parameters.Clear();
                        cd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clear();
                    }

                    conn.Close();

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Clear();
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtOldPassword.Focus();
        }
    }
}
