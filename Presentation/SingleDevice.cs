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
    public partial class SingleDevice : BaseForm
    {
        CafeService CafeService;
        Device CurrentDevice;
        public Dictionary<string, int> CurrentOrder = new Dictionary<string, int>();
        public SingleDevice(CafeService CafeService)
        {
            InitializeComponent();
            ApplyGlobalStyles(this);
            this.CafeService = CafeService;
            ItemsCombo.DataSource = CafeService.GetCafeItemsFromService();
            ItemsCombo.DisplayMember = "Name";
            ItemsCombo.ValueMember = "Id";
        }
        public SingleDevice(Device CurrentDevice)
        {
            InitializeComponent();
            ApplyGlobalStyles(this);
            ItemsCombo.DataSource = CafeService.GetCafeItemsFromService();
            ItemsCombo.DisplayMember = "Name";
            ItemsCombo.ValueMember = "Id";
            this.CurrentDevice = CurrentDevice;
        }
        DataGridViewTextBoxColumn Total = new DataGridViewTextBoxColumn()
        {
            Name = "السعر",
            HeaderText = "السعر", 
            ReadOnly = true
        };

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (ItemsCounter.Value <= 0)
            {
                MessageBox.Show("يرجى اختيار عدد الوحدات المستخدمة من هذا المنتج", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string item = ItemsCombo.SelectedItem.ToString();
                var itemprice = CafeService.GetItemByID((int)ItemsCombo.SelectedValue).Price;
                int quantity = (int)ItemsCounter.Value;
                CurrentOrder.Add(item, quantity);


                var CurrentOrderList = CurrentOrder.Select(x => new
                {
                    ProductName = x.Key,
                    ProductQuantity = x.Value
                }).ToList();
                OrderGrid.Columns.Add(Total);
                foreach (DataGridViewRow row in OrderGrid.Rows)
                {
                    int gridQuantity = (int)row.Cells["Quantity"].Value;
                    row.Cells["Toatl"].Value = gridQuantity * itemprice;
                }
                OrderGrid.DataSource = null;
                OrderGrid.DataSource = CurrentOrderList;
            }
        }
    }
}
