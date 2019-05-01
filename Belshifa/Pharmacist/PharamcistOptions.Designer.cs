namespace Belshifa
{
    partial class PharamcistOptions
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
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddtoCartButton.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoCartButton.Location = new System.Drawing.Point(141, 216);
            this.AddtoCartButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(151, 43);
            this.AddtoCartButton.TabIndex = 10;
            this.AddtoCartButton.Text = "Insert";
            this.AddtoCartButton.UseVisualStyleBackColor = true;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PharamcistOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(433, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddtoCartButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PharamcistOptions";
            this.Text = "PharamcistOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.Button button1;
    }
}