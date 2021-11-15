using System;
class MainClass
{
    public static void Main()
    {
        Console.WriteLine("This is a room calculator.\nTo start please enter the width:");
        string uwidth = Console.ReadLine();
        double vwidth = double.Parse(uwidth);
        
        Console.WriteLine("Please enter the length:");
        string ulength = Console.ReadLine();
        double vlength = double.Parse(ulength);

        Console.WriteLine("Please enter the height:");
        string uheight = Console.ReadLine();
        double vheight = double.Parse(uheight);

;
        double area = vlength * vwidth;
        double surface = vlength * vheight * 2 + vwidth * vheight * 2 + area * 2;
        double volume = vlength * vwidth * vheight;

        if (area < 250)
        {
            Console.WriteLine("This is a small sized room.");
        }
        else if (area < 650)
        {
            Console.WriteLine("This is a medium sized room.");
        }
        else
        {
        Console.WriteLine("This is a large sized room.");
        }
        Console.WriteLine(vlength + " x " + vwidth + " x " + vheight);
        Console.WriteLine("The area is " + area + ".");
        Console.WriteLine("The surface is " + surface + ".");
        Console.WriteLine("The Volume is " + volume + ".");


    }
}