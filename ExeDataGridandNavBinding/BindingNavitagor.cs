using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
{
    public partial class BindingNavitagor : Form
    {
        public BindingNavitagor()
        {
            InitializeComponent();
        }

        SqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;
        string connstring = "data source=DWI-APRILYA-A-P; database=ProdiTI; Integrated Security=True; User ID=sa;Password=HAdpt023467";

        private void Form2_Load(object sender, EventArgs e)
        {
            dadapter = new SqlDataAdapter("select * from Mahasiswa", connstring);
            dset = new DataSet();
            dadapter.Fill(dset);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bindingNavigator1.BindingSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void BindingNavitagor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            this.CenterToScreen();
        }
    }
}
