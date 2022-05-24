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
        public string Apellido;

        public DateTime Nacimiento;

        public char EstadoCivil;

        public char Genero;

        public DateTime Ingreso;

        public double SueldoBasico;

        public cargo Cargo;
        
        public DateTime Antiguedad(){
            DateTime FechaActual =new DateTime().Now;
            return FechaActual.Year - Ingreso.Year;
        }

        public int Edad(){
            DateTime FechaActual = DateTime();
            int edad = FechaActual.Year - Nacimiento.year;
            
            
            return Edad;
        }

        public int Juvilacion(){
            if (Genero == "M")
            {
                int juvi = 65 - Edad();
            }else
            {
                int juvi = 60 - Edad();
            }
            
            return juvi;
        }

        public double Salario(){
            double adicional =0;
            if (Antiguedad() < 25)
            {
                adicional = SueldoBasico*Antiguedad()/100;
            }else
            {
                adicional = SueldoBasico*25/100;
            }
            if (Cargo == cargo.Ingeniero || Cargo == cargo.Especialista)
            {
                adicional = adicional + SueldoBasico/2;
            }
            if (EstadoCivil == "C")
            {
                adicional += 15000; 
            }
            return adicional + SueldoBasico;
        }
    }
}