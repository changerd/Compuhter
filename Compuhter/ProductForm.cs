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
using Excel = Microsoft.Office.Interop.Excel;

namespace Compuhter
{
    public partial class ProductForm : MetroForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ProductForm()
        {
            InitializeComponent();
        }

        void CreateTableProduct()
        {
            try
            {
                DataTable tableofProduct = new DataTable();
                DataColumn ProductIdColumn = new DataColumn("Номер товара", typeof(int));
                DataColumn ProductManufacturerColumn = new DataColumn("Производитель", typeof(string));
                DataColumn ProductNameColumn = new DataColumn("Название", typeof(string));
                DataColumn ProductCostColumn = new DataColumn("Цена", typeof(decimal));
                tableofProduct.Columns.AddRange(new DataColumn[]
                {
                    ProductIdColumn,
                    ProductManufacturerColumn,
                    ProductNameColumn,
                    ProductCostColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Products;
                    int i = 0;
                    foreach (var p in query)
                    {
                        DataRow newRow = tableofProduct.NewRow();
                        newRow["Номер товара"] = p.ProductId;
                        newRow["Производитель"] = p.ProductManufacturer;
                        newRow["Название"] = p.ProductName;
                        newRow["Цена"] = p.ProductCost;
                        tableofProduct.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewProduct.DataSource = tableofProduct;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            CreateTableProduct();
        }

        private void metroButtonProductAdd_Click(object sender, EventArgs e)
        {
            ProductEntityForm form = new ProductEntityForm();
            form.Text = "Добавление товара";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonProductEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(dataGridViewProduct.SelectedCells[0].Value.ToString());
                var product = db.Products.Find(pid);
                ProductEntityForm form = new ProductEntityForm();
                form.Text = "Изменение товара";
                form.btnEditvisible = true;
                form.ProductId = product.ProductId;
                form.pmanu = product.ProductManufacturer;
                form.pname = product.ProductName;
                form.pcost = product.ProductCost.ToString();
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(dataGridViewProduct.SelectedCells[0].Value.ToString());
                var product = db.Products.Find(pid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить товар?", "Compuhter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                }
                ProductForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTileRefresh_Click(object sender, EventArgs e)
        {
            ProductForm_Load(sender, e);
        }

        private void metroTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrencyManager cManager = dataGridViewProduct.BindingContext[dataGridViewProduct.DataSource, dataGridViewProduct.DataMember] as CurrencyManager;
                cManager.SuspendBinding();
                cManager.ResumeBinding();
                for (int i = 0; i < dataGridViewProduct.RowCount; i++)
                {
                    dataGridViewProduct.Rows[i].Selected = false;
                }
                if (metroTextBoxSearch.Text == "")
                    for (int i = 0; i < dataGridViewProduct.RowCount; i++)
                    {
                        dataGridViewProduct.Rows[i].Selected = false;
                        dataGridViewProduct.Rows[i].Visible = true;
                    }
                else
                {
                    for (int i = 0; i < dataGridViewProduct.RowCount; i++)
                    {
                        dataGridViewProduct.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewProduct.ColumnCount; j++)
                            if (dataGridViewProduct.Rows[i].Cells[j].Value != null)

                                if (dataGridViewProduct.Rows[i].Cells[j].Value.ToString().Contains(metroTextBoxSearch.Text))
                                {
                                    dataGridViewProduct.Rows[i].Selected = true;
                                    dataGridViewProduct.Rows[i].Visible = true;
                                    break;
                                }
                                else
                                {
                                    dataGridViewProduct.Rows[i].Selected = false;
                                    dataGridViewProduct.Rows[i].Visible = false;
                                }
                    }
                }
            }

            catch
            {
                MessageBox.Show("При поиске произошла ошибка, для исправления выберите другую строку");
            }
        }

        private void metroTileExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Сохранение xlsx файла";
                saveFileDialog1.Filter = "xlsx файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var products = db.Products.ToList();
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel._Worksheet worksheet = excelApp.ActiveSheet;
                    worksheet.Cells[1, "A"] = "Товары";
                    worksheet.Cells[2, "A"] = "Номер товара";
                    worksheet.Cells[2, "B"] = "Производитель";
                    worksheet.Cells[2, "C"] = "Название";
                    worksheet.Cells[2, "D"] = "Цена";
                    int row = 2;
                    foreach (var p in products)
                    {
                        row++;
                        worksheet.Cells[row, "A"] = p.ProductId;
                        worksheet.Cells[row, "B"] = p.ProductManufacturer;
                        worksheet.Cells[row, "C"] = p.ProductName;
                        worksheet.Cells[row, "D"] = p.ProductCost;
                    }
                    worksheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);

                    worksheet.SaveAs(saveFileDialog1.FileName);
                    excelApp.Quit();
                    MessageBox.Show("Excel-файл успешно сохранен", "Compuhter");
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
    }
}
