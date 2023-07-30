namespace apteka
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
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logintext
            // 
            this.logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintext.Location = new System.Drawing.Point(332, 190);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(425, 31);
            this.logintext.TabIndex = 0;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(332, 256);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(425, 31);
            this.password.TabIndex = 1;
            // 
            // loginlabel
            // 
            this.loginlabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.Location = new System.Drawing.Point(503, 153);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(101, 34);
            this.loginlabel.TabIndex = 2;
            this.loginlabel.Text = "ЛОГІН";
            this.loginlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(332, 293);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(425, 44);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "УВІЙТИ";
            this.loginbutton.UseVisualStyleBackColor = true;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(488, 224);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(116, 29);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "ПАРОЛЬ";
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(332, 343);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(425, 44);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "НАЗАД";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.logintext);
            this.Name = "login";
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
        private System.Windows.Forms.Button back_button;
    }
}