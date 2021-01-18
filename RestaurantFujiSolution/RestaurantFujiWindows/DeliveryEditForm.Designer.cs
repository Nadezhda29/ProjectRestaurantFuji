namespace RestaurantFujiWindows
{
    partial class DeliveryEditForm
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
            System.Windows.Forms.Label dateValueLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label requestIDLabel1;
            System.Windows.Forms.Label workerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressCustomerLabel;
            System.Windows.Forms.Label sumDeliveryLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deliveryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateValueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.workerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.requestIDTextBox = new System.Windows.Forms.TextBox();
            this.workerIDComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressCustomerTextBox = new System.Windows.Forms.TextBox();
            this.sumDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.dateListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateValueLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            requestIDLabel1 = new System.Windows.Forms.Label();
            workerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressCustomerLabel = new System.Windows.Forms.Label();
            sumDeliveryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateValueLabel
            // 
            dateValueLabel.AutoSize = true;
            dateValueLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            dateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dateValueLabel.Location = new System.Drawing.Point(15, 233);
            dateValueLabel.Name = "dateValueLabel";
            dateValueLabel.Size = new System.Drawing.Size(96, 13);
            dateValueLabel.TabIndex = 12;
            dateValueLabel.Text = "Дата доставки";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(15, 152);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(111, 13);
            customerIDLabel.TabIndex = 24;
            customerIDLabel.Text = "Телефон клиента";
            // 
            // requestIDLabel1
            // 
            requestIDLabel1.AutoSize = true;
            requestIDLabel1.Location = new System.Drawing.Point(15, 31);
            requestIDLabel1.Name = "requestIDLabel1";
            requestIDLabel1.Size = new System.Drawing.Size(66, 13);
            requestIDLabel1.TabIndex = 26;
            requestIDLabel1.Text = "№ Заявки";
            // 
            // workerIDLabel
            // 
            workerIDLabel.AutoSize = true;
            workerIDLabel.Location = new System.Drawing.Point(14, 63);
            workerIDLabel.Name = "workerIDLabel";
            workerIDLabel.Size = new System.Drawing.Size(135, 26);
            workerIDLabel.TabIndex = 27;
            workerIDLabel.Text = "Фамилия сотрудника\r\nслужбы доставки\r\n";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(15, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(111, 26);
            nameLabel.TabIndex = 28;
            nameLabel.Text = "Имя сотрудника\r\nслужбы доставки";
            // 
            // addressCustomerLabel
            // 
            addressCustomerLabel.AutoSize = true;
            addressCustomerLabel.Location = new System.Drawing.Point(15, 192);
            addressCustomerLabel.Name = "addressCustomerLabel";
            addressCustomerLabel.Size = new System.Drawing.Size(102, 13);
            addressCustomerLabel.TabIndex = 29;
            addressCustomerLabel.Text = "Адрес доставки";
            // 
            // sumDeliveryLabel
            // 
            sumDeliveryLabel.AutoSize = true;
            sumDeliveryLabel.Location = new System.Drawing.Point(15, 280);
            sumDeliveryLabel.Name = "sumDeliveryLabel";
            sumDeliveryLabel.Size = new System.Drawing.Size(92, 13);
            sumDeliveryLabel.TabIndex = 30;
            sumDeliveryLabel.Text = "Сумма заказа";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(371, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(513, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deliveryInfoBindingSource
            // 
            this.deliveryInfoBindingSource.DataSource = typeof(RestaurantFujiLibrary.DeliveryInfo);
            // 
            // dateValueDateTimePicker
            // 
            this.dateValueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dateListBindingSource, "DateValue", true));
            this.dateValueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryInfoBindingSource, "DateID", true));
            this.dateValueDateTimePicker.Location = new System.Drawing.Point(175, 233);
            this.dateValueDateTimePicker.Name = "dateValueDateTimePicker";
            this.dateValueDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateValueDateTimePicker.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = "Новый клиент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 59);
            this.button4.TabIndex = 20;
            this.button4.Text = "Добавить детали";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 365);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // workerListBindingSource
            // 
            this.workerListBindingSource.DataSource = typeof(RestaurantFujiLibrary.WorkerList);
            // 
            // customerListBindingSource
            // 
            this.customerListBindingSource.DataSource = typeof(RestaurantFujiLibrary.CustomerList);
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deliveryInfoBindingSource, "CustomerID", true));
            this.customerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerListBindingSource, "Phone", true));
            this.customerIDComboBox.DataSource = this.customerListBindingSource;
            this.customerIDComboBox.DisplayMember = "Phone";
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(174, 149);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(203, 21);
            this.customerIDComboBox.TabIndex = 25;
            this.customerIDComboBox.ValueMember = "ID";
            this.customerIDComboBox.SelectedIndexChanged += new System.EventHandler(this.customerIDComboBox_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(442, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 39);
            this.button5.TabIndex = 26;
            this.button5.Text = "Рассчитать стоимость";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // requestIDTextBox
            // 
            this.requestIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryInfoBindingSource, "RequestID", true));
            this.requestIDTextBox.Enabled = false;
            this.requestIDTextBox.Location = new System.Drawing.Point(174, 28);
            this.requestIDTextBox.Name = "requestIDTextBox";
            this.requestIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestIDTextBox.TabIndex = 27;
            // 
            // workerIDComboBox
            // 
            this.workerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deliveryInfoBindingSource, "WorkerID", true));
            this.workerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerListBindingSource, "Surname", true));
            this.workerIDComboBox.DataSource = this.workerListBindingSource;
            this.workerIDComboBox.DisplayMember = "Surname";
            this.workerIDComboBox.FormattingEnabled = true;
            this.workerIDComboBox.Location = new System.Drawing.Point(174, 68);
            this.workerIDComboBox.Name = "workerIDComboBox";
            this.workerIDComboBox.Size = new System.Drawing.Size(203, 21);
            this.workerIDComboBox.TabIndex = 28;
            this.workerIDComboBox.ValueMember = "ID";
            this.workerIDComboBox.SelectedIndexChanged += new System.EventHandler(this.workerIDComboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(174, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 20);
            this.nameTextBox.TabIndex = 29;
            // 
            // addressCustomerTextBox
            // 
            this.addressCustomerTextBox.Enabled = false;
            this.addressCustomerTextBox.Location = new System.Drawing.Point(175, 189);
            this.addressCustomerTextBox.Name = "addressCustomerTextBox";
            this.addressCustomerTextBox.Size = new System.Drawing.Size(202, 20);
            this.addressCustomerTextBox.TabIndex = 30;
            // 
            // sumDeliveryTextBox
            // 
            this.sumDeliveryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryInfoBindingSource, "SumDelivery", true));
            this.sumDeliveryTextBox.Enabled = false;
            this.sumDeliveryTextBox.Location = new System.Drawing.Point(174, 280);
            this.sumDeliveryTextBox.Name = "sumDeliveryTextBox";
            this.sumDeliveryTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumDeliveryTextBox.TabIndex = 31;
            // 
            // dateListBindingSource
            // 
            this.dateListBindingSource.DataSource = typeof(RestaurantFujiLibrary.DateList);
            // 
            // DeliveryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 365);
            this.Controls.Add(sumDeliveryLabel);
            this.Controls.Add(this.sumDeliveryTextBox);
            this.Controls.Add(addressCustomerLabel);
            this.Controls.Add(this.addressCustomerTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(workerIDLabel);
            this.Controls.Add(this.workerIDComboBox);
            this.Controls.Add(requestIDLabel1);
            this.Controls.Add(this.requestIDTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDComboBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(dateValueLabel);
            this.Controls.Add(this.dateValueDateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DeliveryEditForm";
            this.Text = "Оформление доставки";
            this.Load += new System.EventHandler(this.DeliveryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource deliveryInfoBindingSource;
        private System.Windows.Forms.DateTimePicker dateValueDateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.BindingSource workerListBindingSource;
        private System.Windows.Forms.BindingSource customerListBindingSource;
        private System.Windows.Forms.ComboBox customerIDComboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox requestIDTextBox;
        private System.Windows.Forms.ComboBox workerIDComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressCustomerTextBox;
        private System.Windows.Forms.TextBox sumDeliveryTextBox;
        private System.Windows.Forms.BindingSource dateListBindingSource;
    }
}