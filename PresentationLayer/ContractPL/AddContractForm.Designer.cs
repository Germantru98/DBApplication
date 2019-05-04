namespace PresentationLayer.ContractPL
{
    partial class AddContractForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SpecialistCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CarCBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DefectTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentCBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый контракт";
            // 
            // SpecialistCBox
            // 
            this.SpecialistCBox.FormattingEnabled = true;
            this.SpecialistCBox.Location = new System.Drawing.Point(12, 85);
            this.SpecialistCBox.Name = "SpecialistCBox";
            this.SpecialistCBox.Size = new System.Drawing.Size(460, 21);
            this.SpecialistCBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специалист:";
            // 
            // CarCBox
            // 
            this.CarCBox.FormattingEnabled = true;
            this.CarCBox.Location = new System.Drawing.Point(12, 148);
            this.CarCBox.Name = "CarCBox";
            this.CarCBox.Size = new System.Drawing.Size(457, 21);
            this.CarCBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автомобиль:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(12, 206);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(212, 20);
            this.DatePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Текущая дата";
            // 
            // TimeCBox
            // 
            this.TimeCBox.FormatString = "T";
            this.TimeCBox.FormattingEnabled = true;
            this.TimeCBox.Location = new System.Drawing.Point(12, 259);
            this.TimeCBox.Name = "TimeCBox";
            this.TimeCBox.Size = new System.Drawing.Size(212, 21);
            this.TimeCBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время работ:";
            // 
            // DefectTBox
            // 
            this.DefectTBox.Location = new System.Drawing.Point(12, 313);
            this.DefectTBox.Name = "DefectTBox";
            this.DefectTBox.Size = new System.Drawing.Size(212, 20);
            this.DefectTBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Неполадки:";
            // 
            // PaymentCBox
            // 
            this.PaymentCBox.FormattingEnabled = true;
            this.PaymentCBox.Location = new System.Drawing.Point(12, 366);
            this.PaymentCBox.Name = "PaymentCBox";
            this.PaymentCBox.Size = new System.Drawing.Size(258, 21);
            this.PaymentCBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Способ оплаты:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(164, 412);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 37);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PaymentCBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DefectTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpecialistCBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "AddContractForm";
            this.Text = "AddContractForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddContractForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SpecialistCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CarCBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TimeCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DefectTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PaymentCBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddButton;
    }
}