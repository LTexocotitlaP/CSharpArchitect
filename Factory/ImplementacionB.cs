namespace Factory;

public class ImplementacionB:MyInterface
{
    public void mostrar(bool ipn, bool reglamento, string materia)
    {
        if (ipn == true)
        {
            if (reglamento == true)
            {
                
                Console.WriteLine("Materia: " + materia);
            }
            else
            {
                
                Console.WriteLine("Esta en reglamento: " + reglamento);
            }
        }
        else
        {
            
            Console.WriteLine("No es del IPN: " + ipn);
        }
    }
}