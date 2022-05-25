namespace Ejercicio2{
    public class Empleado{
        public Empleado(){

        }
        public enum cargos{
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

        public double SueldoBasico = 38.900;

        public cargos Cargo;
        
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

        public double Salario(){
            double adicional = 0;
            if (Antiguedad() < 25)
            {
                adicional = SueldoBasico*Antiguedad()/100;
            }else
            {
                adicional = SueldoBasico*25/100;
            }
            if (Cargo == cargos.Ingeniero || Cargo == cargos.Especialista)
            {
                adicional = adicional + SueldoBasico/2;
            }
            if (EstadoCivil.Equals("C"))
            {
                adicional = adicional + 15000;
            }
            return SueldoBasico + adicional;
        }

    }
}