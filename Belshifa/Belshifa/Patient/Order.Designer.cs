﻿namespace Belshifa
{
    partial class Order
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
            this.CategoryList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DrugComboBox = new System.Windows.Forms.ComboBox();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.QuantityDomain = new System.Windows.Forms.DomainUpDown();
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DetailsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CategoryList
            // 
            this.CategoryList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.ItemHeight = 20;
            this.CategoryList.Location = new System.Drawing.Point(14, 84);
            this.CategoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(167, 564);
            this.CategoryList.TabIndex = 0;
            this.CategoryList.SelectedIndexChanged += new System.EventHandler(this.CategoryList_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // DrugComboBox
            // 
            this.DrugComboBox.FormattingEnabled = true;
            this.DrugComboBox.Location = new System.Drawing.Point(272, 84);
            this.DrugComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrugComboBox.Name = "DrugComboBox";
            this.DrugComboBox.Size = new System.Drawing.Size(294, 28);
            this.DrugComboBox.TabIndex = 2;
            this.DrugComboBox.Visible = false;
            this.DrugComboBox.SelectedIndexChanged += new System.EventHandler(this.DrugComboBox_SelectedIndexChanged_1);
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(413, 184);
            this.PriceTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(154, 26);
            this.PriceTextbox.TabIndex = 4;
            this.PriceTextbox.Visible = false;
            // 
            // QuantityDomain
            // 
            this.QuantityDomain.Location = new System.Drawing.Point(413, 288);
            this.QuantityDomain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuantityDomain.Name = "QuantityDomain";
            this.QuantityDomain.Size = new System.Drawing.Size(154, 26);
            this.QuantityDomain.TabIndex = 7;
            this.QuantityDomain.Text = "domainUpDown1";
            this.QuantityDomain.Visible = false;
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddtoCartButton.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoCartButton.Location = new System.Drawing.Point(629, 458);
            this.AddtoCartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(226, 66);
            this.AddtoCartButton.TabIndex = 8;
            this.AddtoCartButton.Text = "Add to cart";
            this.AddtoCartButton.UseVisualStyleBackColor = true;
            this.AddtoCartButton.Visible = false;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckoutButton.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.Location = new System.Drawing.Point(629, 554);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(226, 78);
            this.CheckoutButton.TabIndex = 11;
            this.CheckoutButton.Text = "Proceed to Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            // 
            // DetailsButton
            // 
            this.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsButton.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsButton.Location = new System.Drawing.Point(272, 354);
            this.DetailsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(124, 66);
            this.DetailsButton.TabIndex = 12;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Visible = false;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Drug";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantity";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(719, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 66);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailsListBox
            // 
            this.DetailsListBox.FormattingEnabled = true;
            this.DetailsListBox.ItemHeight = 20;
            this.DetailsListBox.Location = new System.Drawing.Point(259, 451);
            this.DetailsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DetailsListBox.Name = "DetailsListBox";
            this.DetailsListBox.Size = new System.Drawing.Size(148, 144);
            this.DetailsListBox.TabIndex = 18;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(868, 664);
            this.Controls.Add(this.DetailsListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.AddtoCartButton);
            this.Controls.Add(this.QuantityDomain);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.DrugComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoryList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DrugComboBox;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.DomainUpDown QuantityDomain;
        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox DetailsListBox;
    }
}