//ejer 1
static void suma ()
{
    int respuesta, val1, val2 = 0;
    Console.WriteLine("Ingrese el valor 1:");
    val1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el valor 2:");
    val2 = int.Parse(Console.ReadLine());
    respuesta = val1 + val2;
    Console.WriteLine("suma = " + respuesta);
}

//ejer 2
static void datos ()
{
    Console.WriteLine("Cual es su nombre");
    string nombre = Console.ReadLine();
    Console.WriteLine("Mucho gusto " + nombre);
}


//ejer 3
static void calculoEdad()
{
Console.WriteLine("ingrese su año de nacimiento: ");
int yearBorn = int.Parse(Console.ReadLine());
int edad = 2024 - yearBorn;
Console.WriteLine("Su edad es = " + edad);
}

//ejer 4
static int sumaa (int val1, int val2, int val3 )
{
    return val1 + val2+val3;
}

//ejer 5
static string datoss()
{
    Console.WriteLine("Cual es su nombre");
    string nombre = Console.ReadLine();
    return nombre;
}
//=====================================================================================================

//int sumanum = sumaa(10,20);

int promedio = sumaa(30, 20, 40) / 3;
Console.WriteLine(promedio);

string name = datoss();

Console.WriteLine(name + "Tiene un promedio de : " + promedio);

/*
int emenu = 0;
do
{
    Console.WriteLine("Ingrese la opción que desee: \n1. suma.\n2. nombre\n3. edad\n4. Salir");
    emenu = int.Parse(Console.ReadLine());
    switch (emenu)
    {
        case 1:
            suma();
            break;
        case 2:
            datos();
            break;
        case 3:
            calculoEdad();
            break;
        case 4:
            emenu = 4;
            break;
        default:
            Console.WriteLine("Valor invalido");
            break;
    }
}while (emenu != 4);
*/