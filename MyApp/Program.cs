using Ejercicio2;

Random r= new Random ();
Empleado Empleado1 = new Empleado();
Empleado1.Alpellido = "Heredia";
Empleado1.Nombre = "Tomas";
Empleado1.Cargo = (cargos)r.Next(0,6);
Empleado1.EstadoCivil = char.Parse("C");
Empleado1.Genero = char.Parse("M");
Empleado1.Nacimiento = new DateTime(2001, 4 , 20);
Empleado1.Ingreso = new DateTime(2010, 5, 25);

Empleado Empleado2 = new Empleado();
Empleado2.Alpellido = "Knez";
Empleado2.Nombre = "Irina";
Empleado2.Cargo = (cargos)r.Next(0,6);
Empleado2.EstadoCivil = char.Parse("C");
Empleado2.Genero = char.Parse("F");
Empleado2.Nacimiento = new DateTime(1998, 4 , 15);
Empleado2.Ingreso = new DateTime(2010, 5, 25);

Empleado Empleado3 = new Empleado();
Empleado3.Alpellido = "Hernadez";
Empleado3.Nombre = "Mateo";
Empleado3.Cargo = (cargos)r.Next(0,6);
Empleado3.EstadoCivil = char.Parse("S");
Empleado3.Genero = char.Parse("M");
Empleado3.Nacimiento = new DateTime(1999, 7 , 16);
Empleado3.Ingreso = new DateTime(2011, 5, 25);

Double Total = Empleado1.Salario() + Empleado2.Salario() + Empleado3.Salario();
Console.WriteLine("Total en salarios: "+Total+"$");

Empleado EmpleadoJuvilando = new Empleado();
if (Empleado1.Juvilacion() <= Empleado2.Juvilacion())
{
    EmpleadoJuvilando = Empleado1;
}else
{
    EmpleadoJuvilando = Empleado2;
}
if (Empleado3.Juvilacion() < EmpleadoJuvilando.Juvilacion())
{
    EmpleadoJuvilando = Empleado3;
}

Console.WriteLine("Empleado mas serca de la juvilacion:");
Console.WriteLine(EmpleadoJuvilando.Alpellido+" "+EmpleadoJuvilando.Nombre);
Console.WriteLine("Cargo: "+ EmpleadoJuvilando.Cargo);
Console.WriteLine("Edad: "+ EmpleadoJuvilando.Edad());
Console.WriteLine("Genero :"+ EmpleadoJuvilando.Genero);
Console.WriteLine("Antiguedad: " + EmpleadoJuvilando.Antiguedad());
Console.WriteLine("Estado civil :" +EmpleadoJuvilando.EstadoCivil);
Console.WriteLine("Salario: "+EmpleadoJuvilando.Salario()+"$");




    



