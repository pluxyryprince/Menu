using System;
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
            userStartForm frm1 = new userStartForm();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //переназначение крестика на форме чтобы он закрывал все формы сразу
        //на случай, если в ходе работы приложения было открыто более одной формы
        //если не переназначать эту кнопку, то приложение не сможет полностью закрыться, если было открыто более одной формы, т.к. другие формы останутся висеть в процессах
        {
            Application.Exit();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_Closing;
            try
            {
                this.whiteTableAdapter.Fill(this.wine_mapDataSet.white);
                this.redTableAdapter.Fill(this.wine_mapDataSet.red);
                this.pinkTableAdapter.Fill(this.wine_mapDataSet.pink);
                this.sparklingTableAdapter.Fill(this.wine_mapDataSet.sparkling);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных. Попробуйте еще раз.");
            }
        }
    }
}
