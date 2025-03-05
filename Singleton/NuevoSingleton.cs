﻿namespace Singleton;
public class Singleton
{
    // Atributo estatico (accesible globalmente) pero privado llamado instance
    private static NuevoSingleton instance;
    // Constructor privado y vacio de la clase 
    private NuevoSingleton() {}

    public static NuevoSingleton getInstance()
    {
        if (instance == null)
        {
            instance = new NuevoSingleton();
        }
        return instance;
    }
}