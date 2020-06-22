using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMM123_M2020_Lesson5_Part1
{
    class BossEnemy:Enemy
    {
        //PRIVATE INS

        //PUBLIC PROB

        // CONSTRUCTOR
        public BossEnemy()
            : base("Boss")
        {
        }
        //PRIVATE METHOD

        //PUBLIC METHOD
        public override void FireBullets()
        {
            Console.WriteLine("Firing FAT Bullets!");
            ;
        }
    }
}
