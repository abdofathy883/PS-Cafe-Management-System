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
        private readonly CafeService cafeService ;
        public Cafetria(CafeService _cafeService)
        {
            cafeService = _cafeService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            ProductsGrid.DataSource = cafeService.GetCafeItemsFromService();
            ProductsGrid.Columns["ID"].Visible = false;
            ProductsGrid.Columns["OrderDetails"].Visible = false;
            ProductsGrid.Columns["Name"].HeaderText = "الاسم";
            ProductsGrid.Columns["Price"].HeaderText = "السعر";
            ProductsGrid.Columns["Stock"].HeaderText = "المخزون";
            ProductsGrid.Columns["IsDeleted"].Visible = false;
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
                Item newCafeteriaItem = new Item()
                {
                    Name = ProductNameInput.Text,
                    Stock = (byte)ProductStockInput.Value,
                    Price = ProductPriceInput.Value,
                };

                //Check for already existing product
                if (cafeService.GetCafeItemsFromService().Any(x => x.Name == newCafeteriaItem.Name))
                {
                    MessageBox.Show("هذا المنتج موجود بالفعل", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cafeService.AddCafeItemFromService(newCafeteriaItem);
                ProductsGrid.Refresh();
            }
        }
        private void ProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Item UpdatedItem = new()
            {
                Id = Convert.ToInt32(ProductsGrid.Rows[e.RowIndex].Cells["ID"].Value),
                Name = ProductsGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString() ?? "اسم الجهاز غير محدد",
                Price = Convert.ToDecimal(ProductsGrid.Rows[e.RowIndex].Cells["Price"].Value),
                Stock = Convert.ToByte(ProductsGrid.Rows[e.RowIndex].Cells["Stock"].Value)
            };
            UpdateItem updateItem = new UpdateItem(UpdatedItem, cafeService);
            updateItem.ShowDialog();
        }
    }
}
