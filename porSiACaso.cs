using Ejercicio1;
int aux =0;
int valor;

calculadora calculadora = new calculadora(0);
while (aux == 0)
{
    Console.WriteLine("ingrese la operacion deseada: 1_ Suma 2_Resta 3_Multiolicacion 4_Divicion 5_Limpiar 6_Salir");
    string texto = Console.ReadLine();
    int eleccion = Int32.Parse(texto);
    switch (eleccion)
    {
        case 1:
            Console.WriteLine("Ingrese el primer valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Suma(valor);
            Console.WriteLine("Ingrese el segundo valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Suma(valor);
            Console.WriteLine("El resultado es: "+ calculadora.resultado);
            calculadora.Limpiar();
        break;

        case 2:
            Console.WriteLine("Ingrese el primer valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Resta(valor);
            Console.WriteLine("Ingrese el segundo valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Resta(valor);
            Console.WriteLine("El resultado es: "+ calculadora.resultado);
            calculadora.Limpiar();
        break;

        case 3:
        Console.WriteLine("Ingrese el primer valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Multoplicacion(valor);
            Console.WriteLine("Ingrese el segundo valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Multoplicacion(valor);
            Console.WriteLine("El resultado es: "+ calculadora.resultado);
            calculadora.Limpiar();
        break;

        case 4:
        Console.WriteLine("Ingrese el primer valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Divicion(valor);
            Console.WriteLine("Ingrese el segundo valor");
            texto = Console.ReadLine();
            valor = Int32.Parse(texto);
            calculadora.Divicion(valor);
            Console.WriteLine("El resultado es: "+ calculadora.resultado);
            calculadora.Limpiar();
        break;
        
        default:
            aux = 1;
            break;
    }

}