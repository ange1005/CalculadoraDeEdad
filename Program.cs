using System;

class CalcularadoraDeEdad
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Bienvenido al sistema de calcula de edad.");
        Console.WriteLine("Por favor, ingrese su Nombre completo: ");
        String Nombre = Console.ReadLine();
        Console.Write("Por favor, ingrese su Edad: ");
        int Edad = Convert.ToInt32(Console.ReadLine());

        
        int meses = Edad * 12;
        double dias = Edad * 365;
        double horas = dias * 24;

        
        Console.WriteLine($"Hola {Nombre}, tu edad en meses es: {meses} meses. Ya estas grandesit@");
        Console.WriteLine($"Hola {Nombre}, tu edad en días es: {dias:F2} días. Ya dias va usted"); 
        Console.WriteLine($"Hola {Nombre}, tu edad en horas es: {horas:F2} horas."); 
    }
}
