using System;
using System.Text;

namespace Para.Extension
{
    public static class ExtensionMethods
    {
        public static string DeleteApostrophe(this string argument, Func<char, char> changer)
        {
            StringBuilder result = new StringBuilder();
            foreach (var znak in argument.ToCharArray())
            {
                result.Append(changer(znak));
            }

            return result.ToString();
        }

        public static string GetTypeName(this object o)
        {
            return o.GetType().FullName;
        }
    }
}
