namespace Belshifa
{
    partial class Start
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
            this.LoginFormButton = new System.Windows.Forms.Button();
            this.SignupFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Patient = new System.Windows.Forms.RadioButton();
            this.Pharmacist = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginFormButton
            // 
            this.LoginFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginFormButton.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormButton.Location = new System.Drawing.Point(342, 274);
            this.LoginFormButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginFormButton.Name = "LoginFormButton";
            this.LoginFormButton.Size = new System.Drawing.Size(170, 68);
            this.LoginFormButton.TabIndex = 0;
            this.LoginFormButton.Text = "Login";
            this.LoginFormButton.UseVisualStyleBackColor = true;
            this.LoginFormButton.Click += new System.EventHandler(this.LoginFormButton_Click);
            // 
            // SignupFormButton
            // 
            this.SignupFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupFormButton.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupFormButton.Location = new System.Drawing.Point(342, 349);
            this.SignupFormButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignupFormButton.Name = "SignupFormButton";
            this.SignupFormButton.Size = new System.Drawing.Size(170, 68);
            this.SignupFormButton.TabIndex = 1;
            this.SignupFormButton.Text = "Sign up";
            this.SignupFormButton.UseVisualStyleBackColor = true;
            this.SignupFormButton.Click += new System.EventHandler(this.SignupFormButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to belshefa application";
            // 
            // Patient
            // 
            this.Patient.AutoSize = true;
            this.Patient.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient.Location = new System.Drawing.Point(79, 26);
            this.Patient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(117, 26);
            this.Patient.TabIndex = 3;
            this.Patient.TabStop = true;
            this.Patient.Text = "Patient";
            this.Patient.UseVisualStyleBackColor = true;
            // 
            // Pharmacist
            // 
            this.Pharmacist.AutoSize = true;
            this.Pharmacist.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pharmacist.Location = new System.Drawing.Point(250, 26);
            this.Pharmacist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pharmacist.Name = "Pharmacist";
            this.Pharmacist.Size = new System.Drawing.Size(163, 26);
            this.Pharmacist.TabIndex = 4;
            this.Pharmacist.TabStop = true;
            this.Pharmacist.Text = "Pharmacist";
            this.Pharmacist.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Patient);
            this.groupBox1.Controls.Add(this.Pharmacist);
            this.groupBox1.Location = new System.Drawing.Point(194, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(442, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(835, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignupFormButton);
            this.Controls.Add(this.LoginFormButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginFormButton;
        private System.Windows.Forms.Button SignupFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Patient;
        private System.Windows.Forms.RadioButton Pharmacist;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}