namespace Trasformaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point[] Poligono;
        private Graphics g;//Dibujando sobre nuestro plano 
        private int cX, cY;
        private void plano_Paint(object sender, PaintEventArgs e)
        {
            Pen pluma = new Pen(Color.Black);
            Font f = new Font("Arial", 8);
            Brush b = Brushes.Black;
            g = e.Graphics;


            //Nuevo punto de origen
            cX = plano.Width / 2;
            cY = plano.Height / 2;

            g.DrawLine(pluma, 0, cY, plano.Width, cY);
            g.DrawLine(pluma, cX, 0, cX, plano.Height);

            for (int i = -10; i <= 10; i++)
            {
                int x = cX + i * 20;
                int y = cY - i * 20;

                g.DrawString(i.ToString(), f,b,new Point(x,cY));
                g.DrawString(i.ToString(), f, b,new Point(cX,y));
            }

            g = plano.CreateGraphics();
        }

        private void btnPoligono_Click(object sender, EventArgs e)
        {
            Poligono = new Point[] {
                new Point(-4,2),
                new Point(4,2),
                new Point(0,10)
                };

            for (int i = 0; i < Poligono.Length; i++)
            {
                Poligono[i].X = Poligono[i].X *20 + cX;
                Poligono[i].Y = (Poligono [i].Y * -1 )*20 + cY;
            }

            g.DrawPolygon(new Pen(Color.Blue), Poligono);
        }
    }
}
