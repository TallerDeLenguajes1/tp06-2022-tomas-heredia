namespace Ejercicio1{
    public class calculadora{
        public double resultado;
        public calculadora(double entrada){
            resultado = entrada;
        }
        public calculadora(){

        }

        public double Suma(double termino){
        resultado += termino;
        return resultado;
        }

        public double Resta(double termino){
            resultado -= termino;
            return resultado;
        }

        public double Multoplicacion(double termino){
            resultado *= termino;
            return resultado;
        }

        public double Divicion(double termino){
            resultado *= termino;
            return resultado;
        }
        public void Limpiar(){
            resultado = 0;
        }
    
    }

    

}