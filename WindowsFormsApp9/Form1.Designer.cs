namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.chkIsAvailable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProperties
            // 
            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Location = new System.Drawing.Point(2, 31);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.Size = new System.Drawing.Size(615, 207);
            this.dgvProperties.TabIndex = 0;
            
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnadd.Location = new System.Drawing.Point(637, 31);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(151, 75);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Добавить объект";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSchedule.Location = new System.Drawing.Point(637, 163);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(151, 75);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Запланировать просмотр";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(637, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chkIsAvailable);
            this.panel.Controls.Add(this.txtArea);
            this.panel.Controls.Add(this.txtPrice);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.txtType);
            this.panel.Controls.Add(this.txtAddress);
            this.panel.Location = new System.Drawing.Point(13, 264);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(603, 138);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(15, 90);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(159, 20);
            this.txtArea.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(15, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(15, 38);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(159, 20);
            this.txtType.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(15, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // chkIsAvailable
            // 
            this.chkIsAvailable.AutoSize = true;
            this.chkIsAvailable.Location = new System.Drawing.Point(15, 116);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Size = new System.Drawing.Size(77, 17);
            this.chkIsAvailable.TabIndex = 5;
            this.chkIsAvailable.Text = "IsAvailable";
            this.chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvProperties);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox chkIsAvailable;
    }
}

