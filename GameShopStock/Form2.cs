using C_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShopStock
{
    public partial class Form2 : Form
    {
        private const string filePath = "users.txt";

        public Form2()
        {
            InitializeComponent();
            LoadUsersToListBox(); 
        }

        private void LoadUsersToListBox()
        {
            listBox1.Items.Clear(); 
            if (File.Exists(filePath))
            {
                string[] existingUsers = File.ReadAllLines(filePath);
                foreach (string line in existingUsers)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length > 0)
                    {
                        listBox1.Items.Add(parts[0]);
                    }
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (CreateUser(username, password))
                {
                    MessageBox.Show("Signup successful! You can now log in.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private bool CreateUser(string username, string password)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            string[] existingUsers = File.ReadAllLines(filePath);
            foreach (string line in existingUsers)
            {
                string[] parts = line.Split('|');
                if (parts.Length > 0 && parts[0] == username)
                {
                    return false; 
                }
            }

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(username + "|" + password);
            }

            LoadUsersToListBox();
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form2 = new MainForm();
            form2.Show();
            this.Hide();
        }
    }
}
