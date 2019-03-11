namespace Compuhter
{
    partial class ProductForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.metroButtonProductAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonProductEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonProductDelete = new MetroFramework.Controls.MetroButton();
            this.metroTileExportExcel = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileRefresh
            // 
            this.metroTileRefresh.Location = new System.Drawing.Point(370, 33);
            this.metroTileRefresh.Name = "metroTileRefresh";
            this.metroTileRefresh.Size = new System.Drawing.Size(88, 23);
            this.metroTileRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileRefresh.TabIndex = 0;
            this.metroTileRefresh.Text = "Обновить";
            this.metroTileRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefresh.Click += new System.EventHandler(this.metroTileRefresh_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(160, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Поиск:";
            // 
            // metroTextBoxSearch
            // 
            this.metroTextBoxSearch.Location = new System.Drawing.Point(231, 63);
            this.metroTextBoxSearch.Name = "metroTextBoxSearch";
            this.metroTextBoxSearch.Size = new System.Drawing.Size(227, 23);
            this.metroTextBoxSearch.TabIndex = 2;
            this.metroTextBoxSearch.TextChanged += new System.EventHandler(this.metroTextBoxSearch_TextChanged);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(23, 92);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(435, 296);
            this.dataGridViewProduct.TabIndex = 3;
            // 
            // metroButtonProductAdd
            // 
            this.metroButtonProductAdd.Location = new System.Drawing.Point(23, 394);
            this.metroButtonProductAdd.Name = "metroButtonProductAdd";
            this.metroButtonProductAdd.Size = new System.Drawing.Size(78, 33);
            this.metroButtonProductAdd.TabIndex = 4;
            this.metroButtonProductAdd.Text = "Добавить";
            this.metroButtonProductAdd.Click += new System.EventHandler(this.metroButtonProductAdd_Click);
            // 
            // metroButtonProductEdit
            // 
            this.metroButtonProductEdit.Location = new System.Drawing.Point(107, 394);
            this.metroButtonProductEdit.Name = "metroButtonProductEdit";
            this.metroButtonProductEdit.Size = new System.Drawing.Size(118, 33);
            this.metroButtonProductEdit.TabIndex = 5;
            this.metroButtonProductEdit.Text = "Редактировать";
            this.metroButtonProductEdit.Click += new System.EventHandler(this.metroButtonProductEdit_Click);
            // 
            // metroButtonProductDelete
            // 
            this.metroButtonProductDelete.Location = new System.Drawing.Point(231, 394);
            this.metroButtonProductDelete.Name = "metroButtonProductDelete";
            this.metroButtonProductDelete.Size = new System.Drawing.Size(88, 33);
            this.metroButtonProductDelete.TabIndex = 6;
            this.metroButtonProductDelete.Text = "Удалить";
            this.metroButtonProductDelete.Click += new System.EventHandler(this.metroButtonProductDelete_Click);
            // 
            // metroTileExportExcel
            // 
            this.metroTileExportExcel.Location = new System.Drawing.Point(325, 394);
            this.metroTileExportExcel.Name = "metroTileExportExcel";
            this.metroTileExportExcel.Size = new System.Drawing.Size(133, 33);
            this.metroTileExportExcel.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileExportExcel.TabIndex = 7;
            this.metroTileExportExcel.Text = "Экспорт в эксель";
            this.metroTileExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExportExcel.Click += new System.EventHandler(this.metroTileExportExcel_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.metroTileExportExcel);
            this.Controls.Add(this.metroButtonProductDelete);
            this.Controls.Add(this.metroButtonProductEdit);
            this.Controls.Add(this.metroButtonProductAdd);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.metroTextBoxSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTileRefresh);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 450);
            this.MinimumSize = new System.Drawing.Size(481, 450);
            this.Name = "ProductForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private MetroFramework.Controls.MetroButton metroButtonProductAdd;
        private MetroFramework.Controls.MetroButton metroButtonProductEdit;
        private MetroFramework.Controls.MetroButton metroButtonProductDelete;
        private MetroFramework.Controls.MetroTile metroTileExportExcel;
    }
}