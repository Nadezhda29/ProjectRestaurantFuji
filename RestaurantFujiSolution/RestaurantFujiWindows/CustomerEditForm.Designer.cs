namespace RestaurantFujiWindows
{
    partial class CustomerEditForm
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
            System.Windows.Forms.Label nameCustomerLabel;
            System.Windows.Forms.Label addressCustomerLabel;
            System.Windows.Forms.Label phoneLabel;
            this.customerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameCustomerTextBox = new System.Windows.Forms.TextBox();
            this.addressCustomerTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameCustomerLabel = new System.Windows.Forms.Label();
            addressCustomerLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameCustomerLabel
            // 
            nameCustomerLabel.AutoSize = true;
            nameCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameCustomerLabel.Location = new System.Drawing.Point(28, 58);
            nameCustomerLabel.Name = "nameCustomerLabel";
            nameCustomerLabel.Size = new System.Drawing.Size(32, 13);
            nameCustomerLabel.TabIndex = 1;
            nameCustomerLabel.Text = "Имя";
            // 
            // addressCustomerLabel
            // 
            addressCustomerLabel.AutoSize = true;
            addressCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressCustomerLabel.Location = new System.Drawing.Point(28, 106);
            addressCustomerLabel.Name = "addressCustomerLabel";
            addressCustomerLabel.Size = new System.Drawing.Size(43, 13);
            addressCustomerLabel.TabIndex = 2;
            addressCustomerLabel.Text = "Адрес";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(28, 164);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 13);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Телефон";
            // 
            // customerInfoBindingSource
            // 
            this.customerInfoBindingSource.DataSource = typeof(RestaurantFujiLibrary.CustomerInfo);
            // 
            // nameCustomerTextBox
            // 
            this.nameCustomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerInfoBindingSource, "NameCustomer", true));
            this.nameCustomerTextBox.Location = new System.Drawing.Point(128, 55);
            this.nameCustomerTextBox.Name = "nameCustomerTextBox";
            this.nameCustomerTextBox.Size = new System.Drawing.Size(201, 20);
            this.nameCustomerTextBox.TabIndex = 2;
            // 
            // addressCustomerTextBox
            // 
            this.addressCustomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerInfoBindingSource, "AddressCustomer", true));
            this.addressCustomerTextBox.Location = new System.Drawing.Point(128, 106);
            this.addressCustomerTextBox.Name = "addressCustomerTextBox";
            this.addressCustomerTextBox.Size = new System.Drawing.Size(201, 20);
            this.addressCustomerTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerInfoBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(128, 164);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(201, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(101, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(261, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(addressCustomerLabel);
            this.Controls.Add(this.addressCustomerTextBox);
            this.Controls.Add(nameCustomerLabel);
            this.Controls.Add(this.nameCustomerTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CustomerEditForm";
            this.Text = "Новый клиент";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerInfoBindingSource;
        private System.Windows.Forms.TextBox nameCustomerTextBox;
        private System.Windows.Forms.TextBox addressCustomerTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}