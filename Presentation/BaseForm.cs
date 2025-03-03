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
            Color MainColor = ColorTranslator.FromHtml("#3D8D7A");
            this.BackColor = MainColor;
            this.ForeColor = Color.White;
            ApplyGlobalStyles(this);
        }

        private void ApplyGlobalStyles(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.ForeColor = this.ForeColor; // Apply global ForeColor
                ctrl.Font = this.Font; // Apply global Font

                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(60, 60, 60); // Default Button Color
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(80, 80, 80); // Hover Color
                    btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(60, 60, 60);
                }
                if (ctrl is DataGridView grid)
                {
                    grid.BackgroundColor = Color.FromArgb(60, 60, 60);
                    grid.ForeColor = Color.Beige;
                    grid.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                    grid.DefaultCellStyle.ForeColor = Color.White;
                    grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    grid.EnableHeadersVisualStyles = false;
                }

                // Recursively apply styles to nested controls (like panels, group boxes)
                if (ctrl.HasChildren)
                    ApplyGlobalStyles(ctrl);
            }
        }
    }
}
