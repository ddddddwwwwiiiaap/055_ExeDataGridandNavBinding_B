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
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            //ngatur warna
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightCoral;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.DarkBlue;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Turquoise;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;

            //ganti nama yang di atas
            dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[4].HeaderText = "No. Telepon";

            //Membuat data bagian jenis kelamin menjadi center
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormDataGrid data = new FormDataGrid();
            data.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            data.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            data.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            data.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            data.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            data.Show();
            this.Hide();
        }
    }
}
