namespace WindowsFormsApp9
{
    partial class Form2
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
            this.cmbb = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbb
            // 
            this.cmbb.FormattingEnabled = true;
            this.cmbb.Location = new System.Drawing.Point(23, 67);
            this.cmbb.Name = "cmbb";
            this.cmbb.Size = new System.Drawing.Size(213, 21);
            this.cmbb.TabIndex = 0;
            this.cmbb.SelectedIndexChanged += new System.EventHandler(this.cmbb_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(23, 118);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(213, 20);
            this.dtp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cmbb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbb;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}