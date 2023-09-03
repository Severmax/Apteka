namespace apteka
{
    partial class survey_form
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
            this.qestion_label = new System.Windows.Forms.Label();
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qestion_label
            // 
            this.qestion_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qestion_label.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qestion_label.Location = new System.Drawing.Point(1, 234);
            this.qestion_label.Margin = new System.Windows.Forms.Padding(267, 123, 267, 123);
            this.qestion_label.Name = "qestion_label";
            this.qestion_label.Size = new System.Drawing.Size(1636, 36);
            this.qestion_label.TabIndex = 0;
            this.qestion_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qestion_label.UseMnemonic = false;
            this.qestion_label.Click += new System.EventHandler(this.qestion_label_Click);
            // 
            // yes_button
            // 
            this.yes_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_button.Location = new System.Drawing.Point(490, 415);
            this.yes_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(324, 68);
            this.yes_button.TabIndex = 1;
            this.yes_button.Text = "Так";
            this.yes_button.UseVisualStyleBackColor = true;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // no_button
            // 
            this.no_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_button.Location = new System.Drawing.Point(822, 415);
            this.no_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(324, 68);
            this.no_button.TabIndex = 2;
            this.no_button.Text = "Ні";
            this.no_button.UseVisualStyleBackColor = true;
            this.no_button.Click += new System.EventHandler(this.no_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(653, 490);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(324, 68);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // survey_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 690);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.qestion_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "survey_form";
            this.Text = "survey";
            this.Load += new System.EventHandler(this.survey_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label qestion_label;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
        private System.Windows.Forms.Button back_button;
    }
}