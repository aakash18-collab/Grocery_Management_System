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
    public partial class StartSells : Form
    {
        string str = "Server=AAKASH;Database=dbGrocery;User Id=sa;Password=aakashdahal;";
        private int rowIndex = 0;

        public StartSells()
        {
            InitializeComponent();
            InitializeDates();
        }
        public class Product
        {
            public int? Id { get; set; }
            public string? Name { get; set; }

            public int? Price { get; set; }

            public Product()
            {

            }

        }


        public Product? product { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string mob = txtMobile.Text;
          
            if (txtCustomerName.Text == string.Empty || txtAddress.Text == string.Empty || txtDate.Text==string.Empty || txtMobile.Text == string.Empty)
            {
                MessageBox.Show("Please make sure not to leave any box empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mob.Count() != 10)
            {
                MessageBox.Show("Mobile Number should contain 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Sales VALUES (@CustomerName,@CustomerAddress,@Date,@Mobile,@Total)";
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                        cmd.Parameters.AddWithValue("@CustomerAddress", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                        cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                        cmd.Parameters.AddWithValue("@Total", lbltotal.Text);

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Order Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    conn.Close();
                }
            }
        }
        private void InitializeDates()
        {
            var today = DateTime.Today.ToString("dd/MM/yyyy");
            txtDate.Text = today;
        } 
        private void StartSells_Load(object sender, EventArgs e)
        {
            cmbProduct.Items.Clear();
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Name FROM Product";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    sdr.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbProduct.Items.Add(dr["Name"].ToString());
                    }
                    conn.Close();
                }

            }
        }
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT ID,Name,Price FROM Product WHERE Name='"+cmbProduct.Text+"'  ";
                    cmd.CommandType = CommandType.Text;
                   
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        product = new Product()
                        {
                             Id = (int)sdr["ID"],

                             Name = (string)sdr["Name"],

                             Price = (int)sdr["Price"]
                            
                        };

                    }
                    
                }           
                conn.Close();
            }           
        }
        private void button7_Click(object sender, EventArgs e)
        { 
           int? total = Convert.ToInt32(product?.Price) * Convert.ToInt32(txtQuantity.Text);
           dgvStartSells.Rows.Add(product?.Id, product?.Name ,product?.Price , txtQuantity.Text, total);

            int sum = 0;
            for (int i = 0; i < dgvStartSells.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvStartSells.Rows[i].Cells[4].Value);
            }
            lbltotal.Text = sum.ToString();
            cmbProduct.Text = String.Empty;
            
            txtQuantity.Clear();
        }
        private void dgvStartSells_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record", "Grocery Management", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvStartSells.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM Product WHERE ID = '" + id + "' ";
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteReader();
                        MessageBox.Show("Successfully Deleted");
                    }
                    conn.Close();
                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtCustomerName.Clear();
            txtDate.Clear();
            txtMobile.Clear();
            txtQuantity.Clear();
            lbltotal.Text = string.Empty;
            cmbProduct.Text = string.Empty;
            txtCustomerName.Focus();
            
        }
        
        private void dgvStartSells_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.dgvStartSells.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvStartSells.CurrentCell = this.dgvStartSells.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvStartSells, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvStartSells.Rows[this.rowIndex].IsNewRow)
            {
                this.dgvStartSells.Rows.RemoveAt(this.rowIndex);
            }
            int sum = 0;
            for (int i = 0; i < dgvStartSells.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvStartSells.Rows[i].Cells[4].Value);
            }
            lbltotal.Text = sum.ToString();

        }
    }
}
