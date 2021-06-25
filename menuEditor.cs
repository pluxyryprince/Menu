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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.white". При необходимости она может быть перемещена или удалена.
            this.whiteTableAdapter.Fill(this.wine_mapDataSet.white);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.red". При необходимости она может быть перемещена или удалена.
            this.redTableAdapter.Fill(this.wine_mapDataSet.red);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.pink". При необходимости она может быть перемещена или удалена.
            this.pinkTableAdapter.Fill(this.wine_mapDataSet.pink);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wine_mapDataSet.sparkling". При необходимости она может быть перемещена или удалена.
            this.sparklingTableAdapter.Fill(this.wine_mapDataSet.sparkling);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.bread". При необходимости она может быть перемещена или удалена.
            this.breadTableAdapter.Fill(this.menuDataSet.bread);
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "menuDataSet.vegetables". При необходимости она может быть перемещена или удалена.
            this.vegetablesTableAdapter.Fill(this.menuDataSet.vegetables);


            this.FormClosing += MainForm_Closing;
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
                this.whiteTableAdapter.Update(this.wine_mapDataSet.white);
                this.redTableAdapter.Update(this.wine_mapDataSet.red);
                this.pinkTableAdapter.Update(this.wine_mapDataSet.pink);
                this.sparklingTableAdapter.Update(this.wine_mapDataSet.sparkling);
        }
    }
}
