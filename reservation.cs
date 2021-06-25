using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class reservation : Form
    {
        public reservation()
        {
            InitializeComponent();
        }

        private void reservation_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_Closing;
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //переназначение крестика на форме чтобы он закрывал все формы сразу
        //на случай, если в ходе работы приложения было открыто более одной формы
        //если не переназначать эту кнопку, то приложение не сможет полностью закрыться, если было открыто более одной формы, т.к. другие формы останутся висеть в процессах
        {
            Application.Exit();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
