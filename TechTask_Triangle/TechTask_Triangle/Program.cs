using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinate x of dot A:");
        double x_of_A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of dot A:");
        double y_of_A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate x of dot B:");
        double x_of_B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of dot B:");
        double y_of_B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate x of dot C:");
        double x_of_C = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter coordinate y of dot C:");
        double y_of_C = Convert.ToDouble(Console.ReadLine());
        double length_of_AB;
        double length_of_BC;
        double length_of_AC;
        double periemetr;
        double delta;
        delta = 1;
        length_of_AB = Math.Sqrt((Math.Pow((x_of_B - x_of_A), 2) +
  Math.Pow((y_of_B - y_of_A), 2)));
        length_of_BC = Math.Sqrt((Math.Pow((x_of_C - x_of_B), 2) +
         Math.Pow((y_of_C - y_of_B), 2)));
        length_of_AC = Math.Sqrt((Math.Pow((x_of_C - x_of_A), 2) +
          Math.Pow((y_of_C - y_of_A), 2)));

        Console.WriteLine($"Length of AB is: '{length_of_AB}'");
        Console.WriteLine($"Length of BC is: '{length_of_BC}'");
        Console.WriteLine($"Length of AC is: '{length_of_AC}'");
        Console.ReadKey();




        if (length_of_AB == length_of_BC && length_of_BC == length_of_AC)
            Console.WriteLine("TRIANGLE IS 'Equilateral'");
        else Console.WriteLine("TRIANGLE IS NOT 'Equilateral'");

        if (length_of_AB == length_of_BC || length_of_AB == length_of_AC || length_of_BC == length_of_AC)
            Console.WriteLine("TRIANGLE IS 'Isosceles '");

        if (length_of_BC * 2 - (length_of_AB * 2 + length_of_AC * 2) <= delta)
            Console.WriteLine("TRIANGLE IS 'RIGHT '");



        periemetr = length_of_AB + length_of_BC + length_of_AC;
        Console.WriteLine($"Perimetr: {periemetr}");
        Console.ReadKey();


        int numb;
        Console.WriteLine("Parity numbers in range from 0 to triangle perimetr:");
        for (numb = 0; numb <= periemetr; numb++)
            if (numb % 2 == 0)
            {
                Console.WriteLine("{0} ", numb);
            }
        Console.ReadKey();
    }
}
