using System;
 
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
           int AntalFörsök  =0;
           Random random = new Random();
           int Tal = random.Next(1, 101);
 
           Console.WriteLine("Gissa mitt tal. Välj ett tal mellan 1 och 100.");
 
           while (true) {
               int Försök = int.Parse(Console.ReadLine());
 
               if(Försök == Tal) {
                   Console.WriteLine("Du gissade rätt");
                   Console.WriteLine("Det tog dig " + AntalFörsök + " försök.");
                   break;
 
               } else if(Försök < Tal) {
                   Console.WriteLine("Försök högre");
                   AntalFörsök += 1;
 
                  } else {
                   Console.WriteLine("Försök lägre");
                   AntalFörsök += 1;
                  }
               
 
           }
        }
    }
}
 
