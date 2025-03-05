/*
 *
 * Autor: Texocotitla Pinzon Leo Francisco
 * Fecha: 2/26/2025
 * Ultima ejecucion: 2/28/2025
 * 
 */


using Factory;

public class Application
{
    public static void Main(string[] args)
    {
        // Se usa la interfaz como tipo de dato para la instanciacion del objeto y se construye con la clase ImplementacionA
        MyInterface primeraImplementacion = new ImplementacionA();
        primeraImplementacion.mostrar(true, false, "Ingenieria de diseno");
        
        Console.WriteLine(); // Esto agrega una línea vacía entre las implementaciones.
        
        // Se usa la interfaz como tipo de dato para la instanciacion del objeto y se construye con la clase ImplementacionB
        MyInterface segundaImplementacion = new ImplementacionB();
        primeraImplementacion.mostrar(true, false, "Ingenieria de diseno");
    }
}