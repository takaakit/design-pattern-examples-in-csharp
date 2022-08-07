// ˅

// ˄

namespace StructuralPatterns.Proxy
{
    // ProxyPrinter forwards requests to RealPrinter when appropriate.
    public class ProxyPrinter : IPrinter
    {
        // ˅
        
        // ˄

        private string currentName;

        // A printer that actually prints
        private RealPrinter real;

        public ProxyPrinter(string name)
            // ˅
            
            // ˄
        {
            // ˅
            currentName = name;
            real = null;
            
            // ˄
        }

        public string GetName()
        {
            // ˅
            if (real != null)
            {
                return real.GetName();
            }
            else
            {
                return currentName;
            }
            // ˄
        }

        public void ChangeName(string name)
        {
            // ˅
            if (real != null)
            {
                real.ChangeName(name);
            }
            
            currentName = name;
            // ˄
        }

        public void Output(string content)
        {
            // ˅
            // Check to see if the RealPrinter had been created, create it if necessary.
            if (real == null)
            {
                real = new RealPrinter(currentName);
            }
            
            real.Output(content);
            // ˄
        }

        // ˅
        
        // ˄
    }
}

// ˅

// ˄
