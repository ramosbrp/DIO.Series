using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie eu = new Serie(01, Genero.Acao, "Muito bom", "bem legal", 2020 );

            Console.WriteLine(eu);
            

        }
    }
}
