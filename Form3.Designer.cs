
namespace Menu
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coutryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparklingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wine_mapDataSet = new Menu.wine_mapDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.coutryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.coutryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.coutryDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sparklingTableAdapter = new Menu.wine_mapDataSetTableAdapters.sparklingTableAdapter();
            this.pinkTableAdapter = new Menu.wine_mapDataSetTableAdapters.pinkTableAdapter();
            this.redTableAdapter = new Menu.wine_mapDataSetTableAdapters.redTableAdapter();
            this.whiteTableAdapter = new Menu.wine_mapDataSetTableAdapters.whiteTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wine_mapDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1022, 548);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(18, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 524);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1156, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Игристое";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coutryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.volDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sparklingBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1148, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // coutryDataGridViewTextBoxColumn
            // 
            this.coutryDataGridViewTextBoxColumn.DataPropertyName = "coutry";
            this.coutryDataGridViewTextBoxColumn.HeaderText = "Страна производства";
            this.coutryDataGridViewTextBoxColumn.Name = "coutryDataGridViewTextBoxColumn";
            this.coutryDataGridViewTextBoxColumn.Width = 168;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // volDataGridViewTextBoxColumn
            // 
            this.volDataGridViewTextBoxColumn.DataPropertyName = "vol";
            this.volDataGridViewTextBoxColumn.HeaderText = "Объём";
            this.volDataGridViewTextBoxColumn.Name = "volDataGridViewTextBoxColumn";
            this.volDataGridViewTextBoxColumn.Width = 82;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена (руб.)";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 101;
            // 
            // sparklingBindingSource
            // 
            this.sparklingBindingSource.DataMember = "sparkling";
            this.sparklingBindingSource.DataSource = this.wine_mapDataSet;
            // 
            // wine_mapDataSet
            // 
            this.wine_mapDataSet.DataSetName = "wine_mapDataSet";
            this.wine_mapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1156, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Розовое";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coutryDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.volDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.pinkBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1148, 485);
            this.dataGridView2.TabIndex = 0;
            // 
            // coutryDataGridViewTextBoxColumn1
            // 
            this.coutryDataGridViewTextBoxColumn1.DataPropertyName = "coutry";
            this.coutryDataGridViewTextBoxColumn1.HeaderText = "Страна производства";
            this.coutryDataGridViewTextBoxColumn1.Name = "coutryDataGridViewTextBoxColumn1";
            this.coutryDataGridViewTextBoxColumn1.Width = 168;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // volDataGridViewTextBoxColumn1
            // 
            this.volDataGridViewTextBoxColumn1.DataPropertyName = "vol";
            this.volDataGridViewTextBoxColumn1.HeaderText = "Объём";
            this.volDataGridViewTextBoxColumn1.Name = "volDataGridViewTextBoxColumn1";
            this.volDataGridViewTextBoxColumn1.Width = 82;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена (руб.)";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 101;
            // 
            // pinkBindingSource
            // 
            this.pinkBindingSource.DataMember = "pink";
            this.pinkBindingSource.DataSource = this.wine_mapDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1156, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Красное";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coutryDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.volDataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.redBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(4, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1148, 485);
            this.dataGridView3.TabIndex = 0;
            // 
            // coutryDataGridViewTextBoxColumn2
            // 
            this.coutryDataGridViewTextBoxColumn2.DataPropertyName = "coutry";
            this.coutryDataGridViewTextBoxColumn2.HeaderText = "Страна производства";
            this.coutryDataGridViewTextBoxColumn2.Name = "coutryDataGridViewTextBoxColumn2";
            this.coutryDataGridViewTextBoxColumn2.Width = 168;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // volDataGridViewTextBoxColumn2
            // 
            this.volDataGridViewTextBoxColumn2.DataPropertyName = "vol";
            this.volDataGridViewTextBoxColumn2.HeaderText = "Объём";
            this.volDataGridViewTextBoxColumn2.Name = "volDataGridViewTextBoxColumn2";
            this.volDataGridViewTextBoxColumn2.Width = 82;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn2.HeaderText = "Цена (руб.)";
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.Width = 101;
            // 
            // redBindingSource
            // 
            this.redBindingSource.DataMember = "red";
            this.redBindingSource.DataSource = this.wine_mapDataSet;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1156, 493);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Белое";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coutryDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn3,
            this.volDataGridViewTextBoxColumn3,
            this.priceDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.whiteBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(4, 4);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1148, 485);
            this.dataGridView4.TabIndex = 0;
            // 
            // coutryDataGridViewTextBoxColumn3
            // 
            this.coutryDataGridViewTextBoxColumn3.DataPropertyName = "coutry";
            this.coutryDataGridViewTextBoxColumn3.HeaderText = "Страна производства";
            this.coutryDataGridViewTextBoxColumn3.Name = "coutryDataGridViewTextBoxColumn3";
            this.coutryDataGridViewTextBoxColumn3.Width = 168;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // volDataGridViewTextBoxColumn3
            // 
            this.volDataGridViewTextBoxColumn3.DataPropertyName = "vol";
            this.volDataGridViewTextBoxColumn3.HeaderText = "Объём ";
            this.volDataGridViewTextBoxColumn3.Name = "volDataGridViewTextBoxColumn3";
            this.volDataGridViewTextBoxColumn3.Width = 86;
            // 
            // priceDataGridViewTextBoxColumn3
            // 
            this.priceDataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn3.HeaderText = "Цена (руб.)";
            this.priceDataGridViewTextBoxColumn3.Name = "priceDataGridViewTextBoxColumn3";
            this.priceDataGridViewTextBoxColumn3.Width = 101;
            // 
            // whiteBindingSource
            // 
            this.whiteBindingSource.DataMember = "white";
            this.whiteBindingSource.DataSource = this.wine_mapDataSet;
            // 
            // sparklingTableAdapter
            // 
            this.sparklingTableAdapter.ClearBeforeFill = true;
            // 
            // pinkTableAdapter
            // 
            this.pinkTableAdapter.ClearBeforeFill = true;
            // 
            // redTableAdapter
            // 
            this.redTableAdapter.ClearBeforeFill = true;
            // 
            // whiteTableAdapter
            // 
            this.whiteTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Винная карта";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparklingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wine_mapDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private wine_mapDataSet wine_mapDataSet;
        private System.Windows.Forms.BindingSource sparklingBindingSource;
        private wine_mapDataSetTableAdapters.sparklingTableAdapter sparklingTableAdapter;
        private System.Windows.Forms.BindingSource pinkBindingSource;
        private wine_mapDataSetTableAdapters.pinkTableAdapter pinkTableAdapter;
        private System.Windows.Forms.BindingSource redBindingSource;
        private wine_mapDataSetTableAdapters.redTableAdapter redTableAdapter;
        private System.Windows.Forms.BindingSource whiteBindingSource;
        private wine_mapDataSetTableAdapters.whiteTableAdapter whiteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn volDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn volDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coutryDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn volDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn3;
    }
}