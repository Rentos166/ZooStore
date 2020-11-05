namespace Зоомагазин
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenCustom = new System.Windows.Forms.Button();
            this.OpenStorage = new System.Windows.Forms.Button();
            this.OpenProvider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // OpenCustom
            // 
            this.OpenCustom.Location = new System.Drawing.Point(3, 177);
            this.OpenCustom.Name = "OpenCustom";
            this.OpenCustom.Size = new System.Drawing.Size(300, 42);
            this.OpenCustom.TabIndex = 6;
            this.OpenCustom.Text = "Заказы";
            this.OpenCustom.UseVisualStyleBackColor = true;
            this.OpenCustom.Click += new System.EventHandler(this.OpenCustom_Click);
            // 
            // OpenStorage
            // 
            this.OpenStorage.Location = new System.Drawing.Point(3, 129);
            this.OpenStorage.Name = "OpenStorage";
            this.OpenStorage.Size = new System.Drawing.Size(300, 42);
            this.OpenStorage.TabIndex = 5;
            this.OpenStorage.Text = "Склад";
            this.OpenStorage.UseVisualStyleBackColor = true;
            this.OpenStorage.Click += new System.EventHandler(this.OpenStorage_Click);
            // 
            // OpenProvider
            // 
            this.OpenProvider.Location = new System.Drawing.Point(3, 81);
            this.OpenProvider.Name = "OpenProvider";
            this.OpenProvider.Size = new System.Drawing.Size(300, 42);
            this.OpenProvider.TabIndex = 4;
            this.OpenProvider.Text = "Поставщики";
            this.OpenProvider.UseVisualStyleBackColor = true;
            this.OpenProvider.Click += new System.EventHandler(this.OpenProvider_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 373);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenCustom);
            this.Controls.Add(this.OpenStorage);
            this.Controls.Add(this.OpenProvider);
            this.Name = "FormMenu";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenCustom;
        private System.Windows.Forms.Button OpenStorage;
        private System.Windows.Forms.Button OpenProvider;
    }
}

