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
        protected Color PrimaryColor = ColorTranslator.FromHtml("#205781");  // Deep Blue
        protected Color SecondaryColor = ColorTranslator.FromHtml("#4F959D"); // Teal
        protected Color AccentColor = ColorTranslator.FromHtml("#98D2C0"); // Soft Green
        protected Color BackgroundColor = ColorTranslator.FromHtml("#F6F8D5"); // Light Cream
        protected Color TextColor = Color.Black; // Black for contrast
        protected Color BorderColor = Color.Gray; // Neutral gray for subtle borders

        protected void ApplyGlobalStyles(Form parent)
        {
            this.BackColor = SecondaryColor;
            this.ForeColor = Color.Black;
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Panel pnl)
                {
                    pnl.BackColor = SecondaryColor;
                    pnl.BorderStyle = BorderStyle.None; // Flat style
                    pnl.Padding = new Padding(5);
                    pnl.Margin = new Padding(5);
                    pnl.AutoSize = true;
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
                    //grid.Height = 10000;

                    grid.DefaultCellStyle.BackColor = Color.White;
                    grid.DefaultCellStyle.ForeColor = PrimaryColor;
                    //grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(92, 184, 92);
                    //grid.DefaultCellStyle.SelectionForeColor = Color.White;
                    grid.DefaultCellStyle.Padding = new Padding(5);

                    grid.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                    grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    grid.EnableHeadersVisualStyles = false;

                    grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    grid.AlternatingRowsDefaultCellStyle.BackColor = AccentColor;
                    grid.ColumnHeadersHeight = 40;
                    grid.RowTemplate.Height = 40;

                    if (grid.Columns["DeleteCellButton"] is DataGridViewButtonColumn c)
                    {
                        c.FlatStyle = FlatStyle.Flat;
                        c.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (grid.Columns["UpdateCellButton"] is DataGridViewButtonColumn u)
                    {
                        u.FlatStyle = FlatStyle.Flat;
                        u.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
