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
    public partial class BaseForm: Form
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
                if (ctrl is Button btn)
                {
                    //btn.BackColor = PrimaryColor;
                    //btn.ForeColor = Color.White;
                    //btn.AutoSize = true;
                    ////btn.ClientSize = new Size(100, 45);

                    //btn.FlatStyle = FlatStyle.Flat;
                    //btn.FlatAppearance.BorderSize = 0;
                    ////btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    //btn.Cursor = Cursors.Hand;
                    ////btn.Padding = new Padding(5);

                }
                else if (ctrl is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = PrimaryColor;
                    txt.BorderStyle = BorderStyle.None; // Flat style
                    txt.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    txt.Padding = new Padding(4);
                    txt.AutoSize = false;
                    txt.Height = 25;
                }
                else if (ctrl is NumericUpDown num)
                {
                    num.BackColor = Color.White;
                    num.ForeColor = PrimaryColor;
                    num.BorderStyle = BorderStyle.None; // Flat style
                    num.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    //num.AutoSize = false;
                    num.Height = 15;
                }
                else if (ctrl is ComboBox cmb)
                {
                    cmb.BackColor = Color.White;
                    cmb.ForeColor = PrimaryColor;
                    cmb.FlatStyle = FlatStyle.Flat; // Flat style
                    cmb.Font = new Font("Segoe UI", 12);
                    //cmb.Padding = new Padding(4);
                    cmb.Height = 10;
                }
                else if (ctrl is Label lbl)
                {
                    //lbl.ForeColor = Color.White;
                    //lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }
                else if (ctrl is Panel pnl)
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
                    grid.BackgroundColor = AccentColor; //Color.FromArgb(240, 240, 240);
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
                        //c.DefaultCellStyle.BackColor = PrimaryColor;
                    }
                    if (grid.Columns["UpdateCellButton"] is DataGridViewButtonColumn u)
                    {
                        u.FlatStyle = FlatStyle.Flat;
                        u.DefaultCellStyle.ForeColor = Color.White;
                        //c.DefaultCellStyle.BackColor = PrimaryColor;
                    }
                    
                    
                }
                //else if (ctrl is DateTimePicker DTP)
                //{
                //    DTP.CalendarForeColor = PrimaryColor;
                //    DTP.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                //    DTP.CalendarForeColor = PrimaryColor;
                //    //DTP.CalendarMonthBackground = UIColors.SecondaryColor;
                //    //DTP.CalendarTitleBackColor = UIColors.PrimaryColor;
                //    DTP.CalendarTitleForeColor = PrimaryColor;
                //    DTP.CalendarTrailingForeColor = Color.Gray;

                //    // Apply Flat Styling
                //    DTP.BackColor = BackgroundColor;
                //    DTP.ForeColor = PrimaryColor;
                //    DTP.ShowUpDown = false;  // Hide arrows if needed
                //    DTP.Width = 500;

                //    // Custom Border - Use Panel Trick (since DateTimePicker does not allow border changes)
                //}
            }
        }
    }
}
