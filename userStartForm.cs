using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class userStartForm : Form
    {
        public userStartForm()
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
    }
}
