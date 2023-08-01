namespace apteka
{
    partial class user_form
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
            this.welcome_label = new System.Windows.Forms.Label();
            this.list_med = new System.Windows.Forms.ListView();
            this.match_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(423, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(231, 29);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Привіт, Username";
            // 
            // list_med
            // 
            this.list_med.HideSelection = false;
            this.list_med.Location = new System.Drawing.Point(234, 59);
            this.list_med.Name = "list_med";
            this.list_med.Size = new System.Drawing.Size(938, 490);
            this.list_med.TabIndex = 1;
            this.list_med.UseCompatibleStateImageBehavior = false;
            // 
            // match_button
            // 
            this.match_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match_button.Location = new System.Drawing.Point(12, 59);
            this.match_button.Name = "match_button";
            this.match_button.Size = new System.Drawing.Size(216, 69);
            this.match_button.TabIndex = 2;
            this.match_button.Text = "Підібрати ліки";
            this.match_button.UseVisualStyleBackColor = true;
            this.match_button.Click += new System.EventHandler(this.match_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(12, 134);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(216, 69);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Очистити список";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(12, 209);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(216, 69);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.match_button);
            this.Controls.Add(this.list_med);
            this.Controls.Add(this.welcome_label);
            this.Name = "user_form";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.ListView list_med;
        private System.Windows.Forms.Button match_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button back_button;
    }
}