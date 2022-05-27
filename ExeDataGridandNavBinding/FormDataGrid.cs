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
    public partial class FormDataGrid : Form
    {
        public FormDataGrid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView data = new DataGridView();
            data.Show();
            this.Hide();
        }

        private void FormDataGrid_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
