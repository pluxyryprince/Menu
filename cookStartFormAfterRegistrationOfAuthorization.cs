using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class cookStartFormAfterRegistrationOrAuthorization : Form
    {
        public cookStartFormAfterRegistrationOrAuthorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form2Cook frm2 = new Form2Cook();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form3Cook frm3 = new Form3Cook();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            cookRegistration cookReg = new cookRegistration();
            cookReg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            cookAuthorization cookAuthorization = new cookAuthorization();
            cookAuthorization.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            menuEditor edit = new menuEditor();
            edit.Show();
        }
        private void cookStartForm_Load(object sender, EventArgs e)
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
    }
}
