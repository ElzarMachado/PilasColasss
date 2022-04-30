using Arreglos;
using Listas;

Console.WriteLine("--------Arreglos Pilas--------");
Arreglos.Pilas pilas = new Arreglos.Pilas(10);
pilas.Agregar("cero");
pilas.Agregar("uno");
pilas.Agregar("dos");
pilas.Agregar("tres");
pilas.Agregar("cuatro");
pilas.Agregar("cinco");
Console.WriteLine(pilas.Imprimir());




for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("---------------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
    

}
Console.WriteLine("\n");

Console.WriteLine("-------Arreglo Colas--------");
Arreglos.Colas colas = new Arreglos.Colas(10);
colas.Agregar("cero");
colas.Agregar("uno");
colas.Agregar("dos");
colas.Agregar("tres");
colas.Agregar("cuatro");
colas.Agregar("cinco");
Console.WriteLine(colas.Imprimir());
for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("--------------------------------");
        pilas.Eliminar();
        Console.WriteLine(colas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }


}
Console.WriteLine("\n");

Console.WriteLine("--------Listas Pilas---------");
Listas.Pilas Lpilas = new Listas.Pilas(10);
Lpilas.Agregar("cero");
Lpilas.Agregar("uno");
Lpilas.Agregar("dos");
Lpilas.Agregar("tres");
Lpilas.Agregar("cuatro");
Lpilas.Agregar("cinco");
Console.WriteLine(Lpilas.Imprimir());
for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("--------------------------------");
        Lpilas.Eliminar();
        Console.WriteLine(Lpilas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }


}
Console.WriteLine("\n");

Console.WriteLine("--------Listas Colas----------");
Listas.Colas LColas = new Listas.Colas(10);
LColas.Agregar("cero");
LColas.Agregar("uno");
LColas.Agregar("dos");
LColas.Agregar("tres");
LColas.Agregar("cuatro");
LColas.Agregar("cinco");
Console.WriteLine(LColas.Imprimir());
for (int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("--------------------------------");
        pilas.Eliminar();
        Console.WriteLine(LColas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }


}