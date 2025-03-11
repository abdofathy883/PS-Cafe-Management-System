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
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            Color mainColor = ColorTranslator.FromHtml("#3D8D7A");
            this.BackColor = mainColor;
            this.ForeColor = Color.White;
            //this.ControlAdded += (s, e) => ApplyGlobalStyles(e.Control);
            ApplyGlobalStyles(this);
        }

        private void ApplyGlobalStyles(Form parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                    if (ctrl.Tag?.ToString() == "Styled") continue; // Avoid re-styling

                    ctrl.ForeColor = this.ForeColor;
                    ctrl.Font = this.Font;
                    ctrl.Tag = "Styled"; // Mark as styled

                    if (ctrl is Button btn)
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.FromArgb(66, 133, 244);
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        btn.Cursor = Cursors.Hand;
                        btn.Padding = new Padding(8, 4, 8, 4);

                        // Clear existing event handlers
                        btn.MouseEnter -= ButtonHoverEnter;
                        btn.MouseLeave -= ButtonHoverLeave;
                        btn.MouseDown -= ButtonMouseDown;
                        btn.MouseUp -= ButtonMouseUp;

                        // Add hover and click effects
                        btn.MouseEnter += ButtonHoverEnter;
                        btn.MouseLeave += ButtonHoverLeave;
                        btn.MouseDown += ButtonMouseDown;
                        btn.MouseUp += ButtonMouseUp;
                    }
                    else if (ctrl is DataGridView grid)
                    {
                        grid.BorderStyle = BorderStyle.None;
                        grid.BackgroundColor = Color.FromArgb(240, 240, 240);
                        grid.AllowUserToAddRows = false;
                        grid.AllowUserToResizeRows = false;
                        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        grid.RowHeadersVisible = false;
                        grid.GridColor = Color.FromArgb(200, 200, 200);

                        grid.DefaultCellStyle.BackColor = Color.White;
                        grid.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(92, 184, 92);
                        grid.DefaultCellStyle.SelectionForeColor = Color.White;
                        grid.DefaultCellStyle.Padding = new Padding(5);

                        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(66, 133, 244);
                        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                        grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
                        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                        grid.EnableHeadersVisualStyles = false;

                        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
                        grid.ColumnHeadersHeight = 40;
                    }

                    // Recursively apply styles to nested controls
                    //if (ctrl.HasChildren)
                    //    ApplyGlobalStyles(ctrl);
                }
            }
        

    // Button Events
    private void ButtonHoverEnter(object sender, EventArgs e)
        => ((Button)sender).BackColor = Color.FromArgb(50, 100, 200);

        private void ButtonHoverLeave(object sender, EventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(66, 133, 244);

        private void ButtonMouseDown(object sender, MouseEventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(30, 90, 160);

        private void ButtonMouseUp(object sender, MouseEventArgs e)
            => ((Button)sender).BackColor = Color.FromArgb(66, 133, 244);
    }
}
