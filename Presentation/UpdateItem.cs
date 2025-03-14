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
    public partial class UpdateItem : BaseForm
    {
        private readonly  CafeService cafeService ;
        Item UpdatedItem;
        public UpdateItem(int ItemId, CafeService _cafeService)
        {
            cafeService = _cafeService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            UpdatedItem = cafeService.GetCafeItemByIdFromService(ItemId);
            NewNameInput.Text = UpdatedItem.Name;
            NewPriceInput.Value = UpdatedItem.Price;
            NewStockInput.Value = UpdatedItem.Stock;
        }
        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            if (UpdatedItem.Name != NewNameInput.Text && cafeService.IsItemNameIsUsed(NewNameInput.Text))
            {
                MessageBox.Show("هذا المنتج موجود بالفعل", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdatedItem.Name=NewNameInput.Text ;
            UpdatedItem.Price = NewPriceInput.Value;
            UpdatedItem.Stock = NewStockInput.Value;
            cafeService.UpdateCafeItemFromService(UpdatedItem);
        }
    }
}
