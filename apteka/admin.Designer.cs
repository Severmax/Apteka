namespace apteka
{
    partial class admin_form
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
            this.list_med = new System.Windows.Forms.ListView();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_med
            // 
            this.list_med.HideSelection = false;
            this.list_med.Location = new System.Drawing.Point(234, 59);
            this.list_med.Name = "list_med";
            this.list_med.Size = new System.Drawing.Size(938, 490);
            this.list_med.TabIndex = 0;
            this.list_med.UseCompatibleStateImageBehavior = false;
            this.list_med.SelectedIndexChanged += new System.EventHandler(this.list_med_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(12, 59);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(216, 69);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Додати новий препарат";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(12, 134);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(216, 69);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "Видалити препарат";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(12, 209);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(216, 69);
            this.edit_button.TabIndex = 3;
            this.edit_button.Text = "Змінити інформацію";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.Location = new System.Drawing.Point(12, 284);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(216, 69);
            this.settings_button.TabIndex = 4;
            this.settings_button.Text = "Налаштування";
            this.settings_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(12, 359);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(216, 69);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.list_med);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_med;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button back_button;
    }
}