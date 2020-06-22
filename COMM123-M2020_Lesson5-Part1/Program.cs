using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMM123_M2020_Lesson5_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject player=new GameObject("Player");

            //player.transform.postion=new Vector2D();
            //Console.WriteLine(player.Name);
            Console.WriteLine(player.transform.ToString());
            Console.WriteLine(player.ToString());


            //player.transform.postion.x = 10.0f;


            //Listen for any key
            Console.ReadLine();
        }
    }
}
