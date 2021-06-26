using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class menuEditor : Form
    {
        public menuEditor()
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
        private void menuEditor_Load(object sender, EventArgs e)
        {
            try
            {
                this.whiteTableAdapter.Fill(this.wine_mapDataSet.white);
                this.redTableAdapter.Fill(this.wine_mapDataSet.red);
                this.pinkTableAdapter.Fill(this.wine_mapDataSet.pink);
                this.sparklingTableAdapter.Fill(this.wine_mapDataSet.sparkling);
                this.breadTableAdapter.Fill(this.menuDataSet.bread);
                this.soupTableAdapter.Fill(this.menuDataSet.soup);
                this.pastaTableAdapter.Fill(this.menuDataSet.pasta);
                this.snacksTableAdapter.Fill(this.menuDataSet.snacks);
                this.meatTableAdapter.Fill(this.menuDataSet.meat);
                this.garnishTableAdapter.Fill(this.menuDataSet.garnish);
                this.fishTableAdapter.Fill(this.menuDataSet.fish);
                this.desserts_modernTableAdapter.Fill(this.menuDataSet.desserts_modern);
                this.desserts_classicTableAdapter.Fill(this.menuDataSet.desserts_classic);
                this.vegetablesTableAdapter.Fill(this.menuDataSet.vegetables);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
  
            this.FormClosing += MainForm_Closing;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.vegetablesTableAdapter.Update(this.menuDataSet.vegetables);
                this.soupTableAdapter.Update(this.menuDataSet.soup);
                this.pastaTableAdapter.Update(this.menuDataSet.pasta);
                this.snacksTableAdapter.Update(this.menuDataSet.snacks);
                this.meatTableAdapter.Update(this.menuDataSet.meat);
                this.garnishTableAdapter.Update(this.menuDataSet.garnish);
                this.fishTableAdapter.Update(this.menuDataSet.fish);
                this.desserts_modernTableAdapter.Update(this.menuDataSet.desserts_modern);
                this.desserts_classicTableAdapter.Update(this.menuDataSet.desserts_classic);
                this.breadTableAdapter.Update(this.menuDataSet.bread);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int delet = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(delet);

                int delet1 = dataGridView2.SelectedCells[0].RowIndex;
                dataGridView2.Rows.RemoveAt(delet);

                int delet2 = dataGridView3.SelectedCells[0].RowIndex;
                dataGridView3.Rows.RemoveAt(delet);

                int delet3 = dataGridView4.SelectedCells[0].RowIndex;
                dataGridView4.Rows.RemoveAt(delet);

                int delet4 = dataGridView5.SelectedCells[0].RowIndex;
                dataGridView5.Rows.RemoveAt(delet);

                int delet5 = dataGridView6.SelectedCells[0].RowIndex;
                dataGridView6.Rows.RemoveAt(delet);

                int delet6 = dataGridView7.SelectedCells[0].RowIndex;
                dataGridView7.Rows.RemoveAt(delet);

                int delet7 = dataGridView8.SelectedCells[0].RowIndex;
                dataGridView8.Rows.RemoveAt(delet);

                int delet8 = dataGridView9.SelectedCells[0].RowIndex;
                dataGridView9.Rows.RemoveAt(delet);

                int delet9 = dataGridView10.SelectedCells[0].RowIndex;
                dataGridView10.Rows.RemoveAt(delet);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int delet = dataGridView11.SelectedCells[0].RowIndex;
                dataGridView11.Rows.RemoveAt(delet);

                int delet1 = dataGridView12.SelectedCells[0].RowIndex;
                dataGridView12.Rows.RemoveAt(delet);

                int delet2 = dataGridView13.SelectedCells[0].RowIndex;
                dataGridView13.Rows.RemoveAt(delet);

                int delet3 = dataGridView14.SelectedCells[0].RowIndex;
                dataGridView14.Rows.RemoveAt(delet);
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.whiteTableAdapter.Update(this.wine_mapDataSet.white);
                this.redTableAdapter.Update(this.wine_mapDataSet.red);
                this.pinkTableAdapter.Update(this.wine_mapDataSet.pink);
                this.sparklingTableAdapter.Update(this.wine_mapDataSet.sparkling);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения к базе данных");
            }
        }
    }
}
