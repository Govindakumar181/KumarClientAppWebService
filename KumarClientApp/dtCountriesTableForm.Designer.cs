namespace KumarClientApp
{
    partial class dtCountriesTableForm
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
            this.dataGridViewdtCountries = new System.Windows.Forms.DataGridView();
            this.lblUserTable = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdtCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewdtCountries
            // 
            this.dataGridViewdtCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdtCountries.Location = new System.Drawing.Point(58, 148);
            this.dataGridViewdtCountries.Name = "dataGridViewdtCountries";
            this.dataGridViewdtCountries.RowTemplate.Height = 28;
            this.dataGridViewdtCountries.Size = new System.Drawing.Size(442, 429);
            this.dataGridViewdtCountries.TabIndex = 0;
            // 
            // lblUserTable
            // 
            this.lblUserTable.AutoSize = true;
            this.lblUserTable.Location = new System.Drawing.Point(296, 55);
            this.lblUserTable.Name = "lblUserTable";
            this.lblUserTable.Size = new System.Drawing.Size(195, 20);
            this.lblUserTable.TabIndex = 4;
            this.lblUserTable.TabStop = true;
            this.lblUserTable.Text = "Go to DataGrid UserTable";
            this.lblUserTable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUserTable_LinkClicked);
            // 
            // dtCountriesTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 619);
            this.Controls.Add(this.lblUserTable);
            this.Controls.Add(this.dataGridViewdtCountries);
            this.Name = "dtCountriesTableForm";
            this.Text = "dtCountries";
            this.Load += new System.EventHandler(this.dtCountriesTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdtCountries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdtCountries;
        private System.Windows.Forms.LinkLabel lblUserTable;
    }
}

