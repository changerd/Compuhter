namespace Compuhter
{
    partial class PositionEntityForm
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
            this.metroTextBoxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTilePositionAdd = new MetroFramework.Controls.MetroTile();
            this.metroTilePositionEdit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(182, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Название должности:";
            // 
            // metroTextBoxName
            // 
            this.metroTextBoxName.Location = new System.Drawing.Point(211, 63);
            this.metroTextBoxName.Name = "metroTextBoxName";
            this.metroTextBoxName.Size = new System.Drawing.Size(164, 23);
            this.metroTextBoxName.TabIndex = 1;
            // 
            // metroTilePositionAdd
            // 
            this.metroTilePositionAdd.Location = new System.Drawing.Point(148, 120);
            this.metroTilePositionAdd.Name = "metroTilePositionAdd";
            this.metroTilePositionAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTilePositionAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTilePositionAdd.TabIndex = 2;
            this.metroTilePositionAdd.Text = "Добавить";
            this.metroTilePositionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilePositionAdd.Visible = false;
            this.metroTilePositionAdd.Click += new System.EventHandler(this.metroTilePositionAdd_Click);
            // 
            // metroTilePositionEdit
            // 
            this.metroTilePositionEdit.Location = new System.Drawing.Point(132, 120);
            this.metroTilePositionEdit.Name = "metroTilePositionEdit";
            this.metroTilePositionEdit.Size = new System.Drawing.Size(119, 23);
            this.metroTilePositionEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTilePositionEdit.TabIndex = 3;
            this.metroTilePositionEdit.Text = "Редактировать";
            this.metroTilePositionEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilePositionEdit.Visible = false;
            this.metroTilePositionEdit.Click += new System.EventHandler(this.metroTilePositionEdit_Click);
            // 
            // PositionEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 174);
            this.Controls.Add(this.metroTilePositionEdit);
            this.Controls.Add(this.metroTilePositionAdd);
            this.Controls.Add(this.metroTextBoxName);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 174);
            this.MinimumSize = new System.Drawing.Size(392, 174);
            this.Name = "PositionEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "PositionEntityForm";
            this.Load += new System.EventHandler(this.PositionEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxName;
        private MetroFramework.Controls.MetroTile metroTilePositionAdd;
        private MetroFramework.Controls.MetroTile metroTilePositionEdit;
    }
}