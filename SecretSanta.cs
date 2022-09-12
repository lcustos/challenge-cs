using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string, string> SecretSantaDraw(HashSet<string> people)
        {
            Random rnd = new Random();
            var result = new Dictionary<string, string>();
            var array1 = people.ToArray().OrderBy(x => rnd.Next()).ToArray();

            foreach (var currentElement in people)
            {
                while (currentElement == array1[0])
                {
                    array1 = array1.ToArray().OrderBy(x => rnd.Next()).ToArray();
                }

                result[currentElement] = array1[0];
                array1 = array1.Where(x => x != array1[0]).ToArray();
            }
            return result;
        }
    }
}