using EjercicioExcepciones;

Operaciones operaciones = new();

try
{
    Console.Write("Ingrese el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double resultadoSuma = operaciones.Sumar(num1, num2);
    double resultadoResta = operaciones.Restar(num1, num2);
    double resultadoMultiplicacion = operaciones.Multiplicar(num1, num2);
    double resultadoDivision = operaciones.Dividir(num1, num2);

    Console.WriteLine($"Suma: {resultadoSuma}");
    Console.WriteLine($"Resta: {resultadoResta}");
    Console.WriteLine($"Multiplicación: {resultadoMultiplicacion}");
    Console.WriteLine($"División: {resultadoDivision}");
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese solo números.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}