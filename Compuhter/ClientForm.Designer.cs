namespace Compuhter
{
    partial class ClientForm
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
            this.metroTileRefresh = new MetroFramework.Controls.MetroTile();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.metroButtonClientAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonClientEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonClientDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileRefresh
            // 
            this.metroTileRefresh.Location = new System.Drawing.Point(373, 34);
            this.metroTileRefresh.Name = "metroTileRefresh";
            this.metroTileRefresh.Size = new System.Drawing.Size(94, 23);
            this.metroTileRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileRefresh.TabIndex = 0;
            this.metroTileRefresh.Text = "Обновить";
            this.metroTileRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefresh.Click += new System.EventHandler(this.metroTileRefresh_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(23, 63);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(444, 325);
            this.dataGridViewClient.TabIndex = 1;
            // 
            // metroButtonClientAdd
            // 
            this.metroButtonClientAdd.Location = new System.Drawing.Point(23, 394);
            this.metroButtonClientAdd.Name = "metroButtonClientAdd";
            this.metroButtonClientAdd.Size = new System.Drawing.Size(145, 33);
            this.metroButtonClientAdd.TabIndex = 2;
            this.metroButtonClientAdd.Text = "Добавить";
            this.metroButtonClientAdd.Click += new System.EventHandler(this.metroButtonClientAdd_Click);
            // 
            // metroButtonClientEdit
            // 
            this.metroButtonClientEdit.Location = new System.Drawing.Point(174, 394);
            this.metroButtonClientEdit.Name = "metroButtonClientEdit";
            this.metroButtonClientEdit.Size = new System.Drawing.Size(135, 33);
            this.metroButtonClientEdit.TabIndex = 3;
            this.metroButtonClientEdit.Text = "Редактировать";
            this.metroButtonClientEdit.Click += new System.EventHandler(this.metroButtonClientEdit_Click);
            // 
            // metroButtonClientDelete
            // 
            this.metroButtonClientDelete.Location = new System.Drawing.Point(315, 394);
            this.metroButtonClientDelete.Name = "metroButtonClientDelete";
            this.metroButtonClientDelete.Size = new System.Drawing.Size(145, 33);
            this.metroButtonClientDelete.TabIndex = 4;
            this.metroButtonClientDelete.Text = "Удалить";
            this.metroButtonClientDelete.Click += new System.EventHandler(this.metroButtonClientDelete_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.metroButtonClientDelete);
            this.Controls.Add(this.metroButtonClientEdit);
            this.Controls.Add(this.metroButtonClientAdd);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.metroTileRefresh);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 450);
            this.MinimumSize = new System.Drawing.Size(490, 450);
            this.Name = "ClientForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileRefresh;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private MetroFramework.Controls.MetroButton metroButtonClientAdd;
        private MetroFramework.Controls.MetroButton metroButtonClientEdit;
        private MetroFramework.Controls.MetroButton metroButtonClientDelete;
    }
}