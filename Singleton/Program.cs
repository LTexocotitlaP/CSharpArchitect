namespace Singleton;

/*
 *
 * Autor: Texocotitla Pinzon Leo Francisco
 * Fecha: 2/26/2025
 * Ultima ejecucion: 2/28/2025
 *
 */


public class Program {
    //Metodo main
    public static void Main(string[] args)
    {
        NuevoSingleton singleton = NuevoSingleton.getInstance();
        NuevoSingleton singleton2 = NuevoSingleton.getInstance();
        // Evaluacion de si se uso la misma instancia 
        if (singleton == singleton2)
        {
            Console.WriteLine("Se uso una sola instancia");
        }
    }
}