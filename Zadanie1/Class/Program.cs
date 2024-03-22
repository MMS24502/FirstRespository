// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Bla bla");
var x = 10;
var y = 5;
x += y;

Console.WriteLine(x);

int[] tab = new[] { 5, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 12, 34, 12, 2, 3, 4 };
var res = avg(tab);
Console.WriteLine(res);


static int  avg (int [] tab)
{
    var avg = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        avg += tab[i];
    }

    avg /= tab.Length;
    return avg;
}
