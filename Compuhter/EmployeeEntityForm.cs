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
    public partial class EmployeeEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int EmployeeId;
        public string esur, efname, esname, etel;

        void GetPosition()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var positions = context.Positions.ToList();
                metroComboBoxPosition.DataSource = positions;
                metroComboBoxPosition.DisplayMember = "PositionName";
                metroComboBoxPosition.ValueMember = "PositionId";
            }
        }
        public EmployeeEntityForm()
        {
            InitializeComponent();
        }

        private void EmployeeEntityForm_Load(object sender, EventArgs e)
        {
            GetPosition();
            metroTileEmployeeAdd.Visible = btnAddvisible;
            metroTileEmployeeEdit.Visible = btnEditvisible;
            metroTextBoxSurname.Text = esur;
            metroTextBoxFirstName.Text = efname;
            metroTextBoxSecondName.Text = esname;
            maskedTextBoxTelephone.Text = etel; 

        }

        private void metroTilePositionAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSurname.Text) ||
                    String.IsNullOrEmpty(metroTextBoxFirstName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSecondName.Text) ||
                    String.IsNullOrEmpty(maskedTextBoxTelephone.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Employee employee = new Employee()
                {
                    PositionId = Convert.ToInt32(metroComboBoxPosition.SelectedValue),
                    EmployeeSurName = metroTextBoxSurname.Text,
                    EmployeeFirstName = metroTextBoxFirstName.Text,
                    EmployeeSecondName = metroTextBoxSecondName.Text,
                    EmployeeTelephone = maskedTextBoxTelephone.Text,
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Employees.Add(employee);
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
                if (String.IsNullOrEmpty(metroTextBoxSurname.Text) ||
                    String.IsNullOrEmpty(metroTextBoxFirstName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxSecondName.Text) ||
                    String.IsNullOrEmpty(maskedTextBoxTelephone.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var employee = context.Employees.Find(EmployeeId);
                    employee.PositionId = Convert.ToInt32(metroComboBoxPosition.SelectedValue);
                    employee.EmployeeSurName = metroTextBoxSurname.Text;
                    employee.EmployeeFirstName = metroTextBoxFirstName.Text;
                    employee.EmployeeSecondName = metroTextBoxSecondName.Text;
                    employee.EmployeeTelephone = maskedTextBoxTelephone.Text;
                    context.Entry(employee).State = EntityState.Modified;
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
