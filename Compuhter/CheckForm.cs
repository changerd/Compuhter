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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Compuhter
{
    public partial class CheckForm : MetroForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public CheckForm()
        {
            InitializeComponent();
        }
        private void CheckForm_Load(object sender, EventArgs e)
        {
            CreateTableCheck();
        }
        void CreateTableCheck()
        {
            try
            {
                DataTable tableofCheck = new DataTable();
                DataColumn CheckIdColumn = new DataColumn("Номер чека", typeof(int));
                DataColumn CheckClientColumn = new DataColumn("Клиент", typeof(string));
                DataColumn CheckEmployeeColumn = new DataColumn("Сотрудник", typeof(string));
                DataColumn CheckAmountColumn = new DataColumn("Сумма", typeof(decimal));
                DataColumn CheckDateColumn = new DataColumn("Дата", typeof(DateTime));
                tableofCheck.Columns.AddRange(new DataColumn[]
                {
                    CheckIdColumn,
                    CheckClientColumn,
                    CheckEmployeeColumn,
                    CheckAmountColumn,
                    CheckDateColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Checks.Include(c => c.Client).Include(e => e.Employee);
                    int i = 0;
                    foreach (var c in query)
                    {
                        DataRow newRow = tableofCheck.NewRow();
                        newRow["Номер чека"] = c.CheckId;
                        newRow["Клиент"] = c.Client.ClientSurName + " " + c.Client.ClientFirstName;
                        newRow["Сотрудник"] = c.Employee.EmployeeSurName + " " + c.Employee.EmployeeFirstName;
                        newRow["Сумма"] = c.Amount;
                        newRow["Дата"] = c.CheckDate;
                        tableofCheck.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewCheck.DataSource = tableofCheck;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
        void CreateTableProductCheck()
        {

        }
        private void metroButtonCheckAdd_Click(object sender, EventArgs e)
        {
            CheckEntityForm form = new CheckEntityForm();
            form.Text = "Добавление чека";
            form.btnAddvisible = true;
            form.Show();
        }

        private void metroButtonCheckEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(dataGridViewCheck.SelectedCells[0].Value.ToString());
                var check = db.Checks.Find(cid);
                CheckEntityForm form = new CheckEntityForm();
                form.Text = "Изменение чека";
                form.btnEditvisible = true;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonCheckDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(dataGridViewCheck.SelectedCells[0].Value.ToString());
                var check = db.Checks.Find(cid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить чек?", "Compuhter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Checks.Remove(check);
                    db.SaveChanges();
                }
                CheckForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTileRefresh_Click(object sender, EventArgs e)
        {
            CheckForm_Load(sender, e);
        }
        private void dataGridViewCheck_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable tableofProductCheck = new DataTable();
                DataColumn ProductCheckIdColumn = new DataColumn("Номер товара", typeof(int));
                DataColumn ProductCheckManufacturerColumn = new DataColumn("Производитель", typeof(string));
                DataColumn ProductCheckNameColumn = new DataColumn("Название", typeof(string));
                DataColumn ProductCheckCostColumn = new DataColumn("Цена", typeof(decimal));
                DataColumn ProductCheckQuantityColumn = new DataColumn("Количество", typeof(int));
                tableofProductCheck.Columns.AddRange(new DataColumn[]
                {
                    ProductCheckIdColumn,
                    ProductCheckManufacturerColumn,
                    ProductCheckNameColumn,
                    ProductCheckCostColumn,
                    ProductCheckQuantityColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    int CheckId = Convert.ToInt32(dataGridViewCheck.SelectedCells[0].Value.ToString());
                    var query = context.ProductChecks.Include(p => p.Product).Where(c => c.CheckId == CheckId);
                    int i = 0;
                    foreach (var pc in query)
                    {
                        DataRow newRow = tableofProductCheck.NewRow();
                        newRow["Номер товара"] = pc.ProductCheckId;
                        newRow["Производитель"] = pc.Product.ProductManufacturer;
                        newRow["Название"] = pc.Product.ProductName;
                        newRow["Цена"] = pc.Product.ProductCost;
                        newRow["Количество"] = pc.Quantity;
                        tableofProductCheck.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewProductCheck.DataSource = tableofProductCheck;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonProductCheckAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(dataGridViewCheck.SelectedCells[0].Value.ToString());
                var check = db.Checks.Find(cid);
                ProductCheckEntityForm form = new ProductCheckEntityForm();
                form.Text = "Добавление товара в чек";
                form.CheckId = check.CheckId;
                form.btnAddvisible = true;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonProductCheckEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(dataGridViewCheck.SelectedCells[0].Value.ToString());
                var check = db.Checks.Find(cid);
                int pcid = Convert.ToInt32(dataGridViewProductCheck.SelectedCells[0].Value.ToString());
                var productcheck = db.ProductChecks.Find(pcid);
                ProductCheckEntityForm form = new ProductCheckEntityForm();
                form.Text = "Изменение товара в чеке";
                form.btnEditvisible = true;
                form.CheckId = check.CheckId;
                form.ProductCheckId = productcheck.ProductCheckId;
                form.Quantity = productcheck.Quantity;
                form.Show();
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroButtonProductCheckDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(dataGridViewCheck.SelectedCells[0].Value.ToString());
                int pcid = Convert.ToInt32(dataGridViewProductCheck.SelectedCells[0].Value.ToString());
                var productcheck = db.ProductChecks.Find(pcid);
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить товар в чеке?", "Compuhter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.ProductChecks.Remove(productcheck);
                    db.SaveChanges();
                    var productchecks = db.ProductChecks.Include(c => c.Check).Include(p => p.Product).Where(c => c.CheckId == cid).ToList();
                    var check = db.Checks.SingleOrDefault(c => c.CheckId == cid);
                    decimal checkAmount = productchecks.Sum(s => s.Quantity * s.Product.ProductCost);
                    check.Amount = checkAmount;
                    db.Entry(check).State = EntityState.Modified;
                    db.SaveChanges();
                }
                CheckForm_Load(sender, e);
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTileFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tableofCheck = new DataTable();
                DataColumn CheckIdColumn = new DataColumn("Номер чека", typeof(int));
                DataColumn CheckClientColumn = new DataColumn("Клиент", typeof(string));
                DataColumn CheckEmployeeColumn = new DataColumn("Сотрудник", typeof(string));
                DataColumn CheckAmountColumn = new DataColumn("Сумма", typeof(decimal));
                DataColumn CheckDateColumn = new DataColumn("Дата", typeof(DateTime));
                tableofCheck.Columns.AddRange(new DataColumn[]
                {
                    CheckIdColumn,
                    CheckClientColumn,
                    CheckEmployeeColumn,
                    CheckAmountColumn,
                    CheckDateColumn,
                });
                using (ApplicationDbContext context = new ApplicationDbContext())
                {
                    var query = context.Checks.Include(c => c.Client).Include(c => c.Employee).Where(d => d.CheckDate >= dateTimePickerFirst.Value && d.CheckDate <= dateTimePickerSecond.Value);
                    int i = 0;
                    foreach (var c in query)
                    {
                        DataRow newRow = tableofCheck.NewRow();
                        newRow["Номер чека"] = c.CheckId;
                        newRow["Клиент"] = c.Client.ClientSurName + " " + c.Client.ClientFirstName;
                        newRow["Сотрудник"] = c.Employee.EmployeeSurName + " " + c.Employee.EmployeeFirstName;
                        newRow["Сумма"] = c.Amount;
                        newRow["Дата"] = c.CheckDate;
                        tableofCheck.Rows.Add(newRow);
                        i++;
                    }
                    dataGridViewCheck.DataSource = tableofCheck;
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
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
                    List<ProductCheck> productChecks = new List<ProductCheck>();
                    using (ApplicationDbContext context = new ApplicationDbContext())
                    {
                        IQueryable<ProductCheck> query = context.ProductChecks.Include(c => c.Product).Include(c => c.Check);
                        if (metroCheckBoxDate.Checked)
                        {
                            query = query.Where(c => c.Check.CheckDate >= dateTimePickerFirst.Value && c.Check.CheckDate <= dateTimePickerSecond.Value);
                        }
                        productChecks = query.ToList();
                    }
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Workbooks.Add();
                    Excel._Worksheet worksheet = excelApp.ActiveSheet;
                    if (metroCheckBoxDate.Checked)
                        worksheet.Cells[1, "A"] = "Продажи с " + dateTimePickerFirst.Value + " по " + dateTimePickerSecond.Value;
                    else
                        worksheet.Cells[1, "A"] = "Все продажи";
                    worksheet.Cells[2, "A"] = "Производитель";
                    worksheet.Cells[2, "B"] = "Название";
                    worksheet.Cells[2, "C"] = "Цена";
                    worksheet.Cells[2, "D"] = "Количество";
                    worksheet.Cells[2, "E"] = "Дата продажи";
                    int row = 2;
                    foreach (var pc in productChecks)
                    {
                        row++;
                        worksheet.Cells[row, "A"] = pc.Product.ProductManufacturer;
                        worksheet.Cells[row, "B"] = pc.Product.ProductName;
                        worksheet.Cells[row, "C"] = pc.Product.ProductCost;
                        worksheet.Cells[row, "D"] = pc.Quantity;
                        worksheet.Cells[row, "E"] = pc.Check.CheckDate;
                    }
                    row++;
                    worksheet.Cells[row, "A"] = "Итого";
                    worksheet.Cells[row, "E"] = productChecks.Sum(s => s.Product.ProductCost * s.Quantity);
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

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Сохранение doc файла";
                saveFileDialog1.Filter = "doc файлы (*.doc)|*.doc|Все файлы (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    int cid = Convert.ToInt32(dataGridViewCheck.SelectedCells[0].Value.ToString());
                    var productchecks = db.ProductChecks.Include(c => c.Check).Include(p => p.Product).Where(c => c.CheckId == cid).ToList();
                    var check = db.Checks.Include(c => c.Client).Include(c => c.Employee).SingleOrDefault(c => c.CheckId == cid);
                    object oMissing = System.Reflection.Missing.Value;
                    object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

                    //Start Word and create a new document.
                    Word._Application oWord;
                    Word._Document oDoc;
                    oWord = new Word.Application();
                    oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing);
                    Word.Paragraph oPara1;
                    oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = "Чек №" + check.CheckId;
                    oPara1.Range.Font.Bold = 1;                    
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.InsertParagraphAfter();

                    Word.Paragraph oPara2;
                    object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara2.Range.Text = "Клиент: " + check.Client.ClientSurName + " " + check.Client.ClientFirstName + "\n" +
                        "Сотрудник: " + check.Employee.EmployeeSurName + " " + check.Employee.EmployeeFirstName + "\n" +
                        "Дата: " + check.CheckDate;
                    oPara2.Format.SpaceAfter = 12;
                    oPara2.Range.InsertParagraphAfter();

                    Word.Table oTable;
                    Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oTable = oDoc.Tables.Add(wrdRng, productchecks.Count + 3, 4, ref oMissing, ref oMissing);
                    int i = 2;
                    oTable.Cell(1, 1).Range.Text = "Товары:";
                    oTable.Cell(2, 1).Range.Text = "Производитель";
                    oTable.Cell(2, 2).Range.Text = "Название";
                    oTable.Cell(2, 3).Range.Text = "Цена";
                    oTable.Cell(2, 4).Range.Text = "Количество";
                    foreach (var pc in productchecks)
                    {
                        i++;
                        oTable.Cell(i, 1).Range.Text = pc.Product.ProductManufacturer;
                        oTable.Cell(i, 2).Range.Text = pc.Product.ProductName;
                        oTable.Cell(i, 3).Range.Text = pc.Product.ProductCost.ToString();
                        oTable.Cell(i, 4).Range.Text = pc.Quantity.ToString();
                    }
                    i++;
                    oTable.Cell(i, 1).Range.Text = "Итого: ";
                    oTable.Cell(i, 2).Range.Text = productchecks.Sum(s => s.Product.ProductCost * s.Quantity).ToString();
                    oDoc.SaveAs(string.Format(saveFileDialog1.FileName));
                    oWord.Quit();
                    MessageBox.Show("Word-файл успешно сохранён", "Compuhter");
                }
            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message, "Ошибка");
            }
        }
    }
}