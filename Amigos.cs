class Amigo
{
    public string Nombre;
    public string Apellido;
    public int Dia;
    public int Mes;
    public int Anio;

    public void setFechaNacimiento(int dia, int mes, int anio)
    {
        Dia = dia;
        Mes = mes;
        Anio = anio;
    }

    public bool esMayorDeEdad()
    {
        int edad = calcularEdad();
        return edad >= 18;
    }

    public int calcularEdad()
    {
        DateTime fechaActual = DateTime.Now;
        DateTime fechaNacimiento = new DateTime(Anio, Mes, Dia);
        int edad = fechaActual.Year - fechaNacimiento.Year;
        if (fechaActual < fechaNacimiento.AddYears(edad))
        {
            edad--;
        }
        return edad;
    }

    public string nombreApellido()
    {
        return $"{Nombre} {Apellido}";
    }

    public string DetallesAmigo()
    {
        int edad = calcularEdad();
        string mayorEdad = esMayorDeEdad() ? "Mayor de edad" : "Menor de edad";
        return $"Nombre: {nombreApellido()}, Fecha de nacimiento: {Dia}/{Mes}/{Anio}, Edad: {edad}, {mayorEdad}";
    }
}