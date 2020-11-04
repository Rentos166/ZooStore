﻿namespace Зоомагазин
{
    partial class FormCustoms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewProvider = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress_Home = new System.Windows.Forms.TextBox();
            this.labelAddress_Home = new System.Windows.Forms.Label();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 50);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // listViewProvider
            // 
            this.listViewProvider.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NameCompany,
            this.Address,
            this.Phone,
            this.Email});
            this.listViewProvider.FullRowSelect = true;
            this.listViewProvider.GridLines = true;
            this.listViewProvider.HideSelection = false;
            this.listViewProvider.Location = new System.Drawing.Point(122, 80);
            this.listViewProvider.Name = "listViewProvider";
            this.listViewProvider.Size = new System.Drawing.Size(606, 220);
            this.listViewProvider.TabIndex = 66;
            this.listViewProvider.UseCompatibleStateImageBehavior = false;
            this.listViewProvider.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // NameCompany
            // 
            this.NameCompany.Text = "Название компании:";
            this.NameCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameCompany.Width = 127;
            // 
            // Address
            // 
            this.Address.Text = "Адрес:";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 162;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон:";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 129;
            // 
            // Email
            // 
            this.Email.Text = "Почта:";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 123;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(7, 280);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 65;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(4, 264);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 13);
            this.labelEmail.TabIndex = 64;
            this.labelEmail.Text = "Почта:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(7, 240);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 63;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(4, 224);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 62;
            this.labelPhone.Text = "Телефон";
            // 
            // textBoxAddress_Home
            // 
            this.textBoxAddress_Home.Location = new System.Drawing.Point(7, 199);
            this.textBoxAddress_Home.Name = "textBoxAddress_Home";
            this.textBoxAddress_Home.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_Home.TabIndex = 61;
            // 
            // labelAddress_Home
            // 
            this.labelAddress_Home.AutoSize = true;
            this.labelAddress_Home.Location = new System.Drawing.Point(4, 183);
            this.labelAddress_Home.Name = "labelAddress_Home";
            this.labelAddress_Home.Size = new System.Drawing.Size(73, 13);
            this.labelAddress_Home.TabIndex = 60;
            this.labelAddress_Home.Text = "Номер дома:";
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Location = new System.Drawing.Point(7, 160);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_Street.TabIndex = 59;
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Location = new System.Drawing.Point(4, 144);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(42, 13);
            this.labelAddress_Street.TabIndex = 58;
            this.labelAddress_Street.Text = "Улица:";
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Location = new System.Drawing.Point(7, 120);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_City.TabIndex = 57;
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Location = new System.Drawing.Point(4, 104);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(40, 13);
            this.labelAddress_City.TabIndex = 56;
            this.labelAddress_City.Text = "Город:";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(7, 80);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyName.TabIndex = 55;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(4, 64);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(113, 13);
            this.labelCompanyName.TabIndex = 54;
            this.labelCompanyName.Text = "Название компании:";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(533, 306);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(195, 23);
            this.buttonDel.TabIndex = 53;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(332, 306);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(195, 23);
            this.buttonEdit.TabIndex = 52;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(122, 306);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(204, 23);
            this.buttonAdd.TabIndex = 51;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormCustoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewProvider);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxAddress_Home);
            this.Controls.Add(this.labelAddress_Home);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.textBoxAddress_City);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormCustoms";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewProvider;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NameCompany;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress_Home;
        private System.Windows.Forms.Label labelAddress_Home;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}