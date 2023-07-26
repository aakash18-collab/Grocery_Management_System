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
    public partial class ProductManagement : Form
    {

        string str = "Server=DESKTOP-4Q5VENR\\AAKASH;Database=dbGrocery;User Id=sa;Password=aakashdahal;";
        int _id = 0;
        public ProductManagement()
        {
            InitializeComponent();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Search fnd = new Search();
            
            fnd.ShowDialog();

            _id = fnd.ProductId;
            LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbCompany.Text == String.Empty && cmbSelectType.Text== String.Empty && txtName.Text ==
                String.Empty && txtPricePerUnit.Text == String.Empty && txtStock.Text == String.Empty 
                && txtDescription.Text == String.Empty)
            {
                MessageBox.Show("Please fill in the boxes", "Error");
            }
            else if(cmbCompany.Text == String.Empty )
            {
                MessageBox.Show("Please select Company", "Error");
            }
            else if (cmbSelectType.Text == String.Empty )
            {
                MessageBox.Show("Please select product type", "Error");
            }
            else if (txtName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Name", "Error");
            }
            else if (txtPricePerUnit.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Price per unit", "Error");
            }
            else if (txtStock.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Stock", "Error");
            }
            else if (txtDescription.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Description", "Error");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Product VALUES (@Name,@Type,@Company,@Price,@Stock,@Description)";
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Type", cmbSelectType.Text);
                        cmd.Parameters.AddWithValue("@Company", cmbCompany.Text);
                        cmd.Parameters.AddWithValue("@Price", txtPricePerUnit.Text);
                        cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    
                    }
                    conn.Close();
                    ClearData();
                    LoadData();
                
                }
            }


        }
        private void ClearData()
        {
            cmbCompany.Text = "";   
            cmbSelectType.Text = "";
            txtDescription.Clear();
            txtName.Clear();
            txtPricePerUnit.Clear();
            txtStock.Clear();
            _id =0;

            LoadData();

            cmbCompany.Focus();
        }
        private void LoadData()
        {
            using(SqlConnection conn = new SqlConnection(str))
            {
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"SELECT * FROM Product {(_id != 0 || _id > 0 ? "WHERE Product_Id =" + _id : "")}";
                    cmd.CommandType = CommandType.Text;
                    DataTable dataTable = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dataTable.Load(sdr);
                    conn.Close();
                    dgvProductManagement.DataSource = dataTable;

                }
            }
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvProductManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(dgvProductManagement.Rows[e.RowIndex].Cells[0].Value);

            cmbCompany.Text = dgvProductManagement.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbSelectType.Text = dgvProductManagement.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = dgvProductManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPricePerUnit.Text = dgvProductManagement.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStock.Text = dgvProductManagement.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDescription.Text = dgvProductManagement.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = ("UPDATE Product SET Name = '" + txtName.Text + "',Type = '" + cmbSelectType.Text + "'" +
                                ",Company='" + cmbCompany.Text + "' ,Price='" + txtPricePerUnit.Text + "',Description='" + txtDescription.Text + "'," +
                                "Stock='" + txtStock.Text + "' WHERE Product_Id= '" + _id + "'");
                            cmd.CommandType = CommandType.Text;

                            cmd.Parameters.Clear();

                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated successfully !", "Update Success", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        conn.Close();
                        ClearData();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                       
            }
            else
            {
                MessageBox.Show("Nothing Selected to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(_id>0)
            {
                if (MessageBox.Show("Do you want to delete this record?", "Grocery Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                using(SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    using(SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE  FROM Product WHERE Product_Id ='"+_id+"' ";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Clear();
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted Successfully", "Grocery App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    conn.Close();
                    ClearData();
                    LoadData();
                }

            }
            else
            {
                MessageBox.Show("Nothing Selected to Delete", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
    }
}
