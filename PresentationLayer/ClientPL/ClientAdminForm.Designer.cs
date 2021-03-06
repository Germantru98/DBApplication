﻿namespace PresentationLayer.ClientPL
{
    partial class ClientAdminForm
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
            this.ClientTable = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repairStationDataSet = new PresentationLayer.RepairStationDataSet();
            this.AddClient = new System.Windows.Forms.Button();
            this.RemoveClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientTableAdapter = new PresentationLayer.RepairStationDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientTable
            // 
            this.ClientTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientTable.Location = new System.Drawing.Point(12, 77);
            this.ClientTable.Name = "ClientTable";
            this.ClientTable.Size = new System.Drawing.Size(560, 209);
            this.ClientTable.TabIndex = 4;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.repairStationDataSet;
            // 
            // repairStationDataSet
            // 
            this.repairStationDataSet.DataSetName = "RepairStationDataSet";
            this.repairStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddClient
            // 
            this.AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddClient.Location = new System.Drawing.Point(12, 320);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(139, 40);
            this.AddClient.TabIndex = 5;
            this.AddClient.Text = "Add";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // RemoveClient
            // 
            this.RemoveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveClient.Location = new System.Drawing.Point(433, 320);
            this.RemoveClient.Name = "RemoveClient";
            this.RemoveClient.Size = new System.Drawing.Size(139, 40);
            this.RemoveClient.TabIndex = 6;
            this.RemoveClient.Text = "Remove";
            this.RemoveClient.UseVisualStyleBackColor = true;
            this.RemoveClient.Click += new System.EventHandler(this.RemoveClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ClientAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.ClientTable);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ClientAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientAdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientAdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ClientTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairStationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientTable;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button RemoveClient;
        private System.Windows.Forms.Button button1;
        private RepairStationDataSet repairStationDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private RepairStationDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}