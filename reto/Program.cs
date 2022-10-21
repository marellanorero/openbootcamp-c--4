int i = 1;
Console.WriteLine("WHILE: ");
while(i <= 10)
{
    Console.WriteLine("1 x " + i + " = " + i );
    i++;
}

/* Console.WriteLine("DO WHILE: ");
int y = 1;
do {
    
} while (y <= 10);
Console.WriteLine("FOR"); */


Console.WriteLine("Introduce el alto: ");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce el ancho: ");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("¿Quieres que tenga relleno?: ");
string relleno = Console.ReadLine();

Console.WriteLine("Introduce la cantidad: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

for(int x=1; x<=cantidad; x++){
    if ( relleno == "si" ) {
    for(int s = 1; s <= alto; s++){
        for ( int n = 1; n <= ancho; n++){
            Console.Write(" *");
        }
        Console.WriteLine("");
    }
    Console.WriteLine(" ");
} else {
    for (int s = 0; s < alto; s++ ){
        Console.Write(" *");
    }
    
    for( int g = 0; g < ancho-2; g++){
        Console.Write(" *");
        for(int l = 0; l < ancho-2; l++){
            Console.WriteLine(" ");
        }
        Console.Write(" *");
    }

    for( int n = 0; n < ancho; n++){
            Console.Write(" *");
        }
    Console.WriteLine(" ");
}


}
