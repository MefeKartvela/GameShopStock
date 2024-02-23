using System;
using System.Collections.Generic;

using System.Windows.Forms;


namespace GameShopStock
{
    public partial class StockManagementForm : Form
    {
       
            private List<Item> itemList = new List<Item>();

            public StockManagementForm()
            {
                InitializeComponent();
            }

            private void StockManagementForm_Load(object sender, EventArgs e)
            {
                UpdateItemList();
            }

            private void btnAddItem_Click(object sender, EventArgs e)
        {
                string sname = textBox1.Text;
                int price = Convert.ToInt32(textBox2.Text);
                int quantity = Convert.ToInt32(textBox3.Text);

                itemList.Add(new Item( name, price, quantity));
                UpdateItemList();
            }

            private void btnRemoveItem_Click(object sender, EventArgs e)
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex != -1)
                {
                    itemList.RemoveAt(selectedIndex);
                    UpdateItemList();
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.");
                }
            }

            private void UpdateItemList()
            {
                listBox1.Items.Clear();
                foreach (Item item in itemList)
                {
                    listBox1.Items.Add(item.Name);
                }
            }

          

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
