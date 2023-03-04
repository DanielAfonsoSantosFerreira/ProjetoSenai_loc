using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenai
{
    class PainelArredondado : Panel
    {
        //Campos de seleção
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //Construtor

        public PainelArredondado()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }

        //Propriedades do Painel 

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }

        public Color GradientTopColor
        {
            get
            {
                return gradientTopColor;
            }

            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }

        public Color GradientBottomColor
        {
            get
            {
                return gradientBottomColor;
            }

            set
            {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }

        //Métodos
        private GraphicsPath GetPainelArredondado(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        //Metódos substituídos
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //gradiente
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushPainel = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.GradientAngle);
            Graphics graphicsPainel = e.Graphics;
            graphicsPainel.FillRectangle(brushPainel, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetPainelArredondado(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);

                }
            }
            else this.Region = new Region(rectangleF);
        }
    }
}
