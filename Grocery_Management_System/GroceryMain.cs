namespace Grocery_Management_System
{
    public partial class GroceryMain : Form
    {
        public GroceryMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductManagement pm = new ProductManagement();
            pm.Show();          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartSells ss = new StartSells();
            ss.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChange cp = new PasswordChange();
            cp.Show();
        }

        private void aboutProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProject ap = new AboutProject();
            ap.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void productReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductReport pr = new ProductReport();
            pr.ShowDialog();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangeUsername cu = new ChangeUsername();
            cu.ShowDialog();
        }
    }
}