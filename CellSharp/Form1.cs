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
            Program = new Main((int)(txt_BirthMin.Value), (int)txt_BirthMax.Value, (int)txt_SurvivalMin.Value, (int)txt_SurvivalMax.Value, (int)txt_Iterations.Value);
            Program.UpdateGridEvent += UpdateGridEvent;
            Bmp = new Bitmap(pix_Grid.Width, pix_Grid.Height);
            pix_Grid.Image = Bmp;
            Gpx = Graphics.FromImage(Bmp);

            Gpx.Clear(Color.White);
            DrawGrid();
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
                    Gpx.Clear(Color.White);
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
                case 3:
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

        #endregion

        #region "Public"

        public void UpdateGrid()
        {
            if (chk_DrawGrid.Checked)
                DrawGrid();
            else
                Gpx.Clear(Color.White);

            DrawCells(Program.LivingCells);
        }

        #endregion

        #region "Private"

        //Draws grid lines
        private void DrawGrid()
        {
            Gpx.Clear(Color.White);
            for (int index = 0; index <= 110; index++)
            {
                Gpx.DrawLine(Pens.Black, 0, (index * CellSize), pix_Grid.Width, (index * CellSize));
                Gpx.DrawLine(Pens.Black, (index * CellSize), 0, (index * CellSize), pix_Grid.Height);
            }
        }

        //Draw cells
        private void DrawCells(Population livingCells)
        {
            foreach (Cell cell in livingCells.CellList)
                Gpx.FillRectangle(Brushes.Black, (cell.XPos * CellSize), (cell.YPos * CellSize), CellSize, CellSize);

            pix_Grid.Refresh();
        }

        #endregion

    }
}
