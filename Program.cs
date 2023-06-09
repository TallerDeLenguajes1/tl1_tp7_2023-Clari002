using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information


//crear un objeto del tipo cal y que se llama calculadora
Calculadora cal = new Calculadora();



Console.WriteLine("Ingresar un numero: ");
if (!int.TryParse(Console.ReadLine(), out int num1))
{
    Console.WriteLine("El valor ingresado no es valido");
    return;
}
Console.WriteLine("Ingresar otro numero: ");

if (!int.TryParse(Console.ReadLine(), out int num2))
{
    Console.WriteLine("El valor ingresado no es valido");
    return;
}
Console.WriteLine("Realizar: ");
Console.WriteLine("(1)Suma");
Console.WriteLine("(2)Resta");
Console.WriteLine("(3)Multiplicacion");
Console.WriteLine("(4)Dividision");
Console.WriteLine("(0)Salir");
if (!int.TryParse(Console.ReadLine(), out int opcion))
{
     Console.WriteLine("El valor ingresado no es valido");
    return;
}

    switch (opcion)
    {
        case 1:
        cal.Suma(num1);
        cal.Suma(num2);
Console.WriteLine(cal.Resultado);

        break;

        case 2:
        cal.Restar(num1);
        cal.Restar(num2);
Console.WriteLine(cal.Resultado);

        break;

         case 3:
        cal.Multiplicar(num1);
        cal.Multiplicar(num2);
Console.WriteLine(cal.Resultado);

        break;

        case 4:
        cal.Dividir(num1);
        cal.Dividir(num2);
Console.WriteLine(cal.Resultado);

        break;
        
        default:
        break;
    }

do
{
    Console.WriteLine("¿Realizar otra operacion: 1(SI) 0(NO)");
    if (!int.TryParse(Console.ReadLine(), out  opcion))
    {
        Console.WriteLine("El valor ingresado no es valido");
        return;
    }else{
        if (opcion == 1)
        {
             Console.WriteLine("Ingresar otro valor: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("El valor ingresado no es valido");
            return;
        }

        Console.WriteLine("Realizarle a: "+cal.Resultado);
            Console.WriteLine("(1)Suma");
            Console.WriteLine("(2)Resta");
            Console.WriteLine("(3)Multiplicacion");
            Console.WriteLine("(4)Dividision");
            Console.WriteLine("(0)Salir");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
             Console.WriteLine("El valor ingresado no es valido");
            return;
            }

                switch (opcion)
                {
                    case 1:
                    cal.Suma(numero);
                    Console.WriteLine(cal.Resultado);
                break;

                case 2:
                cal.Restar(numero);
                Console.WriteLine(cal.Resultado);
                break;

                case 3:
                cal.Multiplicar(numero);
                Console.WriteLine(cal.Resultado);
                break;

                case 4:
                cal.Dividir(numero);
                Console.WriteLine(cal.Resultado);
                break;
        
                default:
                break;
                }
        }
       
    }

    
} while (opcion != 0);

/*
cal.Suma(15);
cal.Suma(2);
Console.WriteLine(cal.Resultado);
cal.Restar(3);
Console.WriteLine(cal.Resultado);
cal.Dividir(2);
Console.WriteLine(cal.Resultado);*/