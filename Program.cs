using System;

namespace DiferençaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime lucas = new DateTime(1987,11,23);
            DateTime daiana = new DateTime(1990,03,01);

            CalcularIdade(lucas, daiana);
        }

        private static void CalcularIdade(DateTime pessoa1, DateTime pessoa2)
        {
            var diasPessoa1 = (int)pessoa1.Subtract(DateTime.Today).TotalDays;
            var diasPessoa2 = (int)pessoa2.Subtract(DateTime.Today).TotalDays;

            if (diasPessoa1 > diasPessoa2)
                Console.WriteLine($"{diasPessoa1 - diasPessoa2}");
            else
                Console.WriteLine($"{diasPessoa2 - diasPessoa1}");
        }
    }
}