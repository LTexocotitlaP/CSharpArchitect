namespace Factory;

public class ImplementacionA:MyInterface
{
    public void mostrar(bool ipn, bool reglamento, string materia)
    {
        Console.WriteLine("Es del IPN: " + ipn);
        Console.WriteLine("Esta en reglamento: " + reglamento);
        Console.WriteLine("Materia: " + materia);
    }
}