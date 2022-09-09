using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            string concat = "";
            for (int i = 0; i < str.Length; i++)
            {
                concat += str[i];
            }

            return concat;
        }
    }
}