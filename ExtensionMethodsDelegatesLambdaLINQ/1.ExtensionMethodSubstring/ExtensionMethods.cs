using System;
using System.Text;

// Extension methods give us a possibility to "add" methods to existing types without creating a new derived type,
// recompiling, or otherwise modifying the original type;
namespace ExtensionMethodSubstring
{
    public static class Extensions
    {
        // Extension methods are a special kind of static method, 
        // but they are called as if they were instance methods on the extended type;
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString(index, length));
        }
    }
}
