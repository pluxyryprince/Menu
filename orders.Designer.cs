
namespace Menu
{
    partial class orders
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
            this.dish = new System.Windows.Forms.ComboBox();
            this.drink = new System.Windows.Forms.ComboBox();
            this.place_num = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.menuDataSet = new Menu.menuDataSet();
            this.menuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wine_mapDataSet = new Menu.wine_mapDataSet();
            this.winemapDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wine_mapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winemapDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dish
            // 
            this.dish.FormattingEnabled = true;
            this.dish.Items.AddRange(new object[] {
            "Хлеб:",
            "Хлебная корзина с домашним маслом",
            "",
            "Десерты классические:",
            "Лаймовый мусс",
            "Фирменные эклеры",
            "Пять эклеров с разной начинкой в специальной подарочной упаковке",
            "Фирменные мини-капкейки",
            "Шесть мини-капкейков с разной начинкой в специальной подарочной упаковке",
            "Шоколадный десерт с миндалем",
            "Домашнее мороженое и сорбеты в ассортименте",
            "",
            "Десерты модерн:",
            "Композиция №7. Супрематизм",
            "Космос 2.0",
            "Композиция №1",
            "",
            "Блюда из рыбы:",
            "Тартар из лосося с дайконом",
            "Татаки из тунца",
            "Салат с маринованной макрелью и редисом",
            "Салат из семги с мандаринами",
            "Осьминог с тремя формами картофеля",
            "Жаренная треска c рагу из мидий и шпината",
            "Черный лосось с брусникой и яблочным пюре",
            "Сибас, запеченный с травами",
            "Осетрина гриль с мороженым из базилика",
            "",
            "Гарниры:",
            "Овощной рататуй",
            "Молодой картофель с розмарином",
            "",
            "Мясные блюда:",
            "Тартар из говяжей вырезки с кремом из черного чеснока",
            "Картофельная вафля с беконом, сладкими томатами и муссом из пармезана",
            "Салат из утки с грушей и ягодами годжи",
            "Салат с ростбифом",
            "Паштет из куриной печени с ревенем, клубникой и теплым луковым хлебом",
            "Томлённый говяжий язык в соусе из сладкой горчицы с малосольным огурцом ",
            "Филе-миньон с лжекартофелем, лесными грибами и трюфельным соусом ",
            "Строганов с грибами и картофельным кремом ",
            "Корейка ягненка с молодыми овощами",
            "",
            "Паста:",
            "Паста карбонара",
            "Паста с лососем",
            "Паста с вешенками и кедровыми орехами",
            "",
            "Закуски:",
            "Прошутто с грушей",
            "Сыр, клубника, мед",
            "Оливки, маслины",
            "Буррата с апельсинами и свеклой",
            "",
            "",
            "Супы:",
            "Горячий борщ с ростбифом и салом",
            "Том ям с креветками и осьминогом на кокосовом молоке",
            "Рыбный суп с осетриной и мидиями \t",
            "",
            "Овощные блюда:",
            "Печеная тыква с домашним йогуртом, кинзой из тайского манго",
            "Салат с печеными баклажанами и муссом из базилика",
            "Маринованная груша с джемом из сладкого перца и домашним сыром",
            "Стейк из капусты с копченным черносливом",
            "Спаржа на морковном пюре с яйцом пашот"});
            this.dish.Location = new System.Drawing.Point(13, 84);
            this.dish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dish.Name = "dish";
            this.dish.Size = new System.Drawing.Size(215, 28);
            this.dish.TabIndex = 0;
            this.dish.SelectedIndexChanged += new System.EventHandler(this.dish_SelectedIndexChanged);
            // 
            // drink
            // 
            this.drink.FormattingEnabled = true;
            this.drink.Items.AddRange(new object[] {
            "Игристое:",
            "Moli Dels Capellans L’Atzar Brut Nature Reserva Cava DO NV",
            "Grande Cuvee de Aimery 1531 Cremant de Limoux NV",
            "Bestheim Cremant d’Alsace Brut AOC",
            "Podere Il Saliceto Bi Fri Bianco dell’Emilia IGP 2017",
            "Christoph Hoch Kalkspitz Pét Nat NV",
            "MAN Family Wines Methode Cape Classique NV",
            "Tribaut Schloesser Brut Rose NV\t",
            "Jacquart Brut Mosaique NV ",
            "Laurent-Perrier La Cuvee Brut NV",
            "Jacquesson Cuvee 741 Extra Brut",
            "",
            "Розовое:",
            "Rivera Castel Del Monte Rose 2018",
            "",
            "Красное:",
            "Domaine Antonin Guyon Gevrey-Chambertin La Justice AOC 2015",
            "Domaine Antonin Guyon Gevrey-Chambertin La Justice AOC 2015",
            "Marcel Lapierre Raisins Gaulois VdF 2017",
            "Les Dauphins Reserve Cotes du Rhone AOC 2016",
            "E. Guigal Saint-Joseph Rouge 2013\t",
            "Chateau La Faviere Bordeaux Superieur",
            "Chateau Haut-Villet 2011\t",
            "Chateau Malescot St. Exupery AOC 3-em Grand Cru Classe ",
            "Philipp Kuhn Spatburgunder Tradition 2014",
            "Burg Ravensburg Lochle GG Pinot Noir 2013",
            "Schloss Gobelsburg St. Laurent Reserve Niederosterreich 2013",
            "Claus Preisinger Zweigelt Kieselstein 2018",
            "Bodegas Abadal 3,9 2012",
            "Bodegas San Alejandro Baltasar Gracian Vinas Viejas 2015",
            "Esencia Rural De Sol a Sol Natural Tempranillo VdM 2013",
            "Marques de Grinon Summa Varientalis 2014",
            "1000 Stories Zinfandel 2016",
            "Arboleda Carmenere Colchagua Valley DO 2015",
            "Pulenta Gran XV 2011",
            "Pulenta La Flor Malbec 2017",
            "Red Baron Fox Creek Shiraz 2016",
            "Fanagoria Cabernet Franc Винодел&Сомелье",
            "",
            "Белое:",
            "Domaine de la Garreliere Le Chenin de la Colline 2015",
            "Henri Bourgeois Pouilly-Fume La Demoiselle de Bourgeois 2015",
            "Gustave Lorentz Riesling Reserve Alsace AOC 2016",
            "Domaine Bernard Defaix Chablis Premier Cru Cote de Lechet Reserve 2016",
            "Antonin Rodet Puligny Montrachet AOC 2014",
            "Chardonnay Arbois Vins Rijckaert 2016",
            "Chateau Carbonnieux Blanc Pessac-Leognan AOC Grand Cru Classe de Graves 2011",
            "Antonutti Sauvignon Friuli Grave DOC 2016 ",
            "Rainer Wess Riesling KREMS Kremstal DAC 2015",
            "Roschitz Gruner Veltliner Weinviertel DAC 2017",
            "Casa Santos Lima Amoras Vinho Verde DOC",
            "Fairview Darling Chenin Blanc 2018",
            "Framingham Ribbonwood Riesling 2014"});
            this.drink.Location = new System.Drawing.Point(247, 84);
            this.drink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(215, 28);
            this.drink.TabIndex = 1;
            this.drink.SelectedIndexChanged += new System.EventHandler(this.drink_SelectedIndexChanged);
            // 
            // place_num
            // 
            this.place_num.Location = new System.Drawing.Point(13, 172);
            this.place_num.Name = "place_num";
            this.place_num.Size = new System.Drawing.Size(140, 26);
            this.place_num.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(13, 340);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(482, 49);
            this.button3.TabIndex = 20;
            this.button3.Text = "Сделать заказ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Выберите блюдо:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Выберите напиток:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Введите ваше место:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Введите ваше имя:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(16, 281);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(479, 26);
            this.name.TabIndex = 25;
            // 
            // menuDataSet
            // 
            this.menuDataSet.DataSetName = "menuDataSet";
            this.menuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuDataSetBindingSource
            // 
            this.menuDataSetBindingSource.DataSource = this.menuDataSet;
            this.menuDataSetBindingSource.Position = 0;
            // 
            // wine_mapDataSet
            // 
            this.wine_mapDataSet.DataSetName = "wine_mapDataSet";
            this.wine_mapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // winemapDataSetBindingSource
            // 
            this.winemapDataSetBindingSource.DataSource = this.wine_mapDataSet;
            this.winemapDataSetBindingSource.Position = 0;
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(508, 402);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.place_num);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.dish);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "orders";
            this.Text = "Сделать заказ";
            this.Load += new System.EventHandler(this.orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wine_mapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winemapDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dish;
        private System.Windows.Forms.ComboBox drink;
        private System.Windows.Forms.TextBox place_num;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.BindingSource menuDataSetBindingSource;
        private menuDataSet menuDataSet;
        private System.Windows.Forms.BindingSource winemapDataSetBindingSource;
        private wine_mapDataSet wine_mapDataSet;
    }
}