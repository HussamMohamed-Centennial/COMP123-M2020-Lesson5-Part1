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
            //GameObject player=new GameObject("Player");
            Player player=new Player();

            Enemy greenEnemy=new Enemy("GreenEnemy");
            Enemy redEnemy = new Enemy("RedEnemy");
            BossEnemy bossEnemy=new BossEnemy();
            
            player.RaiseShields();
            player.transform.postion=new Vector2D(60.0f,80.0f);
            Console.WriteLine(player.ToString());

            
            greenEnemy.FireBullets();
            greenEnemy.transform.postion=new Vector2D(100.20f,30.20f);
            Console.WriteLine(greenEnemy.ToString());

            Console.WriteLine(redEnemy.ToString());
            redEnemy.FireBullets();
            Console.WriteLine();

            bossEnemy.FireBullets();
            bossEnemy.transform.postion=new Vector2D(200.0f,200.0f);
            Console.WriteLine(bossEnemy.ToString());

            //player.transform.postion=new Vector2D();
            //Console.WriteLine(player.Name);
            //Console.WriteLine(player.transform.ToString());
            //Console.WriteLine(player.ToString());


            //player.transform.postion.x = 10.0f;


            //Listen for any key
            Console.ReadLine();
        }
    }
}
