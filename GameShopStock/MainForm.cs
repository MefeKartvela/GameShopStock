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

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            StaffManagementForm staffForm = new StaffManagementForm();
            staffForm.ShowDialog();
        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {
            StockManagementForm stockForm = new StockManagementForm();
            stockForm.ShowDialog();
        }


    }
}

