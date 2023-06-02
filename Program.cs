// See https://aka.ms/new-console-template for more information
double salarioTotal=0;
Empleado[] XEmpleado= new Empleado[3];
double[] SueldoBasico=new double[3];
int AntigMax=0;
for (int i = 0; i < 3; i++)
{
    XEmpleado[i] = new Empleado();
    Console.WriteLine("Ingrese su nombre");
    XEmpleado[i].Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su apellido");
    XEmpleado[i].Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha de nacimiento");
    string? fechaN = Console.ReadLine();
    bool anda1 = DateTime.TryParse(fechaN, out XEmpleado[i].fechaNac);
    if (anda1)
    {
        Console.WriteLine("Fecha aceptada");
    }
    Console.WriteLine("Ingrese su estado civil (S soltero, C casado)");
    string? ecivil = Console.ReadLine();
    bool anda2 = char.TryParse(ecivil, out XEmpleado[i].EstadoCivil);
    if (anda2)
    {
        Console.WriteLine("Estado civil aceptado");
    }
    Console.WriteLine("Ingrese su genero M masculino, F femenino");
    string? gen = Console.ReadLine();
    bool anda3 = char.TryParse(gen, out XEmpleado[i].Genero);
    if (anda3)
    {
        Console.WriteLine("Genero aceptado");
    }
    Console.WriteLine("Ingrese la fecha de ingreso");
    string? fechaIng = Console.ReadLine();
    bool anda4 = DateTime.TryParse(fechaIng, out XEmpleado[i].fechaIngreso);
    if (anda4)
    {
        Console.WriteLine("Fecha aceptada");
    }
    Console.WriteLine("Ingrese el sueldo básico");
    string? sueldob = Console.ReadLine();
    bool anda5 = double.TryParse(sueldob, out XEmpleado[i].SueldoBasico);
    if (anda5)
    {
        Console.WriteLine("Sueldo aceptado");
    }
    Console.WriteLine("Ingrese su cargo: 1.Auxiliar, 2.Administrativo, 3.Ingeniero, 4.Especialista, 5.Investigador");
    string? ingcargo = Console.ReadLine();
    bool anda6 = cargos.TryParse(ingcargo, out XEmpleado[i].CargoqueOcupa);
    if (anda6)
    {
        Console.WriteLine("Enum cargos aceptado");
    }
    XEmpleado[i].edad = XEmpleado[i].CalcularEdad(XEmpleado[i].fechaNac);
    XEmpleado[i].antiguedad = XEmpleado[i].CalcularAntiguedad(XEmpleado[i].fechaIngreso);
    Console.WriteLine("EDAD: " + XEmpleado[i].edad);
    Console.WriteLine("ANTIGUEDAD: " + XEmpleado[i].antiguedad);
    XEmpleado[i].edadRecibirse = XEmpleado[i].CantAniosJubilarse(XEmpleado[i].fechaNac, XEmpleado[i].Genero);
    Console.WriteLine($"Le faltan {XEmpleado[i].edadRecibirse} anios para recibirse");
    SueldoBasico[i] = XEmpleado[i].CalcularSalario(XEmpleado[i].SueldoBasico, XEmpleado[i].edad, XEmpleado[i].antiguedad, XEmpleado[i].CargoqueOcupa, XEmpleado[i].EstadoCivil);
    Console.WriteLine("EL Salario total es: "+ SueldoBasico[i]);
    salarioTotal+=SueldoBasico[i];
    if(XEmpleado[i].antiguedad>AntigMax){
        AntigMax=XEmpleado[i].antiguedad;
    }
}

for(int j=0;j<3;j++){
    if(AntigMax==XEmpleado[j].antiguedad){
        Console.WriteLine("NOMBRE: "+XEmpleado[j].Nombre);
        Console.WriteLine("APELLIDO: "+XEmpleado[j].Nombre);
        Console.WriteLine("FECHA DE NACIMINENTO: "+XEmpleado[j].fechaNac);
        Console.WriteLine("ESTADO CIVIL: "+XEmpleado[j].EstadoCivil);
        Console.WriteLine("GENERO: "+XEmpleado[j].Genero);
        Console.WriteLine("FECHA DE INGRESO: "+XEmpleado[j].fechaIngreso);
        Console.WriteLine("SUELDO BASICO: "+XEmpleado[j].SueldoBasico);
        Console.WriteLine("SUELDO: "+SueldoBasico[j]);
        Console.WriteLine("CARGO QUE OCUPA: "+XEmpleado[j].CargoqueOcupa);
        Console.WriteLine("ANTIGUEDAD: "+XEmpleado[j].antiguedad);
        Console.WriteLine("EDAD: "+XEmpleado[j].edad);
    }
}