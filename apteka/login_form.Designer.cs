﻿namespace apteka
{
    partial class login_form
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
            this.logintext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintext
            // 
            this.logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintext.Location = new System.Drawing.Point(443, 234);
            this.logintext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(565, 37);
            this.logintext.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(443, 315);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(565, 37);
            this.password.TabIndex = 1;
            // 
            // loginlabel
            // 
            this.loginlabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.Location = new System.Drawing.Point(671, 188);
            this.loginlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(135, 42);
            this.loginlabel.TabIndex = 2;
            this.loginlabel.Text = "ЛОГІН";
            this.loginlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(443, 361);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(567, 54);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "УВІЙТИ";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(651, 276);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(142, 36);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "ПАРОЛЬ";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(443, 422);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(567, 54);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "ВИХІД";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.Location = new System.Drawing.Point(443, 484);
            this.register_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(567, 54);
            this.register_button.TabIndex = 6;
            this.register_button.Text = "ЗАРЕЄСТРУВАТИСЬ";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 690);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.logintext);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login_form";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button register_button;
    }
}