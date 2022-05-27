using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "Dwi Aprilya";
            string password = "dwiaprilya23";



            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi !!");
            }
            else if (Username.Text != username || Password.Text != password)
            {
                MessageBox.Show("Username atau password yang anda masukkan salah !!");
            }
            else if (Username.Text == username && Password.Text == password && checkBox1.Checked)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Harap setuju Tern and Condition");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
