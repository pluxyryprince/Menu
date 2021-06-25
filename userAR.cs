using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class userAR : Form
    {
        public userAR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            reservation reserv = new reservation();
            reserv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            orders ordrs = new orders();
            ordrs.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistration frm4 = new UserRegistration();
            frm4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationUser frm5 = new AuthorizationUser();
            frm5.Show();
        }

        private void userAR_Load(object sender, EventArgs e)
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
