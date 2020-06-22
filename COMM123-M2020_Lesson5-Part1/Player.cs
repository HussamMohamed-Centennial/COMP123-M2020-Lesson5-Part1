using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMM123_M2020_Lesson5_Part1
{
    class Player:GameObject
    {
        //PRIVATE INSTANCE VAR

        //PUBLIC PROB

        //CONSTRUCTOR
        public Player()
            : base("Player")
        {
        }
        //PRIVATE METHOD

        //PUBLIC METHODS
        public void RaiseShields()
        {
            Console.WriteLine("Raising Sheilds");
        }
    }
}
