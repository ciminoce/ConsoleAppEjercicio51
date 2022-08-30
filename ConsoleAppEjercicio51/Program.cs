using System;

namespace ConsoleAppEjercicio51
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, nrosEntre10y15 = 0, menoresA7 = 0;
            Random r = new Random();
            for (int contador = 1; contador <= 15; contador++)
            {
                var nroGenerado = r.Next(1, 21);
                Console.WriteLine($"{nroGenerado}");
                suma += nroGenerado;
                if (nroGenerado>=10 && nroGenerado<=15)
                {
                    nrosEntre10y15++;
                }else if (nroGenerado < 7)
                {
                    menoresA7++;
                }
                
            }

            Console.WriteLine($"Cantidad de nros entre 10 y 15: {nrosEntre10y15}");
            Console.WriteLine($"Cantidad de nros menores a 7: {menoresA7}");
            Console.WriteLine($"La suma de nros generados es {suma}");
        }
    }
}
