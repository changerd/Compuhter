using Compuhter.Entities;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compuhter
{    
    public partial class ClientForm : MetroForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ClientForm()
        {
            InitializeComponent();
        }
        void CreateTableClient()
        {
            try
            {
                DataTable tableofClient = new DataTable();
                DataColumn ClientIdColumn = new DataColumn("Номер клиента", typeof(int));                
                DataColumn ClientSurNameColumn = new DataColumn("Фамилия", typeof(string));
                DataColumn ClientLastNameColumn = new DataColumn("Имя", typeof(string));                
                DataColumn ClientTelephoneColumn = new DataColumn("Телефон", typeof(string));
                tableofClient.Columns.AddRange(new DataColumn[]
                {
                    ClientIdColumn,
                    ClientSurNameColumn,
                    ClientLastNameColumn,
                    ClientTelephoneColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Clients.ToList();
                    int i = 0;
                    foreach (var c in query)
                    {
                        DataRow newRow = tableofClient.NewRow();
                        newRow["Номер клиента"] = c.ClientId;
                        newRow["Фамилия"] = c.ClientSurName;
                        newRow["Имя"] = c.ClientFirstName;
                        newRow["Телефон"] = c.ClientTelephone;
                        tableofClient.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewClient.DataSource = tableofClient;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            CreateTableClient();
        }

        private void metroButtonClientAdd_Click(object sender, EventArgs e)
        {
            ClientEntityForm form = new ClientEntityForm();
            form.Text = "Добавление клиента";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonClientEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(dataGridViewClient.SelectedCells[0].Value.ToString());
                var client = db.Clients.Find(cid);
                ClientEntityForm form = new ClientEntityForm();
                form.Text = "Изменение клиента";
                form.btnEditvisible = true;
                form.ClientId = client.ClientId;
                form.csur = client.ClientSurName;
                form.cfname = client.ClientFirstName;
                form.ctel = client.ClientTelephone;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonClientDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(dataGridViewClient.SelectedCells[0].Value.ToString());
                var client = db.Clients.Find(cid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить клиента", "Compuhter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Clients.Remove(client);
                    db.SaveChanges();
                }
                ClientForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTileRefresh_Click(object sender, EventArgs e)
        {
            ClientForm_Load(sender, e);
        }        
    }
}