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
            this.history = new HistoryCommand();
            this.paintingCanvas = new PaintingCanvas(this.canvas);
            
            // ˄
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            // ˅
            paintingCanvas.Clear();
            history.Undo();
            history.Execute();
            // ˄
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // ˅
            paintingCanvas.Clear();
            history.Clear();
            // ˄
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // ˅
            if (e.Button == MouseButtons.Left)
            {
                PaintingCommand paintingCommand = new PaintingCommand(paintingCanvas, e.X, e.Y);
                history.Add(paintingCommand);
                paintingCommand.Execute();
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
