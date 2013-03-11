namespace ExtensionMethodSubstring
{
    using System;
    using System.Text;

    public class ExtensionsTest
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Hello, world!");
            Console.WriteLine(sb.Substring(0, 5));

            // Extension method can be called from an application by using this syntax:
            StringBuilder subString = sb.Substring(7, 5);
            Console.WriteLine(subString);
        }
    }
}
