namespace PresentationLayer
{
    partial class MarkAdminWindow
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
            this.components = new System.ComponentModel.Container();
            this.markLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddMark = new System.Windows.Forms.Button();
            this.RemoveMark = new System.Windows.Forms.Button();
            this.MarkTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.markLogicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkTable)).BeginInit();
            this.SuspendLayout();
            // 
            // markLogicBindingSource
            // 
            this.markLogicBindingSource.DataSource = typeof(BusinessLogic.MarkLogic);
            // 
            // AddMark
            // 
            this.AddMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMark.Location = new System.Drawing.Point(62, 304);
            this.AddMark.Name = "AddMark";
            this.AddMark.Size = new System.Drawing.Size(139, 40);
            this.AddMark.TabIndex = 1;
            this.AddMark.Text = "Add";
            this.AddMark.UseVisualStyleBackColor = true;
            this.AddMark.Click += new System.EventHandler(this.AddMark_Click);
            // 
            // RemoveMark
            // 
            this.RemoveMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveMark.Location = new System.Drawing.Point(273, 305);
            this.RemoveMark.Name = "RemoveMark";
            this.RemoveMark.Size = new System.Drawing.Size(139, 40);
            this.RemoveMark.TabIndex = 2;
            this.RemoveMark.Text = "Remove";
            this.RemoveMark.UseVisualStyleBackColor = true;
            this.RemoveMark.Click += new System.EventHandler(this.RemoveMark_Click);
            // 
            // MarkTable
            // 
            this.MarkTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MarkTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarkTable.Location = new System.Drawing.Point(62, 78);
            this.MarkTable.Name = "MarkTable";
            this.MarkTable.Size = new System.Drawing.Size(350, 183);
            this.MarkTable.TabIndex = 3;
            this.MarkTable.DataSourceChanged += new System.EventHandler(this.MarkTable_DataSourceChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MarkAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MarkTable);
            this.Controls.Add(this.RemoveMark);
            this.Controls.Add(this.AddMark);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MarkAdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkAdminWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarkAdminWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.markLogicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource markLogicBindingSource;
        private System.Windows.Forms.Button AddMark;
        private System.Windows.Forms.Button RemoveMark;
        private System.Windows.Forms.DataGridView MarkTable;
        private System.Windows.Forms.Button button1;
    }
}