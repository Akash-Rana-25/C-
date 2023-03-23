using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{

    // Inheritance
    class Sponsor
    {
        protected string owner = "Rakuteen";
    }
    class Team : Sponsor
    {
        private string teamName = "Dot Net";

        /// <summary>
        /// This method concate  two Strings and display Full string
        /// </summary>
        public void Printinfo()
        {
            string fullString;
            fullString = owner + " " + teamName;
            Console.WriteLine(fullString);
            //return fullString;
        }
    }
}
