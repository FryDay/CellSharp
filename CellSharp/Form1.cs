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
    public partial class Form1 : Form
    {

        #region "Properties"

        private Main Program;
        private Bitmap Bmp;
        private Graphics Gpx;
        private int CellSize = 5;
        private Color BackgroundColor;
        private Color GridColor;
        private Color CellColor;
        private Pen GridPen;
        private Brush CellBrush;

        #endregion

        #region "Constructors"

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region "Events"

        private void UpdateGridEvent(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CellColor = Color.Black;
            GridColor = Color.Black;
            BackgroundColor = Color.White;

            CellBrush = new SolidBrush(CellColor);
            GridPen = new Pen(GridColor);
            
            Initialize();
        }

        private void pix_Grid_MouseClick(object sender, MouseEventArgs e)
        {
            Cell newCell = new Cell(e.X / CellSize, e.Y / CellSize); //Todo: check that this works correctly

            if (Program.AddOrRemoveCell(newCell)) //If cell is added
            {
                DrawCells(Program.LivingCells);
            }
            else
            {
                if (chk_DrawGrid.Checked)
                    DrawGrid();
                else
                {
                    Gpx.Clear(BackgroundColor);
                    pix_Grid.Refresh();
                }

                DrawCells(Program.LivingCells);
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            Program = new Main((int)(txt_BirthMin.Value), (int)txt_BirthMax.Value, (int)txt_SurvivalMin.Value, (int)txt_SurvivalMax.Value, (int)txt_Iterations.Value, Program.LivingCells);
            Program.UpdateGridEvent += UpdateGridEvent;
            Program.LivingCells.UpdateCellCount();
            btn_Run.Enabled = false;
            btn_Stop.Enabled = true;

            timer.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            btn_Run.Enabled = true;
            btn_Stop.Enabled = false;
            Program.CurrentIteration = 0;
        }

        private void chk_DrawGrid_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void sldr_Speed_Scroll(object sender, EventArgs e)
        {
            switch (sldr_Speed.Value)
            {
                case 0:
                    timer.Interval = 250;
                    break;
                case 1:
                    timer.Interval = 125;
                    break;
                case 2:
                    timer.Interval = 50;
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!Program.Iterate())
            {
                timer.Enabled = false;
                btn_Run.Enabled = true;
                btn_Stop.Enabled = false;
            }
        }

        private void menu_Main_File_New_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void menu_Main_Tools_Colors_Click(object sender, EventArgs e)
        {
            ColorChangerForm colorForm = new ColorChangerForm(GridColor, CellColor, BackgroundColor);
            switch (colorForm.ShowDialog(this))
            {
                case DialogResult.OK:
                    GridColor = colorForm.GridColor;
                    CellColor = colorForm.CellColor;
                    BackgroundColor = colorForm.BackgroundColor;

                    RefreshColors();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        #endregion

        #region "Private"

        private void Initialize()
        {
            Program = new Main((int)(txt_BirthMin.Value), (int)txt_BirthMax.Value, (int)txt_SurvivalMin.Value, (int)txt_SurvivalMax.Value, (int)txt_Iterations.Value);

            //GUI checks
            chk_DrawGrid.Checked = true;
            chk_IncludeSelf.Checked = false;
            txt_Iterations.Value = 0;
            txt_BirthMin.Value = 3;
            txt_BirthMax.Value = 3;
            txt_SurvivalMin.Value = 2;
            txt_SurvivalMax.Value = 3;
            sldr_Speed.Value = 1;
            btn_Run.Enabled = true;
            btn_Stop.Enabled = false;

            //Grid Setup
            Program.UpdateGridEvent += UpdateGridEvent; //Allows grid to be updated via Main class.
            Bmp = new Bitmap(pix_Grid.Width, pix_Grid.Height);
            pix_Grid.Image = Bmp;
            Gpx = Graphics.FromImage(Bmp);
            Gpx.Clear(BackgroundColor);
            DrawGrid();
        }

        //Draws grid lines
        private void DrawGrid()
        {
            Gpx.Clear(BackgroundColor);
            for (int index = 0; index <= 110; index++)
            {
                Gpx.DrawLine(GridPen, 0, (index * CellSize), pix_Grid.Width, (index * CellSize));
                Gpx.DrawLine(GridPen, (index * CellSize), 0, (index * CellSize), pix_Grid.Height);
            }
        }

        private void UpdateGrid()
        {
            if (chk_DrawGrid.Checked)
                DrawGrid();
            else
                Gpx.Clear(BackgroundColor);

            DrawCells(Program.LivingCells);
        }

        //Draw cells
        private void DrawCells(Population livingCells)
        {
            foreach (Cell cell in livingCells.CellList)
                Gpx.FillRectangle(CellBrush, (cell.Location.X * CellSize), (cell.Location.Y * CellSize), CellSize, CellSize);
            
            pix_Grid.Refresh();
        }

        private void RefreshColors()
        {
            CellBrush = new SolidBrush(CellColor);
            GridPen = new Pen(GridColor);

            DrawGrid();
            DrawCells(Program.LivingCells);
        }

        #endregion

    }
}
