namespace apteka
{
    partial class med_form
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
            this.medname_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.RichTextBox();
            this.med_name = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.indication_textbox = new System.Windows.Forms.TextBox();
            this.indication_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // medname_textbox
            // 
            this.medname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medname_textbox.Location = new System.Drawing.Point(435, 82);
            this.medname_textbox.Name = "medname_textbox";
            this.medname_textbox.Size = new System.Drawing.Size(626, 31);
            this.medname_textbox.TabIndex = 0;
            // 
            // description_textbox
            // 
            this.description_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_textbox.Location = new System.Drawing.Point(435, 130);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(626, 253);
            this.description_textbox.TabIndex = 1;
            this.description_textbox.Text = "";
            // 
            // med_name
            // 
            this.med_name.AutoSize = true;
            this.med_name.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_name.Location = new System.Drawing.Point(181, 82);
            this.med_name.Name = "med_name";
            this.med_name.Size = new System.Drawing.Size(87, 29);
            this.med_name.TabIndex = 2;
            this.med_name.Text = "Назва";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(181, 130);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(78, 29);
            this.description_label.TabIndex = 3;
            this.description_label.Text = "Опис";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(435, 465);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(243, 55);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "ДОДАТИ";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(818, 465);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(243, 55);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "НАЗАД";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // indication_textbox
            // 
            this.indication_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indication_textbox.Location = new System.Drawing.Point(435, 405);
            this.indication_textbox.Name = "indication_textbox";
            this.indication_textbox.Size = new System.Drawing.Size(625, 31);
            this.indication_textbox.TabIndex = 7;
            // 
            // indication_label
            // 
            this.indication_label.AutoSize = true;
            this.indication_label.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indication_label.Location = new System.Drawing.Point(181, 405);
            this.indication_label.Name = "indication_label";
            this.indication_label.Size = new System.Drawing.Size(148, 29);
            this.indication_label.TabIndex = 8;
            this.indication_label.Text = "Показання";
            // 
            // med_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.indication_label);
            this.Controls.Add(this.indication_textbox);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.med_name);
            this.Controls.Add(this.description_textbox);
            this.Controls.Add(this.medname_textbox);
            this.Name = "med_form";
            this.Text = "med_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox medname_textbox;
        private System.Windows.Forms.RichTextBox description_textbox;
        private System.Windows.Forms.Label med_name;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox indication_textbox;
        private System.Windows.Forms.Label indication_label;
    }
}