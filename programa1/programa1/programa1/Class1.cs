
using System;

class Socio
{
    private string nombre;
    private int antiguedad;

    public Socio()
    {
        Console.Write("Ingrese el nombre del socio: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese la antigüedad del socio en años: ");
        while (!int.TryParse(Console.ReadLine(), out antiguedad) || antiguedad < 0)
        {
            Console.WriteLine("La antigüedad debe ser un número entero positivo. Inténtelo nuevamente.");
            Console.Write("Ingrese la antigüedad del socio en años: ");
        }
    }

    public string Nombre { get { return nombre; } }
    public int Antiguedad { get { return antiguedad; } }
}

class Club
{
    private Socio socio1;
    private Socio socio2;
    private Socio socio3;

    public Club()
    {
        Console.WriteLine("Ingrese la información para los tres socios:");
        socio1 = new Socio();
        socio2 = new Socio();
        socio3 = new Socio();
    }

    public void ImprimirSocios()
    {
        Console.WriteLine("\nInformación de los socios:");
        ImprimirSocio(socio1);
        ImprimirSocio(socio2);
        ImprimirSocio(socio3);
    }

    public void ImprimirSocioConMayorAntiguedad()
    {
        Socio socioConMayorAntiguedad = ObtenerSocioConMayorAntiguedad();
        Console.WriteLine($"\nEl socio con mayor antigüedad en el club es: {socioConMayorAntiguedad.Nombre}");
        ImprimirSocio(socioConMayorAntiguedad);
    }

    private Socio ObtenerSocioConMayorAntiguedad()
    {
        Socio socioConMayorAntiguedad = socio1;

        if (socio2.Antiguedad > socioConMayorAntiguedad.Antiguedad)
        {
            socioConMayorAntiguedad = socio2;
        }

        if (socio3.Antiguedad > socioConMayorAntiguedad.Antiguedad)
        {
            socioConMayorAntiguedad = socio3;
        }

        return socioConMayorAntiguedad;
    }

    private void ImprimirSocio(Socio socio)
    {
        Console.WriteLine($"Nombre: {socio.Nombre}, Antigüedad: {socio.Antiguedad} años");
    }
}

class Program
{
    static void Main()
    {
        Club miClub = new Club();
        miClub.ImprimirSocios();
        miClub.ImprimirSocioConMayorAntiguedad();
    }
}
