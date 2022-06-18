namespace KumarClientApp
{
    partial class dtUserSocialNetwork
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblDtCountries = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(612, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Location = new System.Drawing.Point(273, 115);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(75, 35);
            this.btnUserSearch.TabIndex = 1;
            this.btnUserSearch.Text = "Search";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(39, 115);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(178, 35);
            this.txtUserID.TabIndex = 2;
            // 
            // lblDtCountries
            // 
            this.lblDtCountries.AutoSize = true;
            this.lblDtCountries.Location = new System.Drawing.Point(424, 33);
            this.lblDtCountries.Name = "lblDtCountries";
            this.lblDtCountries.Size = new System.Drawing.Size(204, 20);
            this.lblDtCountries.TabIndex = 3;
            this.lblDtCountries.TabStop = true;
            this.lblDtCountries.Text = "Go to DataGrid dtCountries";
            this.lblDtCountries.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDtCountries_LinkClicked);
            // 
            // dtUserSocialNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 619);
            this.Controls.Add(this.lblDtCountries);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnUserSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dtUserSocialNetwork";
            this.Text = "dtUserSocialNetwork";
            this.Load += new System.EventHandler(this.dtUserSocialNetwork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.LinkLabel lblDtCountries;
    }
}