using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMM123_M2020_Lesson5_Part1
{
    class Enemy :GameObject
    {
        //PRIVATE INSTANCE VAR

        //PUBLIC PROB

        //CONSTRUCTOR
        public Enemy(string name)
            : base(name)
        {
        }
        //PRIVATE METHOD

        //PUBLIC METHODS
        public virtual void FireBullets()
        {
            Console.WriteLine("Firing Bullets");
        }

    }
}
