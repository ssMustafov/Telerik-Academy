using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | 
        AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Enum, 
        AllowMultiple = false)]
    public class VersionAttribute : System.Attribute
    {
        public double Version { get; private set; }

        public VersionAttribute(double version)
        {
            this.Version = version;
        }
    }
    
    [Version(2.11)]
    class Attributes
    {
        static void Main(string[] args)
        {
            Type type = typeof(Attributes);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine("Class version: {0}", attribute.Version);
            }
        }
    }
}
