using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CellSharp
{
    public partial class ColorChangerForm : Form
    {
        public Color GridColor { get; set; }
        public Color CellColor { get; set; }
        public Color BackgroundColor { get; set; }

        public ColorChangerForm(Color gridColor, Color cellColor, Color backgroundColor)
        {
            InitializeComponent();
            GridColor = gridColor;
            CellColor = cellColor;
            BackgroundColor = backgroundColor;

            GridColorDialog.Color = gridColor;
            CellColorDialog.Color = cellColor;
            BackColorDialog.Color = backgroundColor;

            btn_GridColor.BackColor = gridColor;
            btn_CellsColor.BackColor = cellColor;
            btn_BackColor.BackColor = backgroundColor;
        }

        private void btn_GridColor_Click(object sender, EventArgs e)
        {
            if (GridColorDialog.ShowDialog() == DialogResult.OK)
            {
                GridColor = GridColorDialog.Color;
                btn_GridColor.BackColor = GridColorDialog.Color;
            }
        }

        private void btn_CellsColor_Click(object sender, EventArgs e)
        {
            if (CellColorDialog.ShowDialog() == DialogResult.OK)
            {
                CellColor = CellColorDialog.Color;
                btn_CellsColor.BackColor = CellColorDialog.Color;
            }
        }

        private void btn_BackColor_Click(object sender, EventArgs e)
        {
            if (BackColorDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = BackColorDialog.Color;
                btn_BackColor.BackColor = BackColorDialog.Color;
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
