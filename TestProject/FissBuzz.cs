using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class FizzBuzz
    {
        public void NameModuloNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                var sb = new StringBuilder();
                if (i % 3 == 0)
                {
                    sb.Append("Link");
                }
                if (i % 5 == 0)
                {
                    sb.Append("laters");
                }

                if (sb.Length > 0)
                {
                    Console.WriteLine($"{i} - {sb}");
                }
            }
        }
    }
}