using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlittchModel
{
    public partial class ModelView : Form
    {
        private const int scale = 3;
        private const int x_offset = 250;
        private const int y_offset = 100;

        private List<Link> Coxas = new List<Link>();

        public ModelView()
        {
            InitializeComponent();

            for(int i = 0; i < 3; i++)
            {
                int y_spacing = 95 * scale;
                int x_spacing = 130 * scale;

                Coxas.Add(new Link(new Point(x_offset + 20 * scale, y_offset + 20 * scale + i * y_spacing), -40 * scale));
                Coxas.Add(new Link(new Point(x_offset + 20 * scale + x_spacing, y_offset + 20 * scale + i * y_spacing), 40 * scale));
            }
        }

        private void ModelView_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            DrawBody(e);
        }

        private void DrawBody(System.Windows.Forms.PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 2);
            Rectangle bodyOutline = new Rectangle(250, 100, 170 * scale, 230 * scale);

            e.Graphics.DrawRectangle(blackPen, bodyOutline);

            foreach (Link l in Coxas)
                DrawCoxa(l, e);

            blackPen.Dispose();
        }

        private void DrawCoxa(Link l, System.Windows.Forms.PaintEventArgs e)
        {
            Pen greenPen = new Pen(Color.Green, 2);
            e.Graphics.DrawLine(greenPen, l.CenterOfRotation, l.EndPoint);

            greenPen.Dispose();
        }
    }
}
