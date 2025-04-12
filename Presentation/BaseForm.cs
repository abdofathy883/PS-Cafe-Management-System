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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            ApplyGlobalStyles(this);
        }
        protected Color PrimaryColor = ColorTranslator.FromHtml("#16404D");
        protected Color SecondaryColor = ColorTranslator.FromHtml("#4F959D"); 
        protected Color AccentColor = ColorTranslator.FromHtml("#DDA853"); 

        protected void ApplyGlobalStyles(Form parent)
        {
            ApplyGlobalStylesToControls(parent.Controls);
        }
        protected void ApplyGlobalStylesToControls(Control.ControlCollection ctrls)
        {
            this.BackColor = PrimaryColor;
            this.ForeColor = Color.White;
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is Panel pnl)
                {
                    pnl.BackColor = PrimaryColor;
                    pnl.BorderStyle = BorderStyle.None;
                    pnl.Padding = new Padding(5);
                    pnl.Margin = new Padding(5);
                    pnl.AutoSize = true;
                    if (pnl.HasChildren)
                    {
                        ApplyGlobalStylesToControls(pnl.Controls);
                    }
                }
                else if (ctrl is DataGridView grid)
                {
                    grid.BorderStyle = BorderStyle.None;
                    grid.BackgroundColor = AccentColor;
                    grid.AllowUserToAddRows = false;
                    grid.AllowUserToResizeRows = false;
                    grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    grid.RowHeadersVisible = false;
                    grid.GridColor = Color.FromArgb(200, 200, 200);

                    grid.DefaultCellStyle.BackColor = Color.White;
                    grid.DefaultCellStyle.ForeColor = PrimaryColor;
                    grid.DefaultCellStyle.Padding = new Padding(5);

                    grid.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = PrimaryColor;
                    grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                    grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    grid.EnableHeadersVisualStyles = false;

                    grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    grid.AlternatingRowsDefaultCellStyle.BackColor = SecondaryColor;
                    grid.ColumnHeadersHeight = 40;
                    grid.RowTemplate.Height = 40;
                }
                else if (ctrl is Button btn)
                {
                    btn.BackColor = AccentColor;
                    btn.ForeColor = PrimaryColor;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Arial", 13, FontStyle.Bold);
                }
            }
        }
    }
}
