namespace Practical_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team T=new Team();
            T.printinfo();
        }
    }
    class Sponsor
    {
        protected string owner = "Rakuteen";
    }
    class Team : Sponsor
    {
        private string teamName="hi";

        /// <summary>
        /// This method concate  two Strings and display Full string
        /// </summary>
        public void printinfo()
        {
            string fullString;
            fullString = owner+ " " + teamName;
            Console.WriteLine(fullString);
        }
    }
}