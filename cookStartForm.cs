using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class cookStartForm : Form
    {
        public bool authorizated;
        public cookStartForm()
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

        private void cookStartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
