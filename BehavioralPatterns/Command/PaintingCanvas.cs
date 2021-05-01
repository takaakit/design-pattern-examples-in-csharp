// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

// ˄

namespace BehavioralPatterns.Command
{
    public class PaintingCanvas : IPaintingTarget
    {
        // ˅
        
        // ˄

        private readonly Brush PAINTING_COLOR;

        // Radius of the painting point
        private readonly int POINT_RADIUS;

        private readonly PictureBox pictureBox;

        public PaintingCanvas(PictureBox pictureBox)
            // ˅
            
            // ˄
        {
            // ˅
            this.PAINTING_COLOR = Brushes.LightGreen;
            this.POINT_RADIUS = 20;
            this.pictureBox = pictureBox;
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            // ˄
        }

        public void Paint(double x, double y)
        {
            // ˅
            var bm = new Bitmap(pictureBox.Image);
            var g = Graphics.FromImage(bm);
            g.FillEllipse(PAINTING_COLOR, new Rectangle(
                (int)(x - (POINT_RADIUS * 0.5)),
                (int)(y - (POINT_RADIUS * 0.5)),
                POINT_RADIUS,
                POINT_RADIUS));
            g.Dispose();
            pictureBox.Image = bm;
            // ˄
        }

        public void Clear()
        {
            // ˅
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
