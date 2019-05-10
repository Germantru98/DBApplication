namespace PresentationLayer.AdminReports
{
    partial class PeriodReportForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ContractTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBegin = new System.Windows.Forms.DateTimePicker();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(340, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ContractTable
            // 
            this.ContractTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContractTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractTable.Location = new System.Drawing.Point(12, 49);
            this.ContractTable.Name = "ContractTable";
            this.ContractTable.Size = new System.Drawing.Size(760, 225);
            this.ContractTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отчет по контрактам за выбранный период:";
            // 
            // DateBegin
            // 
            this.DateBegin.Location = new System.Drawing.Point(16, 308);
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.Size = new System.Drawing.Size(200, 20);
            this.DateBegin.TabIndex = 3;
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(16, 383);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(200, 20);
            this.DateEnd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Начало:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Конец:";
            // 
            // PeriodReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContractTable);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PeriodReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PeriodReportForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PeriodReportForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ContractTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ContractTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateBegin;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}