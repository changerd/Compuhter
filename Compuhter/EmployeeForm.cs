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
    public partial class EmployeeForm : MetroForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public EmployeeForm()
        {
            InitializeComponent();
        }
        void CreateTableEmployee()
        {
            try
            {
                DataTable tableofEmployee = new DataTable();
                DataColumn EmployeeIdColumn = new DataColumn("Номер сотрудника", typeof(int));
                DataColumn EmployeePositionColumn = new DataColumn("Должность", typeof(string));
                DataColumn EmployeeSurNameColumn = new DataColumn("Фамилия", typeof(string));
                DataColumn EmployeeLastNameColumn = new DataColumn("Имя", typeof(string));
                DataColumn EmployeeSecondNameColumn = new DataColumn("Отчество", typeof(string));                
                DataColumn EmployeeTelephoneColumn = new DataColumn("Телефон", typeof(string));
                tableofEmployee.Columns.AddRange(new DataColumn[]
                {
                    EmployeeIdColumn,
                    EmployeePositionColumn,
                    EmployeeSurNameColumn,
                    EmployeeLastNameColumn,
                    EmployeeSecondNameColumn,
                    EmployeeTelephoneColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Employees.Include(e => e.Position).ToList();
                    int i = 0;
                    foreach (var e in query)
                    {
                        DataRow newRow = tableofEmployee.NewRow();
                        newRow["Номер сотрудника"] = e.EmployeeId;
                        newRow["Должность"] = e.Position.PositionName;
                        newRow["Фамилия"] = e.EmployeeSurName;
                        newRow["Имя"] = e.EmployeeFirstName;
                        newRow["Отчество"] = e.EmployeeSecondName;                        
                        newRow["Телефон"] = e.EmployeeTelephone;
                        tableofEmployee.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewEmployee.DataSource = tableofEmployee;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        void CreateTablePosition()
        {
            try
            {
                DataTable tableofPosition = new DataTable();
                DataColumn PositionIdColumn = new DataColumn("Номер должности", typeof(int));
                DataColumn PositionNameColumn = new DataColumn("Название", typeof(string));
                tableofPosition.Columns.AddRange(new DataColumn[]
                {
                    PositionIdColumn,
                    PositionNameColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Positions.ToList();
                    int i = 0;
                    foreach (var p in query)
                    {
                        DataRow newRow = tableofPosition.NewRow();
                        newRow["Номер должности"] = p.PositionId;
                        newRow["Название"] = p.PositionName;
                        tableofPosition.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewPosition.DataSource = tableofPosition;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            metroTabControl1_SelectedIndexChanged(sender, e);
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                CreateTableEmployee();
            }
            if (metroTabControl1.SelectedIndex == 1)
            {
                CreateTablePosition();
            }
        }

        private void metroButtonPosotionAdd_Click(object sender, EventArgs e)
        {
            PositionEntityForm form = new PositionEntityForm();
            form.Text = "Добавление должности";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonPositionEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(dataGridViewPosition.SelectedCells[0].Value.ToString());
                var position = db.Positions.Find(pid);
                PositionEntityForm form = new PositionEntityForm();
                form.Text = "Изменение должности";
                form.btnEditvisible = true;
                form.PositionId = position.PositionId;
                form.pname = position.PositionName;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonPositionDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(dataGridViewPosition.SelectedCells[0].Value.ToString());
                var position = db.Positions.Find(pid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить должность?", "Compuhter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Positions.Remove(position);
                    db.SaveChanges();
                }
                EmployeeForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonEmployeeAdd_Click(object sender, EventArgs e)
        {
            EmployeeEntityForm form = new EmployeeEntityForm();
            form.Text = "Добавление сотрудника";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonEmployeeEdit_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(dataGridViewEmployee.SelectedCells[0].Value.ToString());
            var employee = db.Employees.Find(eid);
            EmployeeEntityForm form = new EmployeeEntityForm();
            form.Text = "Изменение сотрудника";
            form.EmployeeId = employee.EmployeeId;
            form.esur = employee.EmployeeSurName;
            form.efname = employee.EmployeeFirstName;
            form.esname = employee.EmployeeSecondName;
            form.etel = employee.EmployeeTelephone;
            form.btnEditvisible = true;            
            form.Show();
        }

        private void metroButtonEmployeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int eid = Convert.ToInt32(dataGridViewEmployee.SelectedCells[0].Value.ToString());
                var employee = db.Employees.Find(eid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить сотрудника?", "Compuhter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Employees.Remove(employee);
                    db.SaveChanges();
                }
                EmployeeForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTileRefresh_Click(object sender, EventArgs e)
        {
            EmployeeForm_Load(sender, e);
        }
    }
}
