// ˅
using CreationalPatterns.AbstractFactory.Factory;
using System.Text;

// ˄

namespace CreationalPatterns.AbstractFactory.TableFactory
{
    public class TableData : Data
    {
        // ˅
        
        // ˄

        public TableData(string name)
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
            builder.Append("<td><table width=\"100%\" border=\"2\">\n");
            builder.Append($"<tr><td bgcolor=\"#00CC00\" align=\"center\" colspan=\"{items.Count}\"><b>{name}</b></td></tr>\n");
            builder.Append("<tr>\n");
            foreach (Item item in items)
            {
                builder.Append(item.ToHTML());
            }
            builder.Append("</tr>\n");
            builder.Append("</table></td>\n");
            return builder.ToString();
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
