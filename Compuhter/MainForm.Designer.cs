namespace Compuhter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTileProducts = new MetroFramework.Controls.MetroTile();
            this.metroTileEmployees = new MetroFramework.Controls.MetroTile();
            this.metroTileChecks = new MetroFramework.Controls.MetroTile();
            this.metroTileClients = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileProducts
            // 
            this.metroTileProducts.Location = new System.Drawing.Point(142, 101);
            this.metroTileProducts.Name = "metroTileProducts";
            this.metroTileProducts.Size = new System.Drawing.Size(115, 40);
            this.metroTileProducts.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileProducts.TabIndex = 0;
            this.metroTileProducts.Text = "Товары";
            this.metroTileProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileProducts.Click += new System.EventHandler(this.metroTileProducts_Click);
            // 
            // metroTileEmployees
            // 
            this.metroTileEmployees.Location = new System.Drawing.Point(142, 166);
            this.metroTileEmployees.Name = "metroTileEmployees";
            this.metroTileEmployees.Size = new System.Drawing.Size(115, 40);
            this.metroTileEmployees.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileEmployees.TabIndex = 1;
            this.metroTileEmployees.Text = "Персонал";
            this.metroTileEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEmployees.Click += new System.EventHandler(this.metroTileEmployees_Click);
            // 
            // metroTileChecks
            // 
            this.metroTileChecks.Location = new System.Drawing.Point(142, 293);
            this.metroTileChecks.Name = "metroTileChecks";
            this.metroTileChecks.Size = new System.Drawing.Size(115, 40);
            this.metroTileChecks.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileChecks.TabIndex = 2;
            this.metroTileChecks.Text = "Чеки";
            this.metroTileChecks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileChecks.Click += new System.EventHandler(this.metroTileChecks_Click);
            // 
            // metroTileClients
            // 
            this.metroTileClients.Location = new System.Drawing.Point(142, 230);
            this.metroTileClients.Name = "metroTileClients";
            this.metroTileClients.Size = new System.Drawing.Size(115, 39);
            this.metroTileClients.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileClients.TabIndex = 3;
            this.metroTileClients.Text = "Клиенты";
            this.metroTileClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClients.Click += new System.EventHandler(this.metroTileClients_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.metroTileClients);
            this.Controls.Add(this.metroTileChecks);
            this.Controls.Add(this.metroTileEmployees);
            this.Controls.Add(this.metroTileProducts);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Магазин компьютерной техники";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileProducts;
        private MetroFramework.Controls.MetroTile metroTileEmployees;
        private MetroFramework.Controls.MetroTile metroTileChecks;
        private MetroFramework.Controls.MetroTile metroTileClients;
    }
}

