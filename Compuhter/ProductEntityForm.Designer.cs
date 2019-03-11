namespace Compuhter
{
    partial class ProductEntityForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxManufacturer = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCost = new MetroFramework.Controls.MetroTextBox();
            this.metroTileProductAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileProductEdit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Производитель:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(68, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Название:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(103, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Цена:";
            // 
            // metroTextBoxManufacturer
            // 
            this.metroTextBoxManufacturer.Location = new System.Drawing.Point(166, 63);
            this.metroTextBoxManufacturer.Name = "metroTextBoxManufacturer";
            this.metroTextBoxManufacturer.Size = new System.Drawing.Size(170, 23);
            this.metroTextBoxManufacturer.TabIndex = 3;
            // 
            // metroTextBoxName
            // 
            this.metroTextBoxName.Location = new System.Drawing.Point(166, 92);
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.Size = new System.Drawing.Size(170, 23);
            this.metroTextBoxName.TabIndex = 4;
            // 
            // metroTextBoxCost
            // 
            this.metroTextBoxCost.Location = new System.Drawing.Point(166, 121);
            this.metroTextBoxCost.Name = "metroTextBoxCost";
            this.metroTextBoxCost.Size = new System.Drawing.Size(170, 23);
            this.metroTextBoxCost.TabIndex = 5;
            this.metroTextBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxCost_KeyPress);
            // 
            // metroTileProductAdd
            // 
            this.metroTileProductAdd.Location = new System.Drawing.Point(148, 174);
            this.metroTileProductAdd.Name = "metroTileProductAdd";
            this.metroTileProductAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileProductAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileProductAdd.TabIndex = 6;
            this.metroTileProductAdd.Text = "Добавить";
            this.metroTileProductAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileProductAdd.Visible = false;
            this.metroTileProductAdd.Click += new System.EventHandler(this.metroTileProductAdd_Click);
            // 
            // metroTileProductEdit
            // 
            this.metroTileProductEdit.Location = new System.Drawing.Point(130, 174);
            this.metroTileProductEdit.Name = "metroTileProductEdit";
            this.metroTileProductEdit.Size = new System.Drawing.Size(116, 23);
            this.metroTileProductEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileProductEdit.TabIndex = 7;
            this.metroTileProductEdit.Text = "Редактировать";
            this.metroTileProductEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileProductEdit.Visible = false;
            this.metroTileProductEdit.Click += new System.EventHandler(this.metroTileProductEdit_Click);
            // 
            // ProductEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 218);
            this.Controls.Add(this.metroTileProductEdit);
            this.Controls.Add(this.metroTileProductAdd);
            this.Controls.Add(this.metroTextBoxCost);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroTextBoxManufacturer);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 218);
            this.MinimumSize = new System.Drawing.Size(368, 218);
            this.Name = "ProductEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ProductEntityForm";
            this.Load += new System.EventHandler(this.ProductEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxManufacturer;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCost;
        private MetroFramework.Controls.MetroTile metroTileProductAdd;
        private MetroFramework.Controls.MetroTile metroTileProductEdit;
    }
}