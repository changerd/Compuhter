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
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void metroTileProducts_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.Show();
        }

        private void metroTileEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.Show();
        }

        private void metroTileClients_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.Show();
        }

        private void metroTileChecks_Click(object sender, EventArgs e)
        {
            CheckForm form = new CheckForm();
            form.Show();
        }
    }
}
