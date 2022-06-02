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
    public partial class Search : Form
    {
        public int ProductId;
       
        public Search()
        {
            InitializeComponent();
      
        }

        private void button7_Click(object sender, EventArgs e)
        {
          ProductId = Convert.ToInt32(txtId.Text);
          this.Close();
        }
    }
}
