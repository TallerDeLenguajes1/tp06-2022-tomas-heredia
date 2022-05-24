namespace Ejercicio2{
    public class Empleado{
        public enum cargo{
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
        public string Nombre;
        public string Alpellido;

        public DateTime Nacimiento;

        public char EstadoCivil;

        public char Genero;

        public DateTime Ingreso;

        public double SueldoBasico;

        public cargo Cargo;
        
        public void Antiguedad(){
            DateTime FechaActual = DateTime();
            int ano = FechaActual.Year - Ingreso.Year;
            int mes = FechaActual.Month - Ingreso.Month;
            int dia = FechaActual.day - Ingreso.day;
            Console.WriteLine("La antiguedad es de : "+ano+" anios "+mes+" meses y "+dia+" dias");

        }

        public void Edad(){
            DateTime FechaActual = DateTime();
            int edad = FechaActual.Year - Nacimiento.year;
            
            Console.WriteLine("Edad : "+edad);
        }

        public void Juvilacion(){
            if (Genero == "M")
            {
                int juvi = 65 - Edad();
            }else
            {
                int juvi = 60 - Edad();
            }
            Console.WriteLine("Le faltan "+juvi+" anios para juvilarse");
        }
    }
}