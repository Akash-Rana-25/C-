using System.Diagnostics;

namespace LSP_practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ColdDrinks ColdDrinks = new Fanta();
            Console.WriteLine(ColdDrinks.GetColor());
            ColdDrinks = new Coke();
            Console.WriteLine(ColdDrinks.GetColor());
        }
    }
    public abstract class ColdDrinks
    {
        public abstract string GetColor();
    }
    public class Coke : ColdDrinks
    {
        public override string GetColor()
        {
            return "black";
        }
    }
    public class Fanta : ColdDrinks
    {
        public override string GetColor()
        {
            return "orange";
        }
    }
}