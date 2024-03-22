// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Bla bla");
var x = 10;
var y = 5;
x += y;

Console.WriteLine(x);

int[] tab = new[] { 5, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 12, 34, 12, 2, 3, 4 };
var res = Avg(tab);
Console.WriteLine(res);

var res2 = Max(tab);
Console.WriteLine(res2);


static int Avg(int[] tab)
{
    var avgBen = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        avgBen += tab[i];
    }

    avgBen /= tab.Length;
    return avgBen;
}

static int Max (int [] tab)
{
    var max = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        if (max < tab[i])
            max = tab[i];
        
    }
    return max;
}
