Console.Clear();

int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 40, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int point = new Random().Next(0, 3);

    if (point == 0)
    {
        x = (x + xa) / 2;
        y = (x + ya) / 2;
    }

    if (point == 1)
    {
        x = (x + xb) / 2;
        y = (x + yb) / 2;
    }

    if (point == 2)
    {
        x = (x + xc) / 2;
        y = (x + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
