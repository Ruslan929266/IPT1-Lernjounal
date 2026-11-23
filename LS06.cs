Console.WriteLine("Welcome to Mensa");

Console.Write("Articlename: ");
string artikelname = Console.ReadLine();

Console.Write("Pice of one in CHF: ");
decimal einzelpreis = Convert.ToDecimal(Console.ReadLine());

Console.Write("Quantity: ");
int menge = Convert.ToInt32(Console.ReadLine());

decimal rabatt = 0; 

if (menge < 1)
{
    Console.WriteLine("Invalid quantity. Please enter a quantity of at least 1.");
    return;
}
else if (menge <= 2)
{
    rabatt = 0;
}
else if (menge <= 4)
{
    rabatt = 0.10m;
}
else 
{
    rabatt = 0.20m;
}

decimal gesamtpreis = einzelpreis * menge;
decimal rabattbetrag = gesamtpreis * rabatt;
decimal endpreis = gesamtpreis - rabattbetrag;

Console.WriteLine("------------------------");
Console.WriteLine("Beleg");
Console.WriteLine("Artikel: " + artikelname);
Console.WriteLine("Einzelpreis: CHF " + einzelpreis.ToString("F2"));
Console.WriteLine("Menge: " + menge);
Console.WriteLine("Gesamtpreis: " + gesamtpreis + "CHF " );
Console.WriteLine("Rabatt: CHF " + rabattbetrag.ToString("F2"));
Console.WriteLine("Endpreis: CHF " + endpreis.ToString("F2"));
