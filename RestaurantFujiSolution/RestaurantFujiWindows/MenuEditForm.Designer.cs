namespace RestaurantFujiWindows
{
    partial class MenuEditForm
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
            System.Windows.Forms.Label nameFoodLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label typeFoodLabel1;
            this.nameFoodTextBox = new System.Windows.Forms.TextBox();
            this.menuInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.typeFoodComboBox = new System.Windows.Forms.ComboBox();
            this.menuListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameFoodLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            typeFoodLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menuInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameFoodLabel
            // 
            nameFoodLabel.AutoSize = true;
            nameFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameFoodLabel.Location = new System.Drawing.Point(26, 41);
            nameFoodLabel.Name = "nameFoodLabel";
            nameFoodLabel.Size = new System.Drawing.Size(92, 13);
            nameFoodLabel.TabIndex = 1;
            nameFoodLabel.Text = "Название еды";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(26, 92);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(37, 13);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Цена";
            // 
            // typeFoodLabel1
            // 
            typeFoodLabel1.AutoSize = true;
            typeFoodLabel1.Location = new System.Drawing.Point(26, 151);
            typeFoodLabel1.Name = "typeFoodLabel1";
            typeFoodLabel1.Size = new System.Drawing.Size(56, 13);
            typeFoodLabel1.TabIndex = 7;
            typeFoodLabel1.Text = "Тип еды";
            // 
            // nameFoodTextBox
            // 
            this.nameFoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuInfoBindingSource, "NameFood", true));
            this.nameFoodTextBox.Location = new System.Drawing.Point(139, 38);
            this.nameFoodTextBox.Name = "nameFoodTextBox";
            this.nameFoodTextBox.Size = new System.Drawing.Size(231, 20);
            this.nameFoodTextBox.TabIndex = 2;
            // 
            // menuInfoBindingSource
            // 
            this.menuInfoBindingSource.DataSource = typeof(RestaurantFujiLibrary.MenuInfo);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuInfoBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(139, 85);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(116, 20);
            this.priceTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(106, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(283, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // typeFoodComboBox
            // 
            this.typeFoodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.menuInfoBindingSource, "TypeFood", true));
            this.typeFoodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menuInfoBindingSource, "TypeFood", true));
            this.typeFoodComboBox.DataSource = this.menuListBindingSource;
            this.typeFoodComboBox.DisplayMember = "TypeFood";
            this.typeFoodComboBox.FormattingEnabled = true;
            this.typeFoodComboBox.Location = new System.Drawing.Point(139, 148);
            this.typeFoodComboBox.Name = "typeFoodComboBox";
            this.typeFoodComboBox.Size = new System.Drawing.Size(231, 21);
            this.typeFoodComboBox.TabIndex = 8;
            this.typeFoodComboBox.ValueMember = "TypeFood";
            // 
            // menuListBindingSource
            // 
            this.menuListBindingSource.DataSource = typeof(RestaurantFujiLibrary.MenuList);
            // 
            // MenuEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 290);
            this.Controls.Add(typeFoodLabel1);
            this.Controls.Add(this.typeFoodComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(nameFoodLabel);
            this.Controls.Add(this.nameFoodTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MenuEditForm";
            this.Text = "Редактирование меню ресторана";
            this.Load += new System.EventHandler(this.MenuEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource menuInfoBindingSource;
        private System.Windows.Forms.TextBox nameFoodTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox typeFoodComboBox;
        private System.Windows.Forms.BindingSource menuListBindingSource;
    }
}