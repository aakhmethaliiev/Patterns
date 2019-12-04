using System;

namespace BaristaApp
{
    internal class Program
    {
        private static void Main()
        {
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
