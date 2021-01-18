namespace RestaurantFujiWindows
{
    partial class SupplyEditForm
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
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label numberProductLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label sumSupplyLabel1;
            System.Windows.Forms.Label dateValueLabel;
            this.supplyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.supplierListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberProductTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.productListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierIDComboBox = new System.Windows.Forms.ComboBox();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dateListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumSupplyTextBox = new System.Windows.Forms.TextBox();
            this.dateValueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            phoneLabel = new System.Windows.Forms.Label();
            numberProductLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            sumSupplyLabel1 = new System.Windows.Forms.Label();
            dateValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplyInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(14, 86);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(135, 13);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "Телефон поставщика";
            // 
            // numberProductLabel
            // 
            numberProductLabel.AutoSize = true;
            numberProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberProductLabel.Location = new System.Drawing.Point(15, 227);
            numberProductLabel.Name = "numberProductLabel";
            numberProductLabel.Size = new System.Drawing.Size(76, 13);
            numberProductLabel.TabIndex = 8;
            numberProductLabel.Text = "Количество";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(15, 34);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(141, 13);
            supplierIDLabel.TabIndex = 17;
            supplierIDLabel.Text = "Название поставщика";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(15, 181);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(123, 13);
            productIDLabel.TabIndex = 18;
            productIDLabel.Text = "Название продукта";
            // 
            // sumSupplyLabel1
            // 
            sumSupplyLabel1.AutoSize = true;
            sumSupplyLabel1.Location = new System.Drawing.Point(15, 275);
            sumSupplyLabel1.Name = "sumSupplyLabel1";
            sumSupplyLabel1.Size = new System.Drawing.Size(46, 13);
            sumSupplyLabel1.TabIndex = 21;
            sumSupplyLabel1.Text = "Сумма";
            // 
            // dateValueLabel
            // 
            dateValueLabel.AutoSize = true;
            dateValueLabel.Location = new System.Drawing.Point(15, 133);
            dateValueLabel.Name = "dateValueLabel";
            dateValueLabel.Size = new System.Drawing.Size(96, 13);
            dateValueLabel.TabIndex = 22;
            dateValueLabel.Text = "Дата поставки";
            // 
            // supplyInfoBindingSource
            // 
            this.supplyInfoBindingSource.DataSource = typeof(RestaurantFujiLibrary.SupplyInfo);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierListBindingSource, "Phone", true));
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(175, 83);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(233, 20);
            this.phoneTextBox.TabIndex = 3;
            // 
            // supplierListBindingSource
            // 
            this.supplierListBindingSource.DataSource = typeof(RestaurantFujiLibrary.SupplierList);
            // 
            // numberProductTextBox
            // 
            this.numberProductTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplyInfoBindingSource, "NumberProduct", true));
            this.numberProductTextBox.Location = new System.Drawing.Point(175, 227);
            this.numberProductTextBox.Name = "numberProductTextBox";
            this.numberProductTextBox.Size = new System.Drawing.Size(116, 20);
            this.numberProductTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Новый поставщик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Новый продукт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(343, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(498, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // productListBindingSource
            // 
            this.productListBindingSource.DataSource = typeof(RestaurantFujiLibrary.ProductList);
            // 
            // supplierIDComboBox
            // 
            this.supplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplyInfoBindingSource, "SupplierID", true));
            this.supplierIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierListBindingSource, "NameSupplier", true));
            this.supplierIDComboBox.DataSource = this.supplierListBindingSource;
            this.supplierIDComboBox.DisplayMember = "NameSupplier";
            this.supplierIDComboBox.FormattingEnabled = true;
            this.supplierIDComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.supplierIDComboBox.Location = new System.Drawing.Point(175, 31);
            this.supplierIDComboBox.Name = "supplierIDComboBox";
            this.supplierIDComboBox.Size = new System.Drawing.Size(233, 21);
            this.supplierIDComboBox.TabIndex = 18;
            this.supplierIDComboBox.ValueMember = "ID";
            this.supplierIDComboBox.SelectedIndexChanged += new System.EventHandler(this.supplierIDComboBox_SelectedIndexChanged);
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplyInfoBindingSource, "ProductID", true));
            this.productIDComboBox.DataSource = this.productListBindingSource;
            this.productIDComboBox.DisplayMember = "NameProduct";
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(175, 181);
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(233, 21);
            this.productIDComboBox.TabIndex = 19;
            this.productIDComboBox.ValueMember = "ID";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(343, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 35);
            this.button5.TabIndex = 20;
            this.button5.Text = "Рассчитать стоимость";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateListBindingSource
            // 
            this.dateListBindingSource.DataSource = typeof(RestaurantFujiLibrary.DateList);
            // 
            // sumSupplyTextBox
            // 
            this.sumSupplyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplyInfoBindingSource, "SumSupply", true));
            this.sumSupplyTextBox.Enabled = false;
            this.sumSupplyTextBox.Location = new System.Drawing.Point(175, 272);
            this.sumSupplyTextBox.Name = "sumSupplyTextBox";
            this.sumSupplyTextBox.Size = new System.Drawing.Size(116, 20);
            this.sumSupplyTextBox.TabIndex = 22;
            // 
            // dateValueDateTimePicker
            // 
            this.dateValueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dateListBindingSource, "DateValue", true));
            this.dateValueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.supplyInfoBindingSource, "DateID", true));
            this.dateValueDateTimePicker.Location = new System.Drawing.Point(175, 133);
            this.dateValueDateTimePicker.Name = "dateValueDateTimePicker";
            this.dateValueDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.dateValueDateTimePicker.TabIndex = 23;
            // 
            // SupplyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 387);
            this.Controls.Add(dateValueLabel);
            this.Controls.Add(this.dateValueDateTimePicker);
            this.Controls.Add(sumSupplyLabel1);
            this.Controls.Add(this.sumSupplyTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDComboBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDComboBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(numberProductLabel);
            this.Controls.Add(this.numberProductTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SupplyEditForm";
            this.Text = "Новая поставка";
            this.Load += new System.EventHandler(this.SupplyEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplyInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource supplyInfoBindingSource;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox numberProductTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource supplierListBindingSource;
        private System.Windows.Forms.BindingSource productListBindingSource;
        private System.Windows.Forms.ComboBox supplierIDComboBox;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource dateListBindingSource;
        private System.Windows.Forms.TextBox sumSupplyTextBox;
        private System.Windows.Forms.DateTimePicker dateValueDateTimePicker;
    }
}