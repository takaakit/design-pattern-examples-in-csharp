// ˅
using CreationalPatterns.AbstractFactory.Factory;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.ListFactory
{
    public class ListData : Data
    {
        // ˅
        
        // ˄

        public ListData(string name)
            // ˅
            : base(name)
            // ˄
        {
            // ˅
            
            // ˄
        }

        public override string ToHTML()
        {
            // ˅
            StringBuilder builder = new StringBuilder();
            builder.Append($"<li>{name}<ul>\n");
            foreach (Item item in items)
            {
                builder.Append(item.ToHTML());
            }
            builder.Append("</ul></li>\n");
            return builder.ToString();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
