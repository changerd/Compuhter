namespace Compuhter
{
    partial class ProductCheckEntityForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxProduct = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroTileProductCheckAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileProductCheckEdit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(66, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Товар:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Количество:";
            // 
            // metroComboBoxProduct
            // 
            this.metroComboBoxProduct.FormattingEnabled = true;
            this.metroComboBoxProduct.ItemHeight = 23;
            this.metroComboBoxProduct.Location = new System.Drawing.Point(135, 63);
            this.metroComboBoxProduct.Name = "metroComboBoxProduct";
            this.metroComboBoxProduct.Size = new System.Drawing.Size(196, 29);
            this.metroComboBoxProduct.TabIndex = 2;
            // 
            // metroTextBoxQuantity
            // 
            this.metroTextBoxQuantity.Location = new System.Drawing.Point(135, 98);
            this.metroTextBoxQuantity.Name = "metroTextBoxQuantity";
            this.metroTextBoxQuantity.Size = new System.Drawing.Size(196, 23);
            this.metroTextBoxQuantity.TabIndex = 3;
            this.metroTextBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxQuantity_KeyPress);
            // 
            // metroTileProductCheckAdd
            // 
            this.metroTileProductCheckAdd.Location = new System.Drawing.Point(145, 140);
            this.metroTileProductCheckAdd.Name = "metroTileProductCheckAdd";
            this.metroTileProductCheckAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileProductCheckAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileProductCheckAdd.TabIndex = 4;
            this.metroTileProductCheckAdd.Text = "Добавить";
            this.metroTileProductCheckAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileProductCheckAdd.Visible = false;
            this.metroTileProductCheckAdd.Click += new System.EventHandler(this.metroTileProductCheckAdd_Click);
            // 
            // metroTileProductCheckEdit
            // 
            this.metroTileProductCheckEdit.Location = new System.Drawing.Point(125, 140);
            this.metroTileProductCheckEdit.Name = "metroTileProductCheckEdit";
            this.metroTileProductCheckEdit.Size = new System.Drawing.Size(118, 23);
            this.metroTileProductCheckEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileProductCheckEdit.TabIndex = 5;
            this.metroTileProductCheckEdit.Text = "Редактировать";
            this.metroTileProductCheckEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileProductCheckEdit.Visible = false;
            this.metroTileProductCheckEdit.Click += new System.EventHandler(this.metroTileProductCheckDelete_Click);
            // 
            // ProductCheckEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 189);
            this.Controls.Add(this.metroTileProductCheckEdit);
            this.Controls.Add(this.metroTileProductCheckAdd);
            this.Controls.Add(this.metroTextBoxQuantity);
            this.Controls.Add(this.metroComboBoxProduct);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(354, 189);
            this.MinimumSize = new System.Drawing.Size(354, 189);
            this.Name = "ProductCheckEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ProductCheckEntityForm";
            this.Load += new System.EventHandler(this.ProductCheckEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxProduct;
        private MetroFramework.Controls.MetroTextBox metroTextBoxQuantity;
        private MetroFramework.Controls.MetroTile metroTileProductCheckAdd;
        private MetroFramework.Controls.MetroTile metroTileProductCheckEdit;
    }
}