namespace Compuhter
{
    partial class EmployeeForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonPositionDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonPositionEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonPosotionAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridViewPosition = new System.Windows.Forms.DataGridView();
            this.metroButtonEmployeeDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonEmployeeEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonEmployeeAdd = new MetroFramework.Controls.MetroButton();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTileRefresh
            // 
            this.metroTileRefresh.Location = new System.Drawing.Point(683, 34);
            this.metroTileRefresh.Name = "metroTileRefresh";
            this.metroTileRefresh.Size = new System.Drawing.Size(94, 23);
            this.metroTileRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileRefresh.TabIndex = 0;
            this.metroTileRefresh.Text = "Обновить";
            this.metroTileRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefresh.Click += new System.EventHandler(this.metroTileRefresh_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(754, 364);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroButtonEmployeeDelete);
            this.metroTabPage1.Controls.Add(this.metroButtonEmployeeEdit);
            this.metroTabPage1.Controls.Add(this.metroButtonEmployeeAdd);
            this.metroTabPage1.Controls.Add(this.dataGridViewEmployee);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 325);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Персонал";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButtonPositionDelete);
            this.metroTabPage2.Controls.Add(this.metroButtonPositionEdit);
            this.metroTabPage2.Controls.Add(this.metroButtonPosotionAdd);
            this.metroTabPage2.Controls.Add(this.dataGridViewPosition);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 325);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Должности";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroButtonPositionDelete
            // 
            this.metroButtonPositionDelete.Location = new System.Drawing.Point(498, 289);
            this.metroButtonPositionDelete.Name = "metroButtonPositionDelete";
            this.metroButtonPositionDelete.Size = new System.Drawing.Size(248, 33);
            this.metroButtonPositionDelete.TabIndex = 5;
            this.metroButtonPositionDelete.Text = "Удалить";
            this.metroButtonPositionDelete.Click += new System.EventHandler(this.metroButtonPositionDelete_Click);
            // 
            // metroButtonPositionEdit
            // 
            this.metroButtonPositionEdit.Location = new System.Drawing.Point(254, 289);
            this.metroButtonPositionEdit.Name = "metroButtonPositionEdit";
            this.metroButtonPositionEdit.Size = new System.Drawing.Size(238, 33);
            this.metroButtonPositionEdit.TabIndex = 4;
            this.metroButtonPositionEdit.Text = "Редактировать";
            this.metroButtonPositionEdit.Click += new System.EventHandler(this.metroButtonPositionEdit_Click);
            // 
            // metroButtonPosotionAdd
            // 
            this.metroButtonPosotionAdd.Location = new System.Drawing.Point(0, 289);
            this.metroButtonPosotionAdd.Name = "metroButtonPosotionAdd";
            this.metroButtonPosotionAdd.Size = new System.Drawing.Size(248, 33);
            this.metroButtonPosotionAdd.TabIndex = 3;
            this.metroButtonPosotionAdd.Text = "Добавить";
            this.metroButtonPosotionAdd.Click += new System.EventHandler(this.metroButtonPosotionAdd_Click);
            // 
            // dataGridViewPosition
            // 
            this.dataGridViewPosition.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosition.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewPosition.Name = "dataGridViewPosition";
            this.dataGridViewPosition.Size = new System.Drawing.Size(746, 280);
            this.dataGridViewPosition.TabIndex = 2;
            // 
            // metroButtonEmployeeDelete
            // 
            this.metroButtonEmployeeDelete.Location = new System.Drawing.Point(498, 289);
            this.metroButtonEmployeeDelete.Name = "metroButtonEmployeeDelete";
            this.metroButtonEmployeeDelete.Size = new System.Drawing.Size(248, 33);
            this.metroButtonEmployeeDelete.TabIndex = 9;
            this.metroButtonEmployeeDelete.Text = "Удалить";
            this.metroButtonEmployeeDelete.Click += new System.EventHandler(this.metroButtonEmployeeDelete_Click);
            // 
            // metroButtonEmployeeEdit
            // 
            this.metroButtonEmployeeEdit.Location = new System.Drawing.Point(254, 289);
            this.metroButtonEmployeeEdit.Name = "metroButtonEmployeeEdit";
            this.metroButtonEmployeeEdit.Size = new System.Drawing.Size(238, 33);
            this.metroButtonEmployeeEdit.TabIndex = 8;
            this.metroButtonEmployeeEdit.Text = "Редактировать";
            this.metroButtonEmployeeEdit.Click += new System.EventHandler(this.metroButtonEmployeeEdit_Click);
            // 
            // metroButtonEmployeeAdd
            // 
            this.metroButtonEmployeeAdd.Location = new System.Drawing.Point(0, 289);
            this.metroButtonEmployeeAdd.Name = "metroButtonEmployeeAdd";
            this.metroButtonEmployeeAdd.Size = new System.Drawing.Size(248, 33);
            this.metroButtonEmployeeAdd.TabIndex = 7;
            this.metroButtonEmployeeAdd.Text = "Добавить";
            this.metroButtonEmployeeAdd.Click += new System.EventHandler(this.metroButtonEmployeeAdd_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(746, 280);
            this.dataGridViewEmployee.TabIndex = 6;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroTileRefresh);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "EmployeeForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileRefresh;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButtonPositionDelete;
        private MetroFramework.Controls.MetroButton metroButtonPositionEdit;
        private MetroFramework.Controls.MetroButton metroButtonPosotionAdd;
        private System.Windows.Forms.DataGridView dataGridViewPosition;
        private MetroFramework.Controls.MetroButton metroButtonEmployeeDelete;
        private MetroFramework.Controls.MetroButton metroButtonEmployeeEdit;
        private MetroFramework.Controls.MetroButton metroButtonEmployeeAdd;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
    }
}