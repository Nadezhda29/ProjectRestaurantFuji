namespace RestaurantFujiWindows
{
    partial class ProductEditForm
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
            System.Windows.Forms.Label nameProductLabel;
            System.Windows.Forms.Label priceProductLabel;
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceProductTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameProductLabel = new System.Windows.Forms.Label();
            priceProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameProductLabel
            // 
            nameProductLabel.AutoSize = true;
            nameProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameProductLabel.Location = new System.Drawing.Point(24, 48);
            nameProductLabel.Name = "nameProductLabel";
            nameProductLabel.Size = new System.Drawing.Size(95, 13);
            nameProductLabel.TabIndex = 1;
            nameProductLabel.Text = "Наименование";
            // 
            // priceProductLabel
            // 
            priceProductLabel.AutoSize = true;
            priceProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceProductLabel.Location = new System.Drawing.Point(24, 110);
            priceProductLabel.Name = "priceProductLabel";
            priceProductLabel.Size = new System.Drawing.Size(37, 13);
            priceProductLabel.TabIndex = 3;
            priceProductLabel.Text = "Цена";
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "NameProduct", true));
            this.nameProductTextBox.Location = new System.Drawing.Point(148, 45);
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.Size = new System.Drawing.Size(195, 20);
            this.nameProductTextBox.TabIndex = 2;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataSource = typeof(RestaurantFujiLibrary.ProductInfo);
            // 
            // priceProductTextBox
            // 
            this.priceProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productInfoBindingSource, "PriceProduct", true));
            this.priceProductTextBox.Location = new System.Drawing.Point(148, 110);
            this.priceProductTextBox.Name = "priceProductTextBox";
            this.priceProductTextBox.Size = new System.Drawing.Size(116, 20);
            this.priceProductTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(89, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(274, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(priceProductLabel);
            this.Controls.Add(this.priceProductTextBox);
            this.Controls.Add(nameProductLabel);
            this.Controls.Add(this.nameProductTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ProductEditForm";
            this.Text = "Новый продукт";
            this.Load += new System.EventHandler(this.ProductEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.TextBox priceProductTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}