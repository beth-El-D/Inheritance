using mnbv;

Circle c = new Circle();
rectangle r = new rectangle();

int choice;
char what;

  do
{

    Console.WriteLine("\t1. Calculate Area of Circle");
    Console.WriteLine("\t2. Calculate Perimeter of Circle");

    Console.WriteLine("\t3. Calculate Area of Rectangle");

    Console.WriteLine("\t4. Calculate Perimeter of Rectangle");
   
outer: { choice = int.Parse(Console.ReadLine()); }


    if (choice==1)
            {
                Console.WriteLine("Enter radius: ");
                c.radius = Convert.ToDouble(Console.ReadLine());
                c.calculateArea();
                Console.WriteLine("Area= " + c.area);
            }
          else if(choice==2)
            {
                Console.WriteLine("Enter radius: ");
                c.radius = Convert.ToDouble(Console.ReadLine());
                c.calculatePerimeter();
                Console.WriteLine("Perimeter= " + c.perimeter);
            }

          else if(choice ==3)
            {
                Console.WriteLine("Enter length: ");
                r.length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width: ");
                r.width = Convert.ToDouble(Console.ReadLine());
                r.calculateArea();
                Console.WriteLine("Area= " + r.area);
            }

           else if(choice==4)
            {
                Console.WriteLine("Enter length: ");
                r.length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width: ");
                r.width = Convert.ToDouble(Console.ReadLine());
                r.calculatePerimeter();
                Console.WriteLine("Perimeter= " + r.perimeter);
            }

    else
    {
        Console.WriteLine("Please enter proper choice(1-4)");
       goto outer;
        
    }
    
    Console.WriteLine("Do you want to continue:('Y' or 'N'");
    what = Convert.ToChar(Console.ReadLine());
   

} while (what == 'Y');
            