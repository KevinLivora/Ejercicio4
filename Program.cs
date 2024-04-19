//Tomando como base el programa de cumpleaños de los amigos, agregarle:

/*Un método que permita setearle la fecha de nacimiento.
Un método que devuelva si es mayor de edad.
Un método que devuelva el nombre y el apellido preparado para mostrarse con WriteLine
Un método que devuelva cuántos años tiene
Un método que devuelva en un string el nombre, apellido, la fecha de nacimiento, edad, y si es mayor de edad o no, listo para ser usado con WriteLine. Modificar el programa que usa array para que haga uso de todos estos nuevos métodos*/

Console.Write("Ingrese la cantidad de amigos: ");
int cantidadAmigos = Convert.ToInt32(Console.ReadLine());

// Creamos un array para almacenar los datos de los amigos
Amigo[] amigos = new Amigo[cantidadAmigos];

// Pedimos al usuario que ingrese los datos de cada amigo
for (int i = 0; i < cantidadAmigos; i++)
{
    Console.WriteLine($"\nIngrese los datos del amigo {i + 1}:");
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();

    Console.Write("Día de cumpleaños: ");
    int dia = Convert.ToInt32(Console.ReadLine());

    Console.Write("Mes de cumpleaños: ");
    int mes = Convert.ToInt32(Console.ReadLine());

    Console.Write("Año de cumpleaños: ");
    int anio = Convert.ToInt32(Console.ReadLine());

    amigos[i] = new Amigo
    {
        Nombre = nombre,
        Apellido = apellido,
    };

    amigos[i].setFechaNacimiento(dia, mes, anio);
}

Console.WriteLine("\nIngrese el número de mes para verificar cuántos amigos cumplen años en ese mes:");
int mesBusqueda = Convert.ToInt32(Console.ReadLine());

int amigosEnMes = 0;

foreach (Amigo amigo in amigos)
{
    if (amigo.Mes == mesBusqueda)
    {
        amigosEnMes++;
        Console.WriteLine(amigo.DetallesAmigo());
    }
}

Console.WriteLine($"\nTotal de amigos que cumplen años en el mes {mesBusqueda}: {amigosEnMes}");