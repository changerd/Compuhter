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
    public partial class ClientEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int ClientId;
        public string csur, cfname, ctel;
        public ClientEntityForm()
        {
            InitializeComponent();
        }

        private void ClientEntityForm_Load(object sender, EventArgs e)
        {
            metroTileClientAdd.Visible = btnAddvisible;
            metroTileClientEdit.Visible = btnEditvisible;
            metroTextBoxSurname.Text = csur;
            metroTextBoxFirstName.Text = cfname;            
            maskedTextBoxTelephone.Text = ctel;
        }

        private void metroTileClientAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSurname.Text) ||
                    String.IsNullOrEmpty(metroTextBoxFirstName.Text) ||                    
                    String.IsNullOrEmpty(maskedTextBoxTelephone.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Client client = new Client()
                {                    
                    ClientSurName = metroTextBoxSurname.Text,
                    ClientFirstName = metroTextBoxFirstName.Text,                    
                    ClientTelephone = maskedTextBoxTelephone.Text,
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Clients.Add(client);
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

        private void metroTileClientEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxSurname.Text) ||
                    String.IsNullOrEmpty(metroTextBoxFirstName.Text) ||                    
                    String.IsNullOrEmpty(maskedTextBoxTelephone.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var client = context.Clients.Find(ClientId);
                    client.ClientSurName = metroTextBoxSurname.Text;
                    client.ClientFirstName = metroTextBoxFirstName.Text;
                    client.ClientTelephone = maskedTextBoxTelephone.Text;
                    context.Entry(client).State = EntityState.Modified;
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
