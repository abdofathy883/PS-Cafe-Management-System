using PlayStation.Application.Services;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayStation.Presentation
{
    public partial class Cafetria : BaseForm
    {
        CafeService cafeService = new CafeService();
        public Cafetria()
        {
            InitializeComponent();
            ProductsGrid.DataSource = cafeService.GetCafeItemsFromService();
            ProductsGrid.Columns["ID"].Visible = false;
        }
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductNameInput.Text) || ProductPriceInput.Value < 1)
            {
                MessageBox.Show("برجاء ادخال اسم وسعر للمنتج", "فشل اضافة منتج", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Item cafeteriaItems = new Item();
                cafeteriaItems.Name = ProductNameInput.Text;
                cafeteriaItems.Stock = (byte)ProductStockInput.Value;
                cafeteriaItems.Price = ProductPriceInput.Value;
                cafeService.AddCafeItemFromService(cafeteriaItems);
                ProductsGrid.Refresh();
            }
        }
        private void ProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Item UpdatedItem = new()
            {
                Id = Convert.ToInt32(ProductsGrid.Rows[e.RowIndex].Cells["ID"].Value),
                Name = ProductsGrid.Rows[e.RowIndex].Cells["ItemName"].Value.ToString() ?? "اسم الجهاز غير محدد",
                Price = Convert.ToDecimal(ProductsGrid.Rows[e.RowIndex].Cells["ItemPrice"].Value),
                Stock = Convert.ToByte(ProductsGrid.Rows[e.RowIndex].Cells["ItemStock"].Value)
            };
            UpdateItem updateItem = new UpdateItem(UpdatedItem);
            updateItem.ShowDialog();
        }
    }
}
