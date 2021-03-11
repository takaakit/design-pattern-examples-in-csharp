// ˅
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// ˄

namespace BehavioralPatterns.Command
{
    public partial class AppMain : Form
    {
        // ˅
        
        // ˄

        // Painting history
        private readonly HistoryCommand history;

        private readonly PaintingCanvas paintingCanvas;

        public AppMain()
            // ˅
            
            // ˄
        {
            // ˅
            InitializeComponent();

            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            this.history = new HistoryCommand();
            this.paintingCanvas = new PaintingCanvas(this.pictureBox);
            // ˄
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            paintingCanvas.Clear();
            history.Undo();
            history.Execute();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            paintingCanvas.Clear();
            history.Clear();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PaintingCommand paintingCommand = new PaintingCommand(paintingCanvas, e.X, e.Y);
                history.Add(paintingCommand);
                paintingCommand.Execute();
            }
        }

        // ˅

        // ˄
    }
}

// ˅

// ˄
