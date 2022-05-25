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
        
        public int Antiguedad(){
            DateTime FechaActual = DateTime.Now;
            int anio = FechaActual.Year - Ingreso.Year;
            
            return anio;
        }

        public int Edad(){
            DateTime FechaActual = DateTime.Now;
            int edad = FechaActual.Year - Nacimiento.Year;
            
            return edad;

        }

        public int Juvilacion(){
            
            if (Genero.Equals("M"))
            {
                int juvi = 65 - Edad();
                return juvi;
            }else
            {
                int juvi = 60 - Edad();
                return juvi;
            }
            
        }
    }
}