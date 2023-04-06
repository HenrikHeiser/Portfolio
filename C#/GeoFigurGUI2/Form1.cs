﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoFigurGUI2 
{
    public partial class Form1 : Form 
    {

        List<GeoFigur> geoFigures = new List<GeoFigur>();
        public Form1() 
        {
            InitializeComponent();
            this.Text = "GeoFigur";
            int maxX = 500, maxY = 400, offset=20;
            canvas.ClientSize = new Size(maxX,maxY);
            //this.BackColor = Color.White; canvas.BackColor = Color.White;
            this.groupBoxCanvas.ClientSize = new Size(maxX + offset, maxY + offset);
            this.ClientSize = new System.Drawing.Size(groupBoxCanvas.ClientSize.Width+offset, groupBoxCanvas.ClientSize.Height+offset);
            InitializeGeoFigures();
            timer1.Start();

        }

        private void InitializeGeoFigures() 
        {

            Kreis f1 = new Kreis(50,Brushes.Red);
            f1.SetX(200); f1.SetY(100);
            Quadrat f2 = new Quadrat(50, Brushes.Blue);
            f2.SetX(100); f2.SetY(200);
            Rechteck f3 = new Rechteck(100, 50, Brushes.Yellow);
            f3.SetX(200); f3.SetY(200);
            Kreis f4 = new Kreis(50, Brushes.Green);
            f4.SetX(100); f4.SetY(100);
            geoFigures.AddRange(new GeoFigur[]{ f1, f2, f3, f4 });
            
        }

        private void canvas_Paint(object sender, PaintEventArgs e) 
        {
          foreach(GeoFigur figure in geoFigures) 
            {
                figure.Paint(e.Graphics);
            }
        }

        public static void DrawCircle(Graphics g, Brush brush,
                               float centerX, float centerY, float radius) {
            g.DrawEllipse(new Pen(brush), centerX - radius, centerY - radius,
                          radius, radius);
        }

        public static void FillCircle(Graphics g, Brush brush,
                                      float centerX, float centerY, float radius) 
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius, radius);
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            Console.WriteLine("Hallo Timer");
            //this.canvas.Invalidate(); //zeichnet die Form neu
        }
    }
}
