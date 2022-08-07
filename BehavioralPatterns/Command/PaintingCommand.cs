// ˅

// ˄

namespace BehavioralPatterns.Command
{
    // Command to paint a single point
    public class PaintingCommand : ICommand
    {
        // ˅
        
        // ˄

        // Painting position x
        private readonly double paintingPosX;

        // Painting position y
        private readonly double paintingPosY;

        private IPaintingTarget paintingTarget;

        public PaintingCommand(IPaintingTarget paintingTarget, double paintingPosX, double paintingPosY)
            // ˅
            
            // ˄
        {
            // ˅
            this.paintingPosX = paintingPosX;
            this.paintingPosY = paintingPosY;
            this.paintingTarget = paintingTarget;
            
            // ˄
        }

        public void Execute()
        {
            // ˅
            paintingTarget.Paint(paintingPosX, paintingPosY);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
