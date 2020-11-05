namespace Зоомагазин
{
    partial class sssss
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
            this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewCustoms = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxNumberProduct = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxMkProduct = new System.Windows.Forms.TextBox();
            this.labelMk = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerCustom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTypeProduct
            // 
            this.comboBoxTypeProduct.FormattingEnabled = true;
            this.comboBoxTypeProduct.Items.AddRange(new object[] {
            "Корм",
            "Игрушки",
            "Поводки",
            "Медикаменты"});
            this.comboBoxTypeProduct.Location = new System.Drawing.Point(8, 156);
            this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            this.comboBoxTypeProduct.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTypeProduct.TabIndex = 86;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(8, 77);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvider.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(214, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1017, 50);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // listViewCustoms
            // 
            this.listViewCustoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Provider,
            this.Name,
            this.Type,
            this.Mk,
            this.Number,
            this.Price,
            this.Date,
            this.Status});
            this.listViewCustoms.FullRowSelect = true;
            this.listViewCustoms.GridLines = true;
            this.listViewCustoms.HideSelection = false;
            this.listViewCustoms.Location = new System.Drawing.Point(214, 77);
            this.listViewCustoms.Name = "listViewCustoms";
            this.listViewCustoms.Size = new System.Drawing.Size(1017, 299);
            this.listViewCustoms.TabIndex = 83;
            this.listViewCustoms.UseCompatibleStateImageBehavior = false;
            this.listViewCustoms.View = System.Windows.Forms.View.Details;
            this.listViewCustoms.SelectedIndexChanged += new System.EventHandler(this.listViewCustoms_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Provider
            // 
            this.Provider.Text = "Поставщик:";
            this.Provider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Provider.Width = 127;
            // 
            // Name
            // 
            this.Name.Text = "Наименование:";
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name.Width = 162;
            // 
            // Type
            // 
            this.Type.Text = "Тип:";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 129;
            // 
            // Mk
            // 
            this.Mk.Text = "Серийный номер:";
            this.Mk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mk.Width = 123;
            // 
            // Number
            // 
            this.Number.Text = "Количество:";
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number.Width = 101;
            // 
            // Price
            // 
            this.Price.Text = "Цена:";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 99;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(8, 277);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrice.TabIndex = 82;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(5, 261);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 81;
            this.labelPrice.Text = "Цена:";
            // 
            // textBoxNumberProduct
            // 
            this.textBoxNumberProduct.Location = new System.Drawing.Point(8, 237);
            this.textBoxNumberProduct.Name = "textBoxNumberProduct";
            this.textBoxNumberProduct.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumberProduct.TabIndex = 80;
            this.textBoxNumberProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberProduct_KeyPress);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(5, 221);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(69, 13);
            this.labelNumber.TabIndex = 79;
            this.labelNumber.Text = "Количество:";
            // 
            // textBoxMkProduct
            // 
            this.textBoxMkProduct.Location = new System.Drawing.Point(8, 196);
            this.textBoxMkProduct.Name = "textBoxMkProduct";
            this.textBoxMkProduct.Size = new System.Drawing.Size(200, 20);
            this.textBoxMkProduct.TabIndex = 78;
            this.textBoxMkProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMkProduct_KeyPress);
            // 
            // labelMk
            // 
            this.labelMk.AutoSize = true;
            this.labelMk.Location = new System.Drawing.Point(5, 180);
            this.labelMk.Name = "labelMk";
            this.labelMk.Size = new System.Drawing.Size(96, 13);
            this.labelMk.TabIndex = 77;
            this.labelMk.Text = "Серийный номер:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(5, 139);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(29, 13);
            this.labelType.TabIndex = 76;
            this.labelType.Text = "Тип:";
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Location = new System.Drawing.Point(8, 117);
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(200, 20);
            this.textBoxNameProduct.TabIndex = 75;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 101);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 74;
            this.labelName.Text = "Наименование:";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(5, 61);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(68, 13);
            this.labelProvider.TabIndex = 73;
            this.labelProvider.Text = "Поставщик:";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(894, 381);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(337, 23);
            this.buttonDel.TabIndex = 72;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(558, 381);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(330, 23);
            this.buttonEdit.TabIndex = 71;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(214, 382);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(338, 23);
            this.buttonAdd.TabIndex = 70;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Date
            // 
            this.Date.Text = "Дата:";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 109;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(5, 300);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 87;
            this.labelDate.Text = "Дата:";
            // 
            // dateTimePickerCustom
            // 
            this.dateTimePickerCustom.Location = new System.Drawing.Point(8, 317);
            this.dateTimePickerCustom.Name = "dateTimePickerCustom";
            this.dateTimePickerCustom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCustom.TabIndex = 89;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Заказ формируется",
            "Отправка заказа",
            "Заказ отправлен",
            "Доставлено"});
            this.comboBoxStatus.Location = new System.Drawing.Point(8, 356);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStatus.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Статус заказа:";
            // 
            // Status
            // 
            this.Status.Text = "Статус заказа:";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 99;
            // 
            // sssss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 416);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerCustom);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxTypeProduct);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewCustoms);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxNumberProduct);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textBoxMkProduct);
            this.Controls.Add(this.labelMk);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxNameProduct);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeProduct;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewCustoms;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Mk;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxNumberProduct;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxMkProduct;
        private System.Windows.Forms.Label labelMk;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCustom;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Status;
    }
}