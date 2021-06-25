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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //переназначение крестика на форме чтобы он закрывал все формы сразу
        //на случай, если в ходе работы приложения было открыто более одной формы
        //если не переназначать эту кнопку, то приложение не сможет полностью закрыться, если было открыто более одной формы, т.к. другие формы останутся висеть в процессах
        {
            Application.Exit();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.FormClosing += MainForm_Closing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            userStartForm frm1 = new userStartForm();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            cookStartForm cookStFrm = new cookStartForm();
            cookStFrm.Show();
        }
    }
}
