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
using System.Text.RegularExpressions;

namespace Grocery_Management_System
{
    public partial class ProductReport : Form
    {

        private string st = "Server=AAKASH;Database=dbGrocery;User Id=sa;Password=aakashdahal;";
        public ProductReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            
            var sources = String.Empty;
            using (SqlConnection conn = new SqlConnection(st))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT * FROM Product ";
                    cmd.CommandType = CommandType.Text;

                    //DataTable dataTable = new DataTable();
                    //SqlDataReader sdr = cmd.ExecuteReader();
                    //dataTable.Load(sdr);
                    //conn.Close();
                    //dgvStartSells.DataSource = dataTable;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int x=0;
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {                              
                                try
                                {
                                    dgvProduct.Rows.Add();
                                    dgvProduct.Rows[x].Cells[0].Value = reader["ID"].ToString();
                                    dgvProduct.Rows[x].Cells[1].Value = reader["Name"].ToString();
                                    dgvProduct.Rows[x].Cells[2].Value = reader["Type"].ToString();
                                    dgvProduct.Rows[x].Cells[3].Value = reader["Company"].ToString();
                                    dgvProduct.Rows[x].Cells[4].Value = reader["Price"].ToString();
                                    dgvProduct.Rows[x].Cells[5].Value = reader["Stock"].ToString();
                                    dgvProduct.Rows[x].Cells[6].Value = reader["Description"].ToString();
                                    x++;
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                
                            }
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            saveFileDialog1.InitialDirectory = "C";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = " ";
            saveFileDialog1.Filter = "Excel Files(2007) |*.xls | Excel Files(2016) |*.xlsx | Excel Files(2019) |*.xlsx";

            if(saveFileDialog1.ShowDialog () != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application Excelapp = new Microsoft.Office.Interop.Excel.Application();
                Excelapp.Application.Workbooks.Add(Type.Missing);

                //change properties of workbook

                Excelapp.Columns.ColumnWidth = 20;

                //storing header part in excel
                for(int i = 1; i < dgvProduct.Columns.Count+1; i++)
                {
                    Excelapp.Cells[1,i] = dgvProduct.Columns[i - 1].HeaderText;

                }

                //storing each row and column to excel sheet
                for (int i = 0; i < dgvProduct.Rows.Count; i++)
                {
                    
                    for (int j = 0; j < dgvProduct.Columns.Count; j++)
                    {
                        Excelapp.Cells[i+2,j+1] = dgvProduct.Rows[i].Cells[j].Value.ToString();

                    }
                }
                Excelapp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                Excelapp.ActiveWorkbook.Saved = true;
                Excelapp.Quit();
            }
        }
    }
}
