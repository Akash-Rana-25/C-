using System.Xml.Linq;

namespace Demo
{
    internal class HostelOpration : IhostelOpration
    {
        static List<Student> list;  

        static HostelOpration()
        {
            list= new List<Student>();  
        }

        public void AddStudent(string name, int id)
        {
            Student student = new Student(name ,id);  
            list.Add(student);
        }

        public void Display()
        { 

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
        public void RemoveStudent(int id)
        {
            //list.Remove();

            for (int j = 0; j < list.Count; j++)
            {
                if (list[j].Id.Equals(id))
                {
                    list.RemoveAt(j);
                }
            }
        }
        public void Display(int id)
        {

           Student student = list.Find(item => item.Id==id);  
            Console.WriteLine(student); 

        }
    }
}
