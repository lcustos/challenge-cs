using System;

namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            for (int i = tab?.Length - 1 ?? 0; i >= 0; i--) {
                if (a == tab?[i]) return i;
            }
            return null;
        }
    }
}