namespace CSharpDiscovery.Quest01
{
    public class IsOdd_Exercice
    {
        public static bool IsOdd(int a)
        {
            if ((a & 1) == 0)
            {
                return true;
            }

            return false;
        }

    }
}