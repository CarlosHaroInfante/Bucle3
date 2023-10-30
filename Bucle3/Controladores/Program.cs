namespace Bucle3;


using Bucle3.Servicios;

/// <summary>
/// Clase Principal de el programa, donde se encuentra el Main 
/// 301023 - chi
/// </summary>
class Program
{
    /// <summary>
    /// Main del Programa donde se encuentran las llamadas a los métodos
    /// 301023 - chi
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        MenuInterfaz a = new MenuImplementacion(); //Copia de el Menu Implementación
        int c = a.bucle(); //Llamada al método

        


        InterfazOperacion b = new ImplementacionOperacion(); //Copia de el Menu Interfaz

        int resultado = b.bucle2(c); //Llamada al método
    }
}
