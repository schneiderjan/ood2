using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitial_cirite
{
    public partial class Form1 : Form
    {
        //Grid thisGrid = new Grid();
        public Form1()
        {
            InitializeComponent();
            //thisGrid.Origin = new Point(10, 10);
            //thisGrid.GridCellSize = new Size(40, 50);
            //thisGrid.HorizontalCells = 6;
            //thisGrid.VerticalCells = 25;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //Pen myPen = new Pen(Color.Blue, 2f);
            //myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            //myPen.DashCap = System.Drawing.Drawing2D.DashCap.Triangle;
            //thisGrid.Draw(e.Graphics, myPen);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            TableLayoutRowStyleCollection styles =
             this.tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in styles)
            {
                if (style.SizeType == SizeType.Absolute)
                {
                    style.SizeType = SizeType.AutoSize;
                }
                else if (style.SizeType == SizeType.AutoSize)
                {
                    style.SizeType = SizeType.Percent;

                    // Set the row height to be a percentage 
                    // of the TableLayoutPanel control's height.
                    style.Height = 20;
                }
                else
                {

                    // Set the row height to 50 pixels.
                    style.SizeType = SizeType.Absolute;
                    style.Height = 50;
                }
            }
            Invalidate();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
