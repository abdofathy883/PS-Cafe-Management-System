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
        public UpdateItem(CafeService _cafeService)
        {
            cafeService = _cafeService;
            InitializeComponent();
        }
        public UpdateItem(Item _UpdatedItem)
        {
            InitializeComponent();
            UpdatedItem = _UpdatedItem;
            NewNameInput.Text = UpdatedItem.Name;
            NewPriceInput.Value = UpdatedItem.Price;
            NewStockInput.Value = UpdatedItem.Stock;
        }
        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            UpdatedItem.Price = NewPriceInput.Value;
            UpdatedItem.Stock = (byte)NewStockInput.Value;
            cafeService.UpdateCafeItemFromService(UpdatedItem);
        }
    }
}
