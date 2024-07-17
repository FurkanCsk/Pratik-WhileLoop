//  1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int sayac1 = 0;
while(sayac1 < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac1++;
}

//  2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int sayac2 = 1;
while(sayac2 <= 20)
{
    Console.WriteLine(sayac2);
    sayac2++;
}

//  3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int cift = 1;
while(cift <= 20)
{
    if(cift % 2 == 0)
    {
        Console.WriteLine(cift);
    }
    cift++;
}

//  4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int sayac3 = 50;
int toplam = 0;
while(sayac3 <= 150)
{
    toplam += sayac3;
    sayac3++;
}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı : {toplam}");

//  5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int cifttoplam = 0;
int tektoplam = 0;
int sayac4 = 1;

while(sayac4 <= 120)
{
    if(sayac4 % 2 == 0)
    {
        cifttoplam += sayac4;
    }
    else
    {
        tektoplam += sayac4;
    }
    sayac4++;
}
Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı : {tektoplam}");
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı : {cifttoplam}");