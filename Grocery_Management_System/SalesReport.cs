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
    public partial class dgvSales : Form
    {

        private string st = "Server=DESKTOP-4Q5VENR\\AAKASH;Database=dbGrocery;User Id=sa;Password=aakashdahal;";
        public dgvSales()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
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
                        cmd.CommandText = "SELECT * FROM Sales ";
                        cmd.CommandType = CommandType.Text;

                        //DataTable dataTable = new DataTable();
                        //SqlDataReader sdr = cmd.ExecuteReader();
                        //dataTable.Load(sdr);
                        //conn.Close();
                        //dgvSalesReport.DataSource = dataTable;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int x = 0;
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    try
                                    {
                                        dgvSalesReport.Rows.Add();
                                        dgvSalesReport.Rows[x].Cells[0].Value = reader["Order_Id"].ToString();
                                        dgvSalesReport.Rows[x].Cells[1].Value = reader["CustomerName"].ToString();
                                        dgvSalesReport.Rows[x].Cells[2].Value = reader["CustomerAddress"].ToString();
                                        dgvSalesReport.Rows[x].Cells[3].Value = reader["Date"].ToString();
                                        dgvSalesReport.Rows[x].Cells[4].Value = reader["Mobile"].ToString();
                                        dgvSalesReport.Rows[x].Cells[5].Value = reader["Total"].ToString();                                
                                        x++;
                                    }
                                    catch (Exception ex)
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

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application Excelapp = new Microsoft.Office.Interop.Excel.Application();
                Excelapp.Application.Workbooks.Add(Type.Missing);

                //change properties of workbook

                Excelapp.Columns.ColumnWidth = 20;

                //storing header part in excel
                for (int i = 1; i < dgvSalesReport.Columns.Count + 1; i++)
                {
                    Excelapp.Cells[1, i] = dgvSalesReport.Columns[i - 1].HeaderText;

                }

                //storing each row and column to excel sheet
                for (int i = 0; i < dgvSalesReport.Rows.Count; i++)
                {

                    for (int j = 0; j < dgvSalesReport.Columns.Count; j++)
                    {
                        Excelapp.Cells[i + 2, j + 1] = dgvSalesReport.Rows[i].Cells[j].Value.ToString();

                    }
                }
                Excelapp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                Excelapp.ActiveWorkbook.Saved = true;
                Excelapp.Quit();
            }
        }
    }
}
