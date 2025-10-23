using System;
using System.Globalization;

namespace CalculadoraPrestamos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calculadora de Préstamos (cuota mensual)");

            decimal capital = ReadDecimal("Introduce el capital: ");

            decimal tasaAnualPercent = ReadDecimal("Introduce la tasa anual (%): ");

            int meses = ReadInt("Introduce el número de meses: ");

            if (meses <= 0)
            {
                Console.WriteLine("El número de meses debe ser mayor que 0.");
                return;
            }

            double tasaMensual = (double)(tasaAnualPercent / 100m) / 12.0;

            decimal cuota;
            if (Math.Abs(tasaMensual) < 1e-12)
            {
                cuota = decimal.Divide(capital, meses);
            }
            else
            {
                double i = tasaMensual;
                double n = meses;
                double factorPow = Math.Pow(1.0 + i, n);
                double cuotaDouble = (double)capital * (i * factorPow) / (factorPow - 1.0);
                cuota = Convert.ToDecimal(cuotaDouble);
            }

            Console.WriteLine();
            Console.WriteLine("Resultado:");
            Console.WriteLine($"Capital: {capital.ToString("N2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Tasa anual (%): {tasaAnualPercent.ToString("N4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Meses: {meses}");
            Console.WriteLine($"Cuota mensual: {cuota.ToString("N2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            Console.WriteLine("Pulsa 'ENTER' para salir...");
            Console.ReadLine();
        }

        static decimal ReadDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Entrada vacía. Intenta de nuevo.");
                    continue;
                }

                input = input.Replace(',', '.');

                if (decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal value))
                {
                    return value;
                }
                Console.WriteLine("Valor no válido. Usa un número.");
            }
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine()?.Trim() ?? "";
                if (int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value))
                {
                    return value;
                }
                Console.WriteLine("Número no válido. Introduce un entero.");
            }
        }
    }
}