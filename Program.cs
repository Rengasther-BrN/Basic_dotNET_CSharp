using DesafioDIO.src.Entities;

namespace DesafioDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Ninja wedge = new Ninja("Wedge", 22, "Knight");
            Wizard wizard = new Wizard("Jennica", 21, "White Wizard");
            Black_Wizard topapa = new Black_Wizard("Topapa", 23, "Black Wizard");            
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(topapa.Attack(7));
        }
    }
}

