using System.Net;

namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string status;

            do
            {
                Console.WriteLine($"\nSelect the option:");
                Console.WriteLine($"1 - Hostel Information");
                Console.WriteLine($"2 - Add Student ");
                Console.WriteLine($"3 - Remove Student");
                Console.WriteLine($"4 - Add Room");
                Console.WriteLine($"5 - Display Student by ID");
                Console.WriteLine($"6 - Display Student\n");

                string Choice = Console.ReadLine();

                switch (Choice)
                {
                    case "1":
                        Hostel.PrintInfo();
                        break;

                    case "2":
                        try
                        {
                            HostelOpration hostelOpration = new HostelOpration();
                            Console.WriteLine("Enter Student ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Student name: ");
                            string name = Console.ReadLine().ToString();

                            hostelOpration.AddStudent(name, id);

                        }

                        catch (System.FormatException)
                        {
                            Console.WriteLine("Wrong input Numbers Only");

                        }
                        break;
                    case "3":
                        try
                        {
                            HostelOpration removeStu = new HostelOpration();
                            Console.WriteLine("Enter Student ID: ");
                            int removeId = Convert.ToInt32(Console.ReadLine());

                            removeStu.RemoveStudent(removeId);
                        }

                        catch (System.FormatException)
                        {
                            Console.WriteLine("Wrong input Numbers Only");

                        }
                        break;


                    case "4":

                        Console.WriteLine("Enter Room Type(AC / None AC): ");
                        string rType = Console.ReadLine().ToString();

                        if (rType == "AC")
                        {
                            ACRoom aC = new ACRoom();

                            Console.WriteLine("Enter Room ID: ");
                            int rId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Room Feture: ");
                            string rFeture = Console.ReadLine().ToString();

                            aC.AddRoom(rId, rFeture);
                        }
                        else
                        {
                            NoneAcRoom naC = new NoneAcRoom();

                            Console.WriteLine("Enter Room ID: ");
                            int rId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Room Feture: ");
                            string rFeture = Console.ReadLine().ToString();

                            naC.AddRoom(rId, rFeture);
                        }
                        break;

                    case "5":
                        Console.WriteLine("Enter Room ID: ");
                        int fId = Convert.ToInt32(Console.ReadLine());
                        HostelOpration hostelOpration2 = new HostelOpration();
                        hostelOpration2.Display(fId);

                        break;
                    case "6":
                        HostelOpration hostelOpration1 = new HostelOpration();
                        hostelOpration1.Display();
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }

                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                status = Console.ReadLine();
            }
            while (status == "y" || status == "Y");
        }
    }

}