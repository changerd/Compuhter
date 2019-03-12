namespace Compuhter
{
    partial class EmployeeEntityForm
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxPosition = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSecondName = new MetroFramework.Controls.MetroTextBox();
            this.metroTileEmployeeAdd = new MetroFramework.Controls.MetroTile();
            this.metroTileEmployeeEdit = new MetroFramework.Controls.MetroTile();
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Должность:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(38, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Фамилия:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(76, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Имя:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(36, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Отчество:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(41, 176);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 25);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Телефон:";
            // 
            // metroComboBoxPosition
            // 
            this.metroComboBoxPosition.FormattingEnabled = true;
            this.metroComboBoxPosition.ItemHeight = 23;
            this.metroComboBoxPosition.Location = new System.Drawing.Point(131, 56);
            this.metroComboBoxPosition.Name = "metroComboBoxPosition";
            this.metroComboBoxPosition.Size = new System.Drawing.Size(219, 29);
            this.metroComboBoxPosition.TabIndex = 5;
            // 
            // metroTextBoxSurname
            // 
            this.metroTextBoxSurname.Location = new System.Drawing.Point(131, 91);
            this.metroTextBoxSurname.Name = "metroTextBoxSurname";
            this.metroTextBoxSurname.Size = new System.Drawing.Size(219, 23);
            this.metroTextBoxSurname.TabIndex = 6;
            // 
            // metroTextBoxFirstName
            // 
            this.metroTextBoxFirstName.Location = new System.Drawing.Point(131, 120);
            this.metroTextBoxFirstName.Name = "metroTextBoxFirstName";
            this.metroTextBoxFirstName.Size = new System.Drawing.Size(219, 23);
            this.metroTextBoxFirstName.TabIndex = 7;
            // 
            // metroTextBoxSecondName
            // 
            this.metroTextBoxSecondName.Location = new System.Drawing.Point(131, 149);
            this.metroTextBoxSecondName.Name = "metroTextBoxSecondName";
            this.metroTextBoxSecondName.Size = new System.Drawing.Size(219, 23);
            this.metroTextBoxSecondName.TabIndex = 8;
            // 
            // metroTileEmployeeAdd
            // 
            this.metroTileEmployeeAdd.Location = new System.Drawing.Point(147, 214);
            this.metroTileEmployeeAdd.Name = "metroTileEmployeeAdd";
            this.metroTileEmployeeAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileEmployeeAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileEmployeeAdd.TabIndex = 10;
            this.metroTileEmployeeAdd.Text = "Добавить";
            this.metroTileEmployeeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEmployeeAdd.Visible = false;
            this.metroTileEmployeeAdd.Click += new System.EventHandler(this.metroTilePositionAdd_Click);
            // 
            // metroTileEmployeeEdit
            // 
            this.metroTileEmployeeEdit.Location = new System.Drawing.Point(134, 214);
            this.metroTileEmployeeEdit.Name = "metroTileEmployeeEdit";
            this.metroTileEmployeeEdit.Size = new System.Drawing.Size(112, 23);
            this.metroTileEmployeeEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileEmployeeEdit.TabIndex = 11;
            this.metroTileEmployeeEdit.Text = "Редактировать";
            this.metroTileEmployeeEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEmployeeEdit.Visible = false;
            this.metroTileEmployeeEdit.Click += new System.EventHandler(this.metroTilePositionEdit_Click);
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(131, 181);
            this.maskedTextBoxTelephone.Mask = "+375-##-###-##-##";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(219, 20);
            this.maskedTextBoxTelephone.TabIndex = 12;
            // 
            // EmployeeEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 260);
            this.Controls.Add(this.maskedTextBoxTelephone);
            this.Controls.Add(this.metroTileEmployeeEdit);
            this.Controls.Add(this.metroTileEmployeeAdd);
            this.Controls.Add(this.metroTextBoxSecondName);
            this.Controls.Add(this.metroTextBoxFirstName);
            this.Controls.Add(this.metroTextBoxSurname);
            this.Controls.Add(this.metroComboBoxPosition);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(373, 260);
            this.MinimumSize = new System.Drawing.Size(373, 260);
            this.Name = "EmployeeEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "EmployeeEntityForm";
            this.Load += new System.EventHandler(this.EmployeeEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox metroComboBoxPosition;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSurname;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFirstName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSecondName;
        private MetroFramework.Controls.MetroTile metroTileEmployeeAdd;
        private MetroFramework.Controls.MetroTile metroTileEmployeeEdit;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
    }
}