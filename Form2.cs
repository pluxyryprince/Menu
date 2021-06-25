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
            userStartForm frm1 = new userStartForm();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_Closing;

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

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //переназначение крестика на форме чтобы он закрывал все формы сразу
        //на случай, если в ходе работы приложения было открыто более одной формы
        //если не переназначать эту кнопку, то приложение не сможет полностью закрыться, если было открыто более одной формы, т.к. другие формы останутся висеть в процессах
        {
            Application.Exit();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    