using EspacioCalculadora;

Calculadora calculadora = new Calculadora();

double numero;
int opcion;
List<Operacion> Operaciones = new List<Operacion>();

do
{
    Console.WriteLine("-----Calculadora------");
    Console.WriteLine("1_Sumar");
    Console.WriteLine("2_Restar");
    Console.WriteLine("3_Multiplicar");
    Console.WriteLine("4_Dividir");
    Console.WriteLine("5_Limpiar");
    Console.WriteLine("6_Salir");

    Console.WriteLine("Ingrese una opcion");
    string entrada2 = Console.ReadLine() ?? "";

    bool control2 = int.TryParse(entrada2, out opcion);

    if (!control2)
    {
        Console.WriteLine("Debe ingresar un número válido para seleccionar una opción.");
        continue;
    }

    double resultadoAnterior = calculadora.resultado;
    TipoOperacion tipoOperacion = TipoOperacion.Suma;
    if (opcion >= 1 && opcion <= 4)
    {

        Console.WriteLine("Ingrese un numero");
        string entrada = Console.ReadLine() ?? "";

        bool control = double.TryParse(entrada, out numero);

        if (!control)
        {
            Console.WriteLine("Debe ingresar un número válido para calcular.");
            continue;
        }

        switch (opcion)
        {
            case 1:
                calculadora.sumar(numero);
                tipoOperacion = TipoOperacion.Suma;
                break;
            case 2:
                calculadora.restar(numero);
                tipoOperacion = TipoOperacion.Resta;
                break;
            case 3:
                calculadora.multiplicar(numero);
                tipoOperacion = TipoOperacion.Multiplicacion;
                break;
            case 4:
                calculadora.dividir(numero);
                tipoOperacion = TipoOperacion.Division;
                break;
        }
        Operaciones.Add(new Operacion(resultadoAnterior, numero, tipoOperacion));
    }
    else if (opcion == 5)
    {
        calculadora.limpiar(calculadora.dato);
        Console.WriteLine("Resultado limpiado.");
        Operaciones.Add(new Operacion(resultadoAnterior, 0, tipoOperacion));

    }
    else
    {
        Console.WriteLine("Saliendo del programa...");
    }


    Console.WriteLine("Numero resultante: " + calculadora.resultado);

} while (opcion != 6);




