using Arreglos;

Pilas pilas = new Pilas(10);
pilas.Agregar("cero");
pilas.Agregar("uno");
pilas.Agregar("dos");
pilas.Agregar("tres");
pilas.Agregar("cuatro");
pilas.Agregar("cinco");
Console.WriteLine(Pilas.Imprimir());

pilas.Eliminar();
Console.WriteLine(pilas.Imprimir());
pilas.Eliminar();
Console.WriteLine(pilas.Imprimir());
pilas.Eliminar();
Console.WriteLine(pilas.Imprimir());
pilas.Eliminar();
Console.WriteLine(pilas.Imprimir());
pilas.Eliminar();
Console.WriteLine(pilas.Imprimir());
pilas.Eliminar();
Console.WriteLine(pilas.Imprimir());
pilas.Eliminar();
Console.WriteLine(pilas.Imprimir());