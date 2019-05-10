namespace PresentationLayer.DetailPL
{
    partial class DetailAdminWindow
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
            this.AddDetail = new System.Windows.Forms.Button();
            this.RemoveDetail = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DetailTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DetailTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDetail
            // 
            this.AddDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDetail.Location = new System.Drawing.Point(12, 317);
            this.AddDetail.Name = "AddDetail";
            this.AddDetail.Size = new System.Drawing.Size(140, 40);
            this.AddDetail.TabIndex = 0;
            this.AddDetail.Text = "Add";
            this.AddDetail.UseVisualStyleBackColor = true;
            this.AddDetail.Click += new System.EventHandler(this.AddDetail_Click);
            // 
            // RemoveDetail
            // 
            this.RemoveDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveDetail.Location = new System.Drawing.Point(328, 317);
            this.RemoveDetail.Name = "RemoveDetail";
            this.RemoveDetail.Size = new System.Drawing.Size(140, 40);
            this.RemoveDetail.TabIndex = 1;
            this.RemoveDetail.Text = "Remove";
            this.RemoveDetail.UseVisualStyleBackColor = true;
            this.RemoveDetail.Click += new System.EventHandler(this.RemoveDetail_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DetailTable
            // 
            this.DetailTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailTable.Location = new System.Drawing.Point(12, 77);
            this.DetailTable.Name = "DetailTable";
            this.DetailTable.Size = new System.Drawing.Size(456, 219);
            this.DetailTable.TabIndex = 3;
            // 
            // DetailAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.DetailTable);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RemoveDetail);
            this.Controls.Add(this.AddDetail);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "DetailAdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailAdminWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetailAdminWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DetailTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDetail;
        private System.Windows.Forms.Button RemoveDetail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DetailTable;
    }
}