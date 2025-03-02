namespace Singleton;

public class Program {
    
    public static void Main(string[] args) {
        
        Singleton firstInstance = Singleton.getInstance();
        Singleton secondInstance = Singleton.getInstance();
        
        if (firstInstance.Equals(secondInstance)) {
            Console.WriteLine("They are the same instance");
        }

    }
}