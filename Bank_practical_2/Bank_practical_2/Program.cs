namespace Bank_practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer_Account customer_info = new(123,"Akash");
            customer_info.PrintInfo();
        }
    }
  
}