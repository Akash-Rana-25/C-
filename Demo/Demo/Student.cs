using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    sealed class  Student
    {
        private int _id;
        private string _name;

        public int Id { get { return _id; } }

        public Student(string name , int id)
        {
            _id = id;
            _name=name;
        }

        public override string ToString() {
            return $"id={_id},name = {_name}";
        }
    }
}
