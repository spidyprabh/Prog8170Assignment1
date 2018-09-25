using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_QA
{
  class Program
  {
    static void Main(string[] args)
    {

      Rectangle p = new Rectangle();
      int choice, length, width;
      do
      {
        Console.WriteLine("Choose the Correct options:");
        Console.WriteLine("1.Get Rectangle Length");
        Console.WriteLine("2.Change Rectangle Length.");
        Console.WriteLine("3.Get Rectangle Width");
        Console.WriteLine("4.Change Rectangle Width");
        Console.WriteLine("5.Get Rectangle Perimeter");
        Console.WriteLine("6.Get Rectangle Area");
        Console.WriteLine("7.Exit");
        Console.WriteLine("Please Enter your choice from the above menu :");
        if ((!int.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > 7))
        {
          Console.WriteLine("Please Enter the Correct Choice :");
          continue;
        }
        switch (choice)
        {
          case 1:
            Console.WriteLine("Length of the Rectangle is :{0}\n", p.GetLength());
            break;
          case 2:
            do
            {
              Console.WriteLine("Enter the positive integer value for length");
            } while (!int.TryParse(Console.ReadLine(), out length) || length <= 0);
            Console.WriteLine("New length is :{0}\n", p.SetLength(length));
            break;
          case 3:
            Console.WriteLine(" Width of the rectangle is : {0}\n", p.GetWidth());
            break;
          case 4:
            do
            {
              Console.WriteLine("Enter the positive integer value for width :");
            } while (!int.TryParse(Console.ReadLine(), out width) || width <= 0);
            Console.WriteLine("New width is : {0}\n", p.SetWidth(width));
            break;
          case 5:
            Console.WriteLine("Perimeter of a Rectangle is:{0}\n", p.GetPerimeter());
            break;
          case 6:
            Console.WriteLine(" Area of a Rectangle is : {0}\n", p.GetArea());
            break;
          case 7:
            break;
        }
      } while (choice != 7);
    }
  }
}
