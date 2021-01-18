namespace RestaurantFujiWindows
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonWorker = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonSupply = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelivery.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelivery.Location = new System.Drawing.Point(18, 74);
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelivery.Size = new System.Drawing.Size(85, 50);
            this.buttonDelivery.TabIndex = 0;
            this.buttonDelivery.Text = "Доставка";
            this.buttonDelivery.UseVisualStyleBackColor = false;
            this.buttonDelivery.Click += new System.EventHandler(this.buttonDelivery_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMenu.Location = new System.Drawing.Point(190, 74);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(85, 50);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Меню";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonWorker
            // 
            this.buttonWorker.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWorker.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonWorker.Location = new System.Drawing.Point(346, 74);
            this.buttonWorker.Name = "buttonWorker";
            this.buttonWorker.Size = new System.Drawing.Size(85, 50);
            this.buttonWorker.TabIndex = 2;
            this.buttonWorker.Text = "Сотрудники службы доставки";
            this.buttonWorker.UseVisualStyleBackColor = false;
            this.buttonWorker.Click += new System.EventHandler(this.buttonWorker_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCustomer.Location = new System.Drawing.Point(434, 192);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(85, 50);
            this.buttonCustomer.TabIndex = 3;
            this.buttonCustomer.Text = "Клиенты";
            this.buttonCustomer.UseVisualStyleBackColor = false;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonSupply
            // 
            this.buttonSupply.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSupply.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSupply.Location = new System.Drawing.Point(518, 74);
            this.buttonSupply.Name = "buttonSupply";
            this.buttonSupply.Size = new System.Drawing.Size(85, 50);
            this.buttonSupply.TabIndex = 4;
            this.buttonSupply.Text = "Поставки";
            this.buttonSupply.UseVisualStyleBackColor = false;
            this.buttonSupply.Click += new System.EventHandler(this.buttonSupply_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSupplier.Location = new System.Drawing.Point(99, 192);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(91, 50);
            this.buttonSupplier.TabIndex = 5;
            this.buttonSupplier.Text = "Поставщики";
            this.buttonSupplier.UseVisualStyleBackColor = false;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProduct.Location = new System.Drawing.Point(262, 192);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(85, 50);
            this.buttonProduct.TabIndex = 6;
            this.buttonProduct.Text = "Продукты";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(621, 301);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonSupplier);
            this.Controls.Add(this.buttonSupply);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonWorker);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonDelivery);
            this.Name = "MainForm";
            this.Text = "Ресторан \"Фуджи\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelivery;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonWorker;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonSupply;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonProduct;
    }
}

