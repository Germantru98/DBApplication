namespace PresentationLayer.ContractPL
{
    partial class ContractAdminWindow
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
            this.ContractTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ContractTable
            // 
            this.ContractTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContractTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractTable.Location = new System.Drawing.Point(12, 50);
            this.ContractTable.Name = "ContractTable";
            this.ContractTable.Size = new System.Drawing.Size(780, 349);
            this.ContractTable.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(573, 416);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(215, 54);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 416);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(215, 54);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ContractAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ContractTable);
            this.MaximumSize = new System.Drawing.Size(820, 600);
            this.MinimumSize = new System.Drawing.Size(820, 600);
            this.Name = "ContractAdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractAdminWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContractAdminWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ContractTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ContractTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
    }
}