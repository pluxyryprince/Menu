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
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.vegetables". При необходимости она может быть перемещена или удалена.
                this.vegetablesTableAdapter.Fill(this.menuDataSet.vegetables);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.soup". При необходимости она может быть перемещена или удалена.
                this.soupTableAdapter.Fill(this.menuDataSet.soup);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.pasta". При необходимости она может быть перемещена или удалена.
                this.pastaTableAdapter.Fill(this.menuDataSet.pasta);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.snacks". При необходимости она может быть перемещена или удалена.
                this.snacksTableAdapter.Fill(this.menuDataSet.snacks);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.meat". При необходимости она может быть перемещена или удалена.
                this.meatTableAdapter.Fill(this.menuDataSet.meat);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.garnish". При необходимости она может быть перемещена или удалена.
                this.garnishTableAdapter.Fill(this.menuDataSet.garnish);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.fish". При необходимости она может быть перемещена или удалена.
                this.fishTableAdapter.Fill(this.menuDataSet.fish);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.desserts_modern". При необходимости она может быть перемещена или удалена.
                this.desserts_modernTableAdapter.Fill(this.menuDataSet.desserts_modern);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.desserts_classic". При необходимости она может быть перемещена или удалена.
                this.desserts_classicTableAdapter.Fill(this.menuDataSet.desserts_classic);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.bread". При необходимости она может быть перемещена или удалена.
                this.breadTableAdapter.Fill(this.menuDataSet.bread);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных. Попробуйте еще раз.");
            }
        }
    }
}
