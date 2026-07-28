using System; 
 
    class Program 
    { 
        static void Main() 
        { 
     
         
          double num1 = 0; 
          double num2 = 0; 
          double result = 0; 
          Console.WriteLine("Calculator Program"); 
                 
          Console.Write("Enter number 1: "); 
          num1 = Convert.ToDouble(Console.ReadLine()); 
 
          Console.Write("Enter number 2: "); 
          num2 = Convert.ToDouble(Console.ReadLine()); 
 
          Console.WriteLine("+ : Add"); 
          Console.WriteLine("- : Subtract"); 
          Console.WriteLine("* : Multiply"); 
          Console.WriteLine("/ : Divide"); 
          Console.WriteLine("Enter an option: "); 
 
 
         Console.ReadKey(); 
        }   