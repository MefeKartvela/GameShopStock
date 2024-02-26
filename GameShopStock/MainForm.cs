using GameShopStock;
using System;
using System.Windows.Forms;


namespace C_Project
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StockManagementForm form3 = new StockManagementForm();
            form3.Show();
            this.Hide();
        }
    }
}

