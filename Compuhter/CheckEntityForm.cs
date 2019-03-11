using Compuhter.Entities;
using Compuhter.VM;
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
    public partial class CheckEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int CheckId;
        public DateTime CheckDate;
        public CheckEntityForm()
        {
            InitializeComponent();
        }
        void GetComboBoxes()
        {
            List<ComboBoxModel> clients = new List<ComboBoxModel>();
            List<ComboBoxModel> employees = new List<ComboBoxModel>();
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var client = context.Clients;
                foreach (var c in client)
                {
                    ComboBoxModel vm = new ComboBoxModel()
                    {
                        Id = c.ClientId,
                        Name = c.ClientSurName + " " + c.ClientFirstName,
                    };
                    clients.Add(vm);
                }
                var employee = context.Employees;
                foreach (var e in employee)
                {
                    ComboBoxModel vm = new ComboBoxModel()
                    {
                        Id = e.EmployeeId,
                        Name = e.EmployeeSurName + " " + e.EmployeeFirstName,
                    };
                    employees.Add(vm);
                }
            }
            metroComboBoxClient.DataSource = clients;
            metroComboBoxClient.DisplayMember = "Name";
            metroComboBoxClient.ValueMember = "Id";
            metroComboBoxEmployee.DataSource = employees;
            metroComboBoxEmployee.DisplayMember = "Name";
            metroComboBoxEmployee.ValueMember = "Id";
        }
        private void CheckEntityForm_Load(object sender, EventArgs e)
        {
            GetComboBoxes();
            metroTileCheckAdd.Visible = btnAddvisible;
            metroTileCheckEdit.Visible = btnEditvisible;
        }
        private void metroTileCheckAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Check check = new Check()
                {
                    ClientId = Convert.ToInt32(metroComboBoxClient.SelectedValue),
                    EmployeeId = Convert.ToInt32(metroComboBoxEmployee.SelectedValue),
                    CheckDate = DateTime.Now,
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Checks.Add(check);
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

        private void metroTileEditCheck_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var check = context.Checks.Find(CheckId);
                    check.ClientId = Convert.ToInt32(metroComboBoxClient.SelectedValue);
                    check.EmployeeId = Convert.ToInt32(metroComboBoxEmployee.SelectedValue);
                    check.CheckDate = CheckDate;
                    context.Entry(check).State = EntityState.Modified;
                    context.SaveChanges();
                }
                MessageBox.Show("Запись успешно изменена!", "GraduateDistribution");
                this.Close();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }        


    }
}
