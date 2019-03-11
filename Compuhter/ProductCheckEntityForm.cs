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
    public partial class ProductCheckEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int CheckId, ProductCheckId, Quantity;
        public ProductCheckEntityForm()
        {
            InitializeComponent();
        }
        void GetComboBox()
        {
            List<ComboBoxModel> products = new List<ComboBoxModel>();
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var product = context.Products.ToList();
                foreach (var p in product)
                {
                    ComboBoxModel cb = new ComboBoxModel()
                    {
                        Id = p.ProductId,
                        Name = p.ProductManufacturer + " " + p.ProductName,
                    };
                    products.Add(cb);
                }
            }
            metroComboBoxProduct.DataSource = products;
            metroComboBoxProduct.DisplayMember = "Name";
            metroComboBoxProduct.ValueMember = "Id";
        }

        private void ProductCheckEntityForm_Load(object sender, EventArgs e)
        {
            GetComboBox();
            metroTileProductCheckAdd.Visible = btnAddvisible;
            metroTileProductCheckEdit.Visible = btnEditvisible;
            metroTextBoxQuantity.Text = Quantity.ToString();
        }



        private void metroTileProductCheckAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxQuantity.Text))
                    throw new Exception("Поля не должны быть пустыми");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    ProductCheck productCheck = new ProductCheck()
                    {
                        CheckId = CheckId,
                        ProductId = Convert.ToInt32(metroComboBoxProduct.SelectedValue),
                        Quantity = Convert.ToInt32(metroTextBoxQuantity.Text),
                    };
                    context.ProductChecks.Add(productCheck);
                    context.SaveChanges();
                    var productchecks = context.ProductChecks.Include(c => c.Check).Include(p => p.Product).Where(c => c.CheckId == CheckId).ToList();
                    var check = context.Checks.SingleOrDefault(c => c.CheckId == CheckId);
                    decimal checkAmount = productchecks.Sum(s => s.Quantity * s.Product.ProductCost);
                    check.Amount = checkAmount;
                    context.Entry(check).State = EntityState.Modified;
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

        private void metroTileProductCheckDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxQuantity.Text))
                    throw new Exception("Поля не должны быть пустыми");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var pc = context.ProductChecks.Find(ProductCheckId);
                    pc.ProductId = Convert.ToInt32(metroComboBoxProduct.SelectedValue);
                    pc.Quantity = Convert.ToInt32(metroTextBoxQuantity.Text);
                    context.Entry(pc).State = EntityState.Modified;
                    context.SaveChanges();
                    var productchecks = context.ProductChecks.Include(c => c.Check).Include(p => p.Product).Where(c => c.CheckId == CheckId).ToList();
                    var check = context.Checks.SingleOrDefault(c => c.CheckId == CheckId);
                    decimal checkAmount = productchecks.Sum(s => s.Quantity * s.Product.ProductCost);
                    check.Amount = checkAmount;
                    context.Entry(check).State = EntityState.Modified;
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

        private void metroTextBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

    }
}
