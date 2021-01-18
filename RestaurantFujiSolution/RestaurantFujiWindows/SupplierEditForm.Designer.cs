namespace RestaurantFujiWindows
{
    partial class SupplierEditForm
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
            System.Windows.Forms.Label nameSupplierLabel;
            System.Windows.Forms.Label phoneLabel;
            this.nameSupplierTextBox = new System.Windows.Forms.TextBox();
            this.supplierInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nameSupplierLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameSupplierLabel
            // 
            nameSupplierLabel.AutoSize = true;
            nameSupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameSupplierLabel.Location = new System.Drawing.Point(20, 43);
            nameSupplierLabel.Name = "nameSupplierLabel";
            nameSupplierLabel.Size = new System.Drawing.Size(65, 13);
            nameSupplierLabel.TabIndex = 1;
            nameSupplierLabel.Text = "Название";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(20, 107);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 13);
            phoneLabel.TabIndex = 3;
            phoneLabel.Text = "Телефон";
            // 
            // nameSupplierTextBox
            // 
            this.nameSupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierInfoBindingSource, "NameSupplier", true));
            this.nameSupplierTextBox.Location = new System.Drawing.Point(119, 43);
            this.nameSupplierTextBox.Name = "nameSupplierTextBox";
            this.nameSupplierTextBox.Size = new System.Drawing.Size(210, 20);
            this.nameSupplierTextBox.TabIndex = 2;
            // 
            // supplierInfoBindingSource
            // 
            this.supplierInfoBindingSource.DataSource = typeof(RestaurantFujiLibrary.SupplierInfo);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierInfoBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(119, 104);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(210, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(49, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(256, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SupplierEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(nameSupplierLabel);
            this.Controls.Add(this.nameSupplierTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SupplierEditForm";
            this.Text = "Карточка поставщика";
            this.Load += new System.EventHandler(this.SupplierEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierInfoBindingSource;
        private System.Windows.Forms.TextBox nameSupplierTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}