using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {
        public Form2()
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

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                this.vegetablesTableAdapter.Fill(this.menuDataSet.vegetables);
                this.soupTableAdapter.Fill(this.menuDataSet.soup);
                this.pastaTableAdapter.Fill(this.menuDataSet.pasta);
                this.snacksTableAdapter.Fill(this.menuDataSet.snacks);
                this.meatTableAdapter.Fill(this.menuDataSet.meat);
                this.garnishTableAdapter.Fill(this.menuDataSet.garnish);
                this.fishTableAdapter.Fill(this.menuDataSet.fish);
                this.desserts_modernTableAdapter.Fill(this.menuDataSet.desserts_modern);
                this.desserts_classicTableAdapter.Fill(this.menuDataSet.desserts_classic);
                this.breadTableAdapter.Fill(this.menuDataSet.bread);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных. Попробуйте еще раз.");
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    