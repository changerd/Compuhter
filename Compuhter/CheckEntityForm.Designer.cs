namespace Compuhter
{
    partial class CheckEntityForm
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
            this.metroComboBoxClient = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxEmployee = new MetroFramework.Controls.MetroComboBox();
            this.metroTileCheckAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileCheckEdit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Клиент:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Сотрудник:";
            // 
            // metroComboBoxClient
            // 
            this.metroComboBoxClient.FormattingEnabled = true;
            this.metroComboBoxClient.ItemHeight = 23;
            this.metroComboBoxClient.Location = new System.Drawing.Point(128, 56);
            this.metroComboBoxClient.Name = "metroComboBoxClient";
            this.metroComboBoxClient.Size = new System.Drawing.Size(184, 29);
            this.metroComboBoxClient.TabIndex = 2;
            // 
            // metroComboBoxEmployee
            // 
            this.metroComboBoxEmployee.FormattingEnabled = true;
            this.metroComboBoxEmployee.ItemHeight = 23;
            this.metroComboBoxEmployee.Location = new System.Drawing.Point(128, 98);
            this.metroComboBoxEmployee.Name = "metroComboBoxEmployee";
            this.metroComboBoxEmployee.Size = new System.Drawing.Size(184, 29);
            this.metroComboBoxEmployee.TabIndex = 3;
            // 
            // metroTileCheckAdd
            // 
            this.metroTileCheckAdd.Location = new System.Drawing.Point(137, 152);
            this.metroTileCheckAdd.Name = "metroTileCheckAdd";
            this.metroTileCheckAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileCheckAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileCheckAdd.TabIndex = 4;
            this.metroTileCheckAdd.Text = "Добавить";
            this.metroTileCheckAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCheckAdd.Visible = false;
            this.metroTileCheckAdd.Click += new System.EventHandler(this.metroTileCheckAdd_Click);
            // 
            // metroTileCheckEdit
            // 
            this.metroTileCheckEdit.Location = new System.Drawing.Point(115, 152);
            this.metroTileCheckEdit.Name = "metroTileCheckEdit";
            this.metroTileCheckEdit.Size = new System.Drawing.Size(121, 23);
            this.metroTileCheckEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileCheckEdit.TabIndex = 5;
            this.metroTileCheckEdit.Text = "Редактировать";
            this.metroTileCheckEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCheckEdit.Visible = false;
            this.metroTileCheckEdit.Click += new System.EventHandler(this.metroTileEditCheck_Click);
            // 
            // CheckEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 199);
            this.Controls.Add(this.metroTileCheckEdit);
            this.Controls.Add(this.metroTileCheckAdd);
            this.Controls.Add(this.metroComboBoxEmployee);
            this.Controls.Add(this.metroComboBoxClient);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CheckEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "CheckEntityForm";
            this.Load += new System.EventHandler(this.CheckEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxClient;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEmployee;
        private MetroFramework.Controls.MetroTile metroTileCheckAdd;
        private MetroFramework.Controls.MetroTile metroTileCheckEdit;
    }
}