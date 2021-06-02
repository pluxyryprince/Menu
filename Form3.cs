﻿using System;
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
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
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
