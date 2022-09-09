namespace CSharpDiscovery.Quest01
{
    public class SpellItBackwards_Exercice
    {
        public static string SpellItBackward(string str)
        {
            var length = str.Length;
            string reverse = "";
            for (int i = 0; i < length; i++)
            {
                reverse = str.Substring(0, 1) + reverse;
                str = str.Remove(0, 1);
            }

            return reverse;
        }
    }
}