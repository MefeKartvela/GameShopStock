using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameShopStock
{
    public partial class StaffManagementForm : Form
    {
        private List<Staff> staffList = new List<Staff>();

        public StaffManagementForm()
        {
            InitializeComponent();
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            UpdateStaffListBox();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string position = textBox2.Text;

            staffList.Add(new Staff(name, position));
            UpdateStaffListBox();
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex != -1)
            {
                staffList.RemoveAt(selectedIndex);
                UpdateStaffListBox();
            }
            else
            {
                MessageBox.Show("Please select a staff member to remove.");
            }
        }

        private void UpdateStaffListBox()
        {
            listBox1.Items.Clear();
            foreach (Item staff in staffList)
            {
                listBox1.Items.Add(staff.Name);
            }
        }
        
    }
}
