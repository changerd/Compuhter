using Compuhter.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compuhter
{
    public partial class PositionEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int PositionId;
        public string pname;
        public PositionEntityForm()
        {
            InitializeComponent();
        }

        private void PositionEntityForm_Load(object sender, EventArgs e)
        {
            metroTilePositionAdd.Visible = btnAddvisible;
            metroTilePositionEdit.Visible = btnEditvisible;
            metroTextBoxName.Text = pname;
        }

        private void metroTilePositionAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxName.Text))
                    throw new Exception("Поля не должны быть пустыми");
                Position position = new Position()
                {
                    PositionName = metroTextBoxName.Text,
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Positions.Add(position);
                    context.SaveChanges();
                }
                MessageBox.Show("Запись успешно добавлена!", "Compuhter");
                this.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTilePositionEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxName.Text))
                    throw new Exception("Поля не должны быть пустыми");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var position = context.Positions.Find(PositionId);
                    position.PositionName = metroTextBoxName.Text;                    
                    context.Entry(position).State = EntityState.Modified;
                    context.SaveChanges();
                }
                MessageBox.Show("Запись успешно изменена!", "Compuhter");
                this.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
    }
}
