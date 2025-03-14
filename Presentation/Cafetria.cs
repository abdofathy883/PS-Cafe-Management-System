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
            DisplayProductsGrid();
        }
        private void DisplayProductsGrid()
        {
            ProductsGrid.DataSource = null;
            ProductsGrid.DataSource = cafeService.GetCafeItemsFromService().Select(p=>new {p.Id,p.Name,p.Price,p.Stock }).ToList();
            ProductsGrid.Columns["ID"].Visible = false;
            ProductsGrid.Columns["Name"].HeaderText = "الاسم";
            ProductsGrid.Columns["Price"].HeaderText = "السعر";
            ProductsGrid.Columns["Stock"].HeaderText = "المخزون";
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
                    Stock = ProductStockInput.Value,
                    Price = ProductPriceInput.Value,
                };

                //Check for already existing product
                if (cafeService.IsItemNameIsUsed(newCafeteriaItem.Name))
                {
                    MessageBox.Show("هذا المنتج موجود بالفعل", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cafeService.AddCafeItemFromService(newCafeteriaItem);
                DisplayProductsGrid();
            }
        }
        private void ProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = Convert.ToInt32(ProductsGrid.Rows[e.RowIndex].Cells["ID"].Value);
            UpdateItem updateItem = new UpdateItem(Id, cafeService);
            updateItem.ShowDialog();
            DisplayProductsGrid();
        }
    }
}
