// See https://aka.ms/new-console-template for more information
//Creando mi primera lista
/* Coords misCoordenadas = new Coords(2,10, 0);
Console.WriteLine(misCoordenadas.X);
Console.WriteLine(misCoordenadas.Y);
Console.WriteLine(misCoordenadas.Z); */

Dates misDates = new Dates("Laura", "+56944612393", "Mi dirección", "Mi email", true);
Console.WriteLine(misDates.X);
Console.WriteLine(misDates.Y);
Console.WriteLine(misDates.Z);
Console.WriteLine(misDates.Q);
Console.WriteLine(misDates.P);

public struct Dates
{
    public Dates(string name, string phone, string address, string email, bool newUser)
    {
        X = name;
        Y = phone;
        Z = address;
        Q = email;
        P = newUser;
    }

    public string X { get; }
    public string Y { get; }
    public string Z { get; }
    public string Q { get; }
    public bool P { get; }

    public override string ToString() => $"({X}, {Y}, {Z}, {Q}, {P})";
}
