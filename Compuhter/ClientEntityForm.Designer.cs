namespace Compuhter
{
    partial class ClientEntityForm
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
            this.maskedTextBoxTelephone = new System.Windows.Forms.MaskedTextBox();
            this.metroTileClientEdit = new MetroFramework.Controls.MetroTile();
            this.metroTileClientAdd = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxFirstName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // maskedTextBoxTelephone
            // 
            this.maskedTextBoxTelephone.Location = new System.Drawing.Point(116, 119);
            this.maskedTextBoxTelephone.Mask = "+375-##-###-##-##";
            this.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone";
            this.maskedTextBoxTelephone.Size = new System.Drawing.Size(188, 20);
            this.maskedTextBoxTelephone.TabIndex = 22;
            // 
            // metroTileClientEdit
            // 
            this.metroTileClientEdit.Location = new System.Drawing.Point(110, 154);
            this.metroTileClientEdit.Name = "metroTileClientEdit";
            this.metroTileClientEdit.Size = new System.Drawing.Size(112, 23);
            this.metroTileClientEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClientEdit.TabIndex = 21;
            this.metroTileClientEdit.Text = "Редактировать";
            this.metroTileClientEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClientEdit.Visible = false;
            this.metroTileClientEdit.Click += new System.EventHandler(this.metroTileClientEdit_Click);
            // 
            // metroTileClientAdd
            // 
            this.metroTileClientAdd.Location = new System.Drawing.Point(126, 154);
            this.metroTileClientAdd.Name = "metroTileClientAdd";
            this.metroTileClientAdd.Size = new System.Drawing.Size(75, 23);
            this.metroTileClientAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClientAdd.TabIndex = 20;
            this.metroTileClientAdd.Text = "Добавить";
            this.metroTileClientAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClientAdd.Visible = false;
            this.metroTileClientAdd.Click += new System.EventHandler(this.metroTileClientAdd_Click);
            // 
            // metroTextBoxFirstName
            // 
            this.metroTextBoxFirstName.Location = new System.Drawing.Point(116, 91);
            this.metroTextBoxFirstName.Name = "metroTextBoxFirstName";
            this.metroTextBoxFirstName.Size = new System.Drawing.Size(188, 23);
            this.metroTextBoxFirstName.TabIndex = 18;
            // 
            // metroTextBoxSurname
            // 
            this.metroTextBoxSurname.Location = new System.Drawing.Point(116, 62);
            this.metroTextBoxSurname.Name = "metroTextBoxSurname";
            this.metroTextBoxSurname.Size = new System.Drawing.Size(188, 23);
            this.metroTextBoxSurname.TabIndex = 17;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(26, 114);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(84, 25);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Телефон:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(61, 89);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Имя:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 25);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Фамилия:";
            // 
            // ClientEntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 200);
            this.Controls.Add(this.maskedTextBoxTelephone);
            this.Controls.Add(this.metroTileClientEdit);
            this.Controls.Add(this.metroTileClientAdd);
            this.Controls.Add(this.metroTextBoxFirstName);
            this.Controls.Add(this.metroTextBoxSurname);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 200);
            this.MinimumSize = new System.Drawing.Size(327, 200);
            this.Name = "ClientEntityForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ClientEntityForm";
            this.Load += new System.EventHandler(this.ClientEntityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelephone;
        private MetroFramework.Controls.MetroTile metroTileClientEdit;
        private MetroFramework.Controls.MetroTile metroTileClientAdd;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFirstName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSurname;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}