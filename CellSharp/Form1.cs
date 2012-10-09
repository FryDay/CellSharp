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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program = new Main();
            Bmp = new Bitmap(pix_Grid.Width, pix_Grid.Height);
            pix_Grid.Image = Bmp;
            Gpx = Graphics.FromImage(Bmp);

            Gpx.Clear(Color.White);
            DrawGrid();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            Program = new Main((int)(txt_BirthMin.Value), (int)txt_BirthMax.Value, (int)txt_SurvivalMin.Value, (int)txt_SurvivalMax.Value);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Program.Iterate();
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
