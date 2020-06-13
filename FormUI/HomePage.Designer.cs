namespace FormUI
{
    partial class HomePage
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
            this.homepageFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.homepageLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.homepageConfirmButton = new System.Windows.Forms.Button();
            this.homepageRegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homepageFirstNameTextBox
            // 
            this.homepageFirstNameTextBox.Location = new System.Drawing.Point(179, 135);
            this.homepageFirstNameTextBox.Name = "homepageFirstNameTextBox";
            this.homepageFirstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.homepageFirstNameTextBox.TabIndex = 0;
            // 
            // homepageLastNameTextBox
            // 
            this.homepageLastNameTextBox.Location = new System.Drawing.Point(179, 201);
            this.homepageLastNameTextBox.Name = "homepageLastNameTextBox";
            this.homepageLastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.homepageLastNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your First Name and Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Welcome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "If you are a new user, register below";
            // 
            // homepageConfirmButton
            // 
            this.homepageConfirmButton.Location = new System.Drawing.Point(105, 269);
            this.homepageConfirmButton.Name = "homepageConfirmButton";
            this.homepageConfirmButton.Size = new System.Drawing.Size(75, 31);
            this.homepageConfirmButton.TabIndex = 7;
            this.homepageConfirmButton.Text = "Confirm";
            this.homepageConfirmButton.UseVisualStyleBackColor = true;
            this.homepageConfirmButton.Click += new System.EventHandler(this.homepageConfirmButton_Click);
            // 
            // homepageRegisterButton
            // 
            this.homepageRegisterButton.Location = new System.Drawing.Point(438, 246);
            this.homepageRegisterButton.Name = "homepageRegisterButton";
            this.homepageRegisterButton.Size = new System.Drawing.Size(75, 32);
            this.homepageRegisterButton.TabIndex = 8;
            this.homepageRegisterButton.Text = "Register";
            this.homepageRegisterButton.UseVisualStyleBackColor = true;
            this.homepageRegisterButton.Click += new System.EventHandler(this.homepageRegisterButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homepageRegisterButton);
            this.Controls.Add(this.homepageConfirmButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homepageLastNameTextBox);
            this.Controls.Add(this.homepageFirstNameTextBox);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homepageFirstNameTextBox;
        private System.Windows.Forms.TextBox homepageLastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button homepageConfirmButton;
        private System.Windows.Forms.Button homepageRegisterButton;
    }
}