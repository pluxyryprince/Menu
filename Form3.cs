using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.white". При необходимости она может быть перемещена или удалена.
            this.whiteTableAdapter.Fill(this.wine_mapDataSet.white);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.red". При необходимости она может быть перемещена или удалена.
            this.redTableAdapter.Fill(this.wine_mapDataSet.red);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.pink". При необходимости она может быть перемещена или удалена.
            this.pinkTableAdapter.Fill(this.wine_mapDataSet.pink);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.sparkling". При необходимости она может быть перемещена или удалена.
            this.sparklingTableAdapter.Fill(this.wine_mapDataSet.sparkling);

        }
    }
}
