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
    public partial class ProductEntityForm : MetroForm
    {
        public bool btnAddvisible = false;
        public bool btnEditvisible = false;
        public int ProductId;
        public string pmanu, pname, pcost;
        public ProductEntityForm()
        {
            InitializeComponent();
        }
        private void ProductEntityForm_Load(object sender, EventArgs e)
        {
            metroTileProductAdd.Visible = btnAddvisible;
            metroTileProductEdit.Visible = btnEditvisible;
            metroTextBoxManufacturer.Text = pmanu;
            metroTextBoxName.Text = pname;
            metroTextBoxCost.Text = pcost;
        }

        private void metroTileProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxManufacturer.Text) ||
                    String.IsNullOrEmpty(metroTextBoxName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxCost.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                Product product = new Product
                {
                    ProductManufacturer = metroTextBoxManufacturer.Text,
                    ProductName = metroTextBoxName.Text,
                    ProductCost = Convert.ToDecimal(metroTextBoxCost.Text),
                };
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    context.Products.Add(product);
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
        
        private void metroTileProductEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(metroTextBoxManufacturer.Text) ||
                    String.IsNullOrEmpty(metroTextBoxName.Text) ||
                    String.IsNullOrEmpty(metroTextBoxCost.Text))
                    throw new Exception("Поля не должны быть пустыми!");
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var product = context.Products.Find(ProductId);
                    product.ProductManufacturer = metroTextBoxManufacturer.Text;
                    product.ProductName = metroTextBoxName.Text;
                    product.ProductCost = Convert.ToDecimal(metroTextBoxCost.Text);
                    context.Entry(product).State = EntityState.Modified;
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

        private void metroTextBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46)
            {
                e.Handled = true;
            }
        }
    }
}
