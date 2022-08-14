using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ShokhovKP
{
    class PaintGraph
    {
        private PictureBox panel;
        private readonly int[,] matrix;
        private PointF[] pointNode;//координаты для построения вершин
        private Graphics graphics;//предоставление средств для рисования
        private readonly Bitmap bitmap;//хранение полного изображения графа
        private readonly int node;//Количество вершин

        public PaintGraph(PictureBox panel, int[,] matrix)
        {
            this.panel = panel;
            this.matrix = matrix;
            node = matrix.GetLength(0);
            bitmap = new Bitmap(this.panel.Width, this.panel.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        /// <summary>
        /// Нарисовать граф
        /// </summary>
        public void DrawGraph()
        {
            graphics.Clear(panel.BackColor);
            CalculatePointNodes();
            DrawEdges();
            DrawVerticles();
            panel.Image = bitmap;
        }

        public void DrawGraph(List<int> cliqueNodes)
        {
            List<int> clone = new List<int>();
            for (int i = 0; i < cliqueNodes.Count; i++)
                clone.Add(cliqueNodes[i] + 1);

            graphics.Clear(panel.BackColor);
            CalculatePointNodes();
            DrawEdges(clone);
            DrawVerticles(clone);
            panel.Image = bitmap;
        }

        /// <summary>
        /// Найти координаты для построения вершин на области для рисования
        /// </summary>
        private void CalculatePointNodes()
        {
            pointNode = new PointF[node];
            double degree = 360.0 / node, d = 0;
            Point xy = new Point(panel.Width / 2 - 12, panel.Height / 2 - 15);
            Point x0y0 = new Point(panel.Width - 40, panel.Height / 2 - 15);
            Point rxry = new Point((x0y0.X - xy.X), (x0y0.Y - xy.Y));
            for (int i = 0; i < node; i++, d += degree)
            {
                double cos = Math.Cos((Math.PI / 180) * d),
                       sin = Math.Sin((Math.PI / 180) * d),
                       tmps = (xy.X + rxry.X * cos - rxry.Y * sin),
                       tmp1 = (xy.Y + rxry.X * sin + rxry.Y * cos);
                Point x1y1 = new Point((int)tmps, (int)tmp1);
                pointNode[i] = new Point(x1y1.X, x1y1.Y);
            }
        }

        /// <summary>
        /// Нарисовать ребра
        /// </summary>
        private void DrawEdges()
        {
            Point xy;//точка для стрелки
            Pen pen_for_lines = new Pen(Color.Gray);//установка стиля линиий           
            pen_for_lines.EndCap = LineCap.ArrowAnchor;
            pen_for_lines.CustomEndCap = new AdjustableArrowCap(6, 11);//установка формы стрелки

            for (int i = 0; i < node; i++)
                for (int j = 0; j < node; j++)
                    if (matrix[i, j] != 0)
                    {
                        if (matrix[j, i] == 0)
                        {
                            xy = new Point((int)((pointNode[i].X + pointNode[j].X) / 2),
                                           (int)((pointNode[i].Y + pointNode[j].Y) / 2));
                            graphics.DrawLine(pen_for_lines, 
                                              pointNode[i].X + 12, 
                                              pointNode[i].Y + 12, 
                                              xy.X + 12, 
                                              xy.Y + 12);
                            graphics.DrawLine(Pens.Gray, 
                                              xy.X + 12, 
                                              xy.Y + 12, 
                                              pointNode[j].X + 12, 
                                              pointNode[j].Y + 12);
                        }
                        graphics.DrawLine(Pens.Gray, pointNode[i].X + 12, pointNode[i].Y + 12, pointNode[j].X + 12, pointNode[j].Y + 12);

                        graphics.DrawLine(Pens.Gray,
                                          pointNode[i].X + 12,
                                          pointNode[i].Y + 12,
                                          pointNode[j].X + 12,
                                          pointNode[j].Y + 12);
                    }
                        
        }

        private void DrawEdges(List<int> cliqueNodes)
        {
            DrawEdges();
            for (int i = 0; i < cliqueNodes.Count; i++)
            {
                for (int j = 0; j < cliqueNodes.Count; j++)
                {
                    if (cliqueNodes[i] != cliqueNodes[j])
                    {
                        graphics.DrawLine(Pens.LimeGreen,
                            pointNode[cliqueNodes[i] - 1].X + 12, pointNode[cliqueNodes[i] - 1].Y + 12,
                            pointNode[cliqueNodes[j] - 1].X + 12, pointNode[cliqueNodes[j] - 1].Y + 12);
                    }
                }
            }
        }

        /// <summary>
        /// Нарисовать вершины
        /// </summary>
        private void DrawVerticles()
        {
            for (int i = 0; i < node; i++)
            {
                Font font = new Font("Tahoma", 9f);
                Color colorForVerticle = Color.Tomato;
                graphics.FillEllipse(new SolidBrush(colorForVerticle), pointNode[i].X, pointNode[i].Y, 25, 25);
                var x = (i < 9) ? pointNode[i].X + 8 : pointNode[i].X + 4;
                graphics.DrawString((i + 1).ToString(), font, Brushes.GhostWhite, x, pointNode[i].Y + 5);
            }
        }
        private void DrawVerticles(List<int> cliqueNodes)
        {
            Font font = new Font("Tahoma", 9f);
            for (int i = 0, counter = 0; i < matrix.GetLength(0); i++)
            {
                Color colorForVerticle;
                if (counter < (cliqueNodes.Count) && i == (cliqueNodes[counter] - 1))
                {
                    int node = cliqueNodes[counter];
                    colorForVerticle = Color.Orange;
                    graphics.FillEllipse(new SolidBrush(colorForVerticle), pointNode[node - 1].X, pointNode[node - 1].Y, 25, 25);
                    var x = (node < 9) ? pointNode[node - 1].X + 8 : pointNode[node - 1].X + 4;
                    graphics.DrawString((node).ToString(), font, Brushes.Purple, x, pointNode[node - 1].Y + 5);
                    counter++;
                }
                else
                {
                    colorForVerticle = Color.LightSeaGreen;
                    graphics.FillEllipse(new SolidBrush(colorForVerticle), pointNode[i].X, pointNode[i].Y, 25, 25);
                    var x = (i < 9) ? pointNode[i].X + 8 : pointNode[i].X + 4;
                    graphics.DrawString((i + 1).ToString(), font, Brushes.GhostWhite, x, pointNode[i].Y + 5);
                }
            }
        }
    }
}
