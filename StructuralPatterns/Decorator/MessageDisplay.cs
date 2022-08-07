// ˅

// ˄

namespace StructuralPatterns.Decorator
{
    public class MessageDisplay : Display
    {
        // ˅
        
        // ˄

        // Number of characters
        public override int Columns
        {
            // ˅
            get
            {
                return message.Length;
            }
            // ˄
        }

        // The number of rows is 1
        public override int Rows
        {
            // ˅
            get
            {
                return 1;
            }
            // ˄
        }

        // Message to be displayed
        private readonly string message;

        public MessageDisplay(string message)
            // ˅
            
            // ˄
        {
            // ˅
            this.message = message;
            
            // ˄
        }

        public override string GetLineText(int row)
        {
            // ˅
            if (row == 0)
            {
                return message;
            }
            else
            {
                return null;
            }
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
