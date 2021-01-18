namespace RestaurantFujiWindows
{
    partial class DetailDeliveryEditForm
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
            System.Windows.Forms.Label requestIDLabel;
            System.Windows.Forms.Label numberFoodLabel;
            System.Windows.Forms.Label foodIDLabel;
            System.Windows.Forms.Label sumFoodLabel1;
            this.detailDeliveryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestIDTextBox = new System.Windows.Forms.TextBox();
            this.numberFoodTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodIDComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sumFoodTextBox = new System.Windows.Forms.TextBox();
            requestIDLabel = new System.Windows.Forms.Label();
            numberFoodLabel = new System.Windows.Forms.Label();
            foodIDLabel = new System.Windows.Forms.Label();
            sumFoodLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detailDeliveryInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestIDLabel
            // 
            requestIDLabel.AutoSize = true;
            requestIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            requestIDLabel.Location = new System.Drawing.Point(22, 45);
            requestIDLabel.Name = "requestIDLabel";
            requestIDLabel.Size = new System.Drawing.Size(66, 13);
            requestIDLabel.TabIndex = 1;
            requestIDLabel.Text = "№ Заявки";
            // 
            // numberFoodLabel
            // 
            numberFoodLabel.AutoSize = true;
            numberFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberFoodLabel.Location = new System.Drawing.Point(22, 146);
            numberFoodLabel.Name = "numberFoodLabel";
            numberFoodLabel.Size = new System.Drawing.Size(76, 13);
            numberFoodLabel.TabIndex = 4;
            numberFoodLabel.Text = "Количество";
            // 
            // foodIDLabel
            // 
            foodIDLabel.AutoSize = true;
            foodIDLabel.Location = new System.Drawing.Point(22, 99);
            foodIDLabel.Name = "foodIDLabel";
            foodIDLabel.Size = new System.Drawing.Size(92, 13);
            foodIDLabel.TabIndex = 10;
            foodIDLabel.Text = "Название еды";
            // 
            // detailDeliveryInfoBindingSource
            // 
            this.detailDeliveryInfoBindingSource.DataSource = typeof(RestaurantFujiLibrary.DetailDeliveryInfo);
            // 
            // requestIDTextBox
            // 
            this.requestIDTextBox.Enabled = false;
            this.requestIDTextBox.Location = new System.Drawing.Point(135, 42);
            this.requestIDTextBox.Name = "requestIDTextBox";
            this.requestIDTextBox.Size = new System.Drawing.Size(116, 20);
            this.requestIDTextBox.TabIndex = 2;
            // 
            // numberFoodTextBox
            // 
            this.numberFoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailDeliveryInfoBindingSource, "NumberFood", true));
            this.numberFoodTextBox.Location = new System.Drawing.Point(135, 146);
            this.numberFoodTextBox.Name = "numberFoodTextBox";
            this.numberFoodTextBox.Size = new System.Drawing.Size(116, 20);
            this.numberFoodTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(236, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(356, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuListBindingSource
            // 
            this.menuListBindingSource.DataSource = typeof(RestaurantFujiLibrary.MenuList);
            // 
            // foodIDComboBox
            // 
            this.foodIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detailDeliveryInfoBindingSource, "FoodID", true));
            this.foodIDComboBox.DataSource = this.menuListBindingSource;
            this.foodIDComboBox.DisplayMember = "NameFood";
            this.foodIDComboBox.FormattingEnabled = true;
            this.foodIDComboBox.IntegralHeight = false;
            this.foodIDComboBox.Location = new System.Drawing.Point(135, 96);
            this.foodIDComboBox.Name = "foodIDComboBox";
            this.foodIDComboBox.Size = new System.Drawing.Size(226, 21);
            this.foodIDComboBox.TabIndex = 11;
            this.foodIDComboBox.ValueMember = "ID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "Рассчитать стоимость";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sumFoodLabel1
            // 
            sumFoodLabel1.AutoSize = true;
            sumFoodLabel1.Location = new System.Drawing.Point(22, 201);
            sumFoodLabel1.Name = "sumFoodLabel1";
            sumFoodLabel1.Size = new System.Drawing.Size(46, 13);
            sumFoodLabel1.TabIndex = 12;
            sumFoodLabel1.Text = "Сумма";
            // 
            // sumFoodTextBox
            // 
            this.sumFoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailDeliveryInfoBindingSource, "SumFood", true));
            this.sumFoodTextBox.Enabled = false;
            this.sumFoodTextBox.Location = new System.Drawing.Point(135, 198);
            this.sumFoodTextBox.Name = "sumFoodTextBox";
            this.sumFoodTextBox.Size = new System.Drawing.Size(116, 20);
            this.sumFoodTextBox.TabIndex = 13;
            // 
            // DetailDeliveryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 319);
            this.Controls.Add(sumFoodLabel1);
            this.Controls.Add(this.sumFoodTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(foodIDLabel);
            this.Controls.Add(this.foodIDComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(numberFoodLabel);
            this.Controls.Add(this.numberFoodTextBox);
            this.Controls.Add(requestIDLabel);
            this.Controls.Add(this.requestIDTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DetailDeliveryEditForm";
            this.Text = "Добавление деталей доставки";
            this.Load += new System.EventHandler(this.DetailDeliveryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailDeliveryInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource detailDeliveryInfoBindingSource;
        private System.Windows.Forms.TextBox requestIDTextBox;
        private System.Windows.Forms.TextBox numberFoodTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource menuListBindingSource;
        private System.Windows.Forms.ComboBox foodIDComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox sumFoodTextBox;
    }
}