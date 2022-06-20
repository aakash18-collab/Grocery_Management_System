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
    public partial class ChangeUsername : Form
    {
        String str = "Server=.;Database=dbGrocery;User Id=sa;Password=aakashdahal;";
        public ChangeUsername()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtOldUsername.Clear();
            txtChangeUsername.Clear();
            txtConfirmUsername.Clear();
            txtOldUsername.Focus();

        }
        private void ChangeUsername_Load(object sender, EventArgs e)
        {

        }

      

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            if (txtOldUsername.Text == String.Empty && txtChangeUsername.Text == String.Empty && txtConfirmUsername.Text == String.Empty)
            {
                MessageBox.Show("Please Fill in the boxes", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtOldUsername.Text == String.Empty && txtChangeUsername.Text == String.Empty)
            {
                MessageBox.Show("Please Enter old Username and new Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtChangeUsername.Text == String.Empty && txtConfirmUsername.Text == String.Empty)
            {
                MessageBox.Show("Please Enter New Username and Confirm Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtChangeUsername.Text == String.Empty)
            {
                MessageBox.Show("Please Enter New Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtOldUsername.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Old Username", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtConfirmUsername.Text == String.Empty)
            {
                MessageBox.Show("Confirm Username Box is Empty", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (txtConfirmUsername.Text != txtChangeUsername.Text)
            {
                MessageBox.Show("New Username and Confirm Username doesn't match", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Login WHERE Username ='" + txtOldUsername.Text + "'", conn);

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    conn.Open();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Your old Username doesn't matches the record", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtOldUsername.Focus();
                    }
                    else
                    {
                        SqlCommand cd = new SqlCommand("UPDATE Login SET Username ='" + txtChangeUsername.Text + "'", conn);
                        cd.Parameters.Clear();
                        cd.ExecuteNonQuery();
                        MessageBox.Show("Username Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clear();
                    }

                    conn.Close();

                }
            }
        }
    }
}
