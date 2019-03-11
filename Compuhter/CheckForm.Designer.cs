namespace Compuhter
{
    partial class CheckForm
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
            this.dataGridViewCheck = new System.Windows.Forms.DataGridView();
            this.dataGridViewProductCheck = new System.Windows.Forms.DataGridView();
            this.metroButtonCheckAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonCheckEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonCheckDelete = new MetroFramework.Controls.MetroButton();
            this.metroButtonProductCheckAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonProductCheckEdit = new MetroFramework.Controls.MetroButton();
            this.metroButtonProductCheckDelete = new MetroFramework.Controls.MetroButton();
            this.metroTileRefresh = new MetroFramework.Controls.MetroTile();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSecond = new System.Windows.Forms.DateTimePicker();
            this.metroTileFilter = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroCheckBoxDate = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductCheck)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCheck
            // 
            this.dataGridViewCheck.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheck.Location = new System.Drawing.Point(23, 63);
            this.dataGridViewCheck.Name = "dataGridViewCheck";
            this.dataGridViewCheck.Size = new System.Drawing.Size(559, 325);
            this.dataGridViewCheck.TabIndex = 0;
            this.dataGridViewCheck.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheck_CellClick);
            // 
            // dataGridViewProductCheck
            // 
            this.dataGridViewProductCheck.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductCheck.Location = new System.Drawing.Point(588, 63);
            this.dataGridViewProductCheck.Name = "dataGridViewProductCheck";
            this.dataGridViewProductCheck.Size = new System.Drawing.Size(564, 325);
            this.dataGridViewProductCheck.TabIndex = 1;
            // 
            // metroButtonCheckAdd
            // 
            this.metroButtonCheckAdd.Location = new System.Drawing.Point(23, 394);
            this.metroButtonCheckAdd.Name = "metroButtonCheckAdd";
            this.metroButtonCheckAdd.Size = new System.Drawing.Size(187, 33);
            this.metroButtonCheckAdd.TabIndex = 2;
            this.metroButtonCheckAdd.Text = "Добавить";
            this.metroButtonCheckAdd.Click += new System.EventHandler(this.metroButtonCheckAdd_Click);
            // 
            // metroButtonCheckEdit
            // 
            this.metroButtonCheckEdit.Location = new System.Drawing.Point(216, 395);
            this.metroButtonCheckEdit.Name = "metroButtonCheckEdit";
            this.metroButtonCheckEdit.Size = new System.Drawing.Size(170, 33);
            this.metroButtonCheckEdit.TabIndex = 3;
            this.metroButtonCheckEdit.Text = "Редактировать";
            this.metroButtonCheckEdit.Click += new System.EventHandler(this.metroButtonCheckEdit_Click);
            // 
            // metroButtonCheckDelete
            // 
            this.metroButtonCheckDelete.Location = new System.Drawing.Point(392, 394);
            this.metroButtonCheckDelete.Name = "metroButtonCheckDelete";
            this.metroButtonCheckDelete.Size = new System.Drawing.Size(190, 33);
            this.metroButtonCheckDelete.TabIndex = 4;
            this.metroButtonCheckDelete.Text = "Удалить";
            this.metroButtonCheckDelete.Click += new System.EventHandler(this.metroButtonCheckDelete_Click);
            // 
            // metroButtonProductCheckAdd
            // 
            this.metroButtonProductCheckAdd.Location = new System.Drawing.Point(588, 394);
            this.metroButtonProductCheckAdd.Name = "metroButtonProductCheckAdd";
            this.metroButtonProductCheckAdd.Size = new System.Drawing.Size(172, 32);
            this.metroButtonProductCheckAdd.TabIndex = 5;
            this.metroButtonProductCheckAdd.Text = "Добавить";
            this.metroButtonProductCheckAdd.Click += new System.EventHandler(this.metroButtonProductCheckAdd_Click);
            // 
            // metroButtonProductCheckEdit
            // 
            this.metroButtonProductCheckEdit.Location = new System.Drawing.Point(766, 395);
            this.metroButtonProductCheckEdit.Name = "metroButtonProductCheckEdit";
            this.metroButtonProductCheckEdit.Size = new System.Drawing.Size(203, 33);
            this.metroButtonProductCheckEdit.TabIndex = 6;
            this.metroButtonProductCheckEdit.Text = "Редактировать";
            this.metroButtonProductCheckEdit.Click += new System.EventHandler(this.metroButtonProductCheckEdit_Click);
            // 
            // metroButtonProductCheckDelete
            // 
            this.metroButtonProductCheckDelete.Location = new System.Drawing.Point(975, 394);
            this.metroButtonProductCheckDelete.Name = "metroButtonProductCheckDelete";
            this.metroButtonProductCheckDelete.Size = new System.Drawing.Size(177, 32);
            this.metroButtonProductCheckDelete.TabIndex = 7;
            this.metroButtonProductCheckDelete.Text = "Удалить";
            this.metroButtonProductCheckDelete.Click += new System.EventHandler(this.metroButtonProductCheckDelete_Click);
            // 
            // metroTileRefresh
            // 
            this.metroTileRefresh.ForeColor = System.Drawing.Color.Black;
            this.metroTileRefresh.Location = new System.Drawing.Point(1061, 27);
            this.metroTileRefresh.Name = "metroTileRefresh";
            this.metroTileRefresh.Size = new System.Drawing.Size(91, 23);
            this.metroTileRefresh.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileRefresh.TabIndex = 8;
            this.metroTileRefresh.Text = "Обновить";
            this.metroTileRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRefresh.Click += new System.EventHandler(this.metroTileRefresh_Click);
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFirst.Location = new System.Drawing.Point(47, 15);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerFirst.TabIndex = 9;
            // 
            // dateTimePickerSecond
            // 
            this.dateTimePickerSecond.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSecond.Location = new System.Drawing.Point(47, 41);
            this.dateTimePickerSecond.Name = "dateTimePickerSecond";
            this.dateTimePickerSecond.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerSecond.TabIndex = 10;
            // 
            // metroTileFilter
            // 
            this.metroTileFilter.Location = new System.Drawing.Point(1202, 153);
            this.metroTileFilter.Name = "metroTileFilter";
            this.metroTileFilter.Size = new System.Drawing.Size(75, 23);
            this.metroTileFilter.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileFilter.TabIndex = 11;
            this.metroTileFilter.Text = "Фильтр";
            this.metroTileFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFilter.Click += new System.EventHandler(this.metroTileFilter_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(14, 34);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(129, 44);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 12;
            this.metroTile2.Text = "Экспорт в Excel";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(1167, 301);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(153, 61);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile3.TabIndex = 13;
            this.metroTile3.Text = "Экспорт чека в Word";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(14, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 25);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "С:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(3, 36);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "По:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.dateTimePickerFirst);
            this.metroPanel1.Controls.Add(this.dateTimePickerSecond);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1167, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(153, 75);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroCheckBoxDate);
            this.metroPanel2.Controls.Add(this.metroTile2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(1167, 192);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(153, 90);
            this.metroPanel2.TabIndex = 17;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroCheckBoxDate
            // 
            this.metroCheckBoxDate.AutoSize = true;
            this.metroCheckBoxDate.Location = new System.Drawing.Point(14, 13);
            this.metroCheckBoxDate.Name = "metroCheckBoxDate";
            this.metroCheckBoxDate.Size = new System.Drawing.Size(65, 15);
            this.metroCheckBoxDate.TabIndex = 2;
            this.metroCheckBoxDate.Text = "По дате";
            this.metroCheckBoxDate.UseVisualStyleBackColor = true;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 452);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTileFilter);
            this.Controls.Add(this.metroTileRefresh);
            this.Controls.Add(this.metroButtonProductCheckDelete);
            this.Controls.Add(this.metroButtonProductCheckEdit);
            this.Controls.Add(this.metroButtonProductCheckAdd);
            this.Controls.Add(this.metroButtonCheckDelete);
            this.Controls.Add(this.metroButtonCheckEdit);
            this.Controls.Add(this.metroButtonCheckAdd);
            this.Controls.Add(this.dataGridViewProductCheck);
            this.Controls.Add(this.dataGridViewCheck);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1333, 452);
            this.MinimumSize = new System.Drawing.Size(1333, 452);
            this.Name = "CheckForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Чеки";
            this.Load += new System.EventHandler(this.CheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductCheck)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCheck;
        private System.Windows.Forms.DataGridView dataGridViewProductCheck;
        private MetroFramework.Controls.MetroButton metroButtonCheckAdd;
        private MetroFramework.Controls.MetroButton metroButtonCheckEdit;
        private MetroFramework.Controls.MetroButton metroButtonCheckDelete;
        private MetroFramework.Controls.MetroButton metroButtonProductCheckAdd;
        private MetroFramework.Controls.MetroButton metroButtonProductCheckEdit;
        private MetroFramework.Controls.MetroButton metroButtonProductCheckDelete;
        private MetroFramework.Controls.MetroTile metroTileRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirst;
        private System.Windows.Forms.DateTimePicker dateTimePickerSecond;
        private MetroFramework.Controls.MetroTile metroTileFilter;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDate;
    }
}