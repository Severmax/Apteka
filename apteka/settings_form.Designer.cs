namespace apteka
{
    partial class settings_form
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
            this.userdata_textbox = new System.Windows.Forms.TextBox();
            this.meddata_textbox = new System.Windows.Forms.TextBox();
            this.admindata_textbox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.userdata_label = new System.Windows.Forms.Label();
            this.meddata_label = new System.Windows.Forms.Label();
            this.admindata_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userdata_textbox
            // 
            this.userdata_textbox.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userdata_textbox.Location = new System.Drawing.Point(528, 117);
            this.userdata_textbox.Name = "userdata_textbox";
            this.userdata_textbox.Size = new System.Drawing.Size(470, 38);
            this.userdata_textbox.TabIndex = 0;
            // 
            // meddata_textbox
            // 
            this.meddata_textbox.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meddata_textbox.Location = new System.Drawing.Point(528, 164);
            this.meddata_textbox.Name = "meddata_textbox";
            this.meddata_textbox.Size = new System.Drawing.Size(470, 38);
            this.meddata_textbox.TabIndex = 1;
            // 
            // admindata_textbox
            // 
            this.admindata_textbox.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admindata_textbox.Location = new System.Drawing.Point(528, 216);
            this.admindata_textbox.Name = "admindata_textbox";
            this.admindata_textbox.Size = new System.Drawing.Size(469, 38);
            this.admindata_textbox.TabIndex = 2;
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(121, 329);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(311, 62);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Зберегти";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(438, 329);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(311, 62);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // userdata_label
            // 
            this.userdata_label.AutoSize = true;
            this.userdata_label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userdata_label.Location = new System.Drawing.Point(116, 121);
            this.userdata_label.Name = "userdata_label";
            this.userdata_label.Size = new System.Drawing.Size(236, 29);
            this.userdata_label.TabIndex = 5;
            this.userdata_label.Text = "Дані корситувачів";
            // 
            // meddata_label
            // 
            this.meddata_label.AutoSize = true;
            this.meddata_label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meddata_label.Location = new System.Drawing.Point(116, 168);
            this.meddata_label.Name = "meddata_label";
            this.meddata_label.Size = new System.Drawing.Size(251, 29);
            this.meddata_label.TabIndex = 6;
            this.meddata_label.Text = "Дані медикаментів";
            // 
            // admindata_label
            // 
            this.admindata_label.AutoSize = true;
            this.admindata_label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admindata_label.Location = new System.Drawing.Point(116, 220);
            this.admindata_label.Name = "admindata_label";
            this.admindata_label.Size = new System.Drawing.Size(272, 29);
            this.admindata_label.TabIndex = 7;
            this.admindata_label.Text = "Дані адміністраторів";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.admindata_label);
            this.Controls.Add(this.meddata_label);
            this.Controls.Add(this.userdata_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.admindata_textbox);
            this.Controls.Add(this.meddata_textbox);
            this.Controls.Add(this.userdata_textbox);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userdata_textbox;
        private System.Windows.Forms.TextBox meddata_textbox;
        private System.Windows.Forms.TextBox admindata_textbox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label userdata_label;
        private System.Windows.Forms.Label meddata_label;
        private System.Windows.Forms.Label admindata_label;
    }
}