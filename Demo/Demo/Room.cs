using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    abstract class Room
    {
        public int roomId;
        public int roomFees;
        public string roomFeture;

        public abstract void AddRoom(int rId ,string rFeture);
        public abstract int GetRoomFees();
    }
    class ACRoom : Room
    {
        public override void AddRoom(int rId ,string rFeture)

        {
            roomId = rId;
            roomFeture = rFeture;
        }
        public override int GetRoomFees()
        {
            return roomFees=10;
        }
    }
    class NoneAcRoom : Room
    {
        public override void AddRoom(int rId, string rFeture)

        {
            roomId = rId;
            roomFeture = rFeture;
        }
        public override  int GetRoomFees()
        {
            return roomFees=0;
        }
    }

}