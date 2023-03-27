using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface IhostelOpration
    {
        void AddStudent(string name, int id);
        void RemoveStudent(int id);
        void Display();

    }
}
