using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMM123_M2020_Lesson5_Part1
{
    class Vector2D
    {
        //PUBLIC INSTANCE VAR
        public float x;
        public float y;

        //PUBLIC OPERATOR OVERLOADS
        public static Vector2D operator +(Vector2D lhs, Vector2D rhs)
        {
            float xs = lhs.x + rhs.x;
            float ys = lhs.y + rhs.y;
            return new Vector2D(xs,ys);
        }

        public static Vector2D operator -(Vector2D lhs, Vector2D rhs)
        {
            float xs = lhs.x - rhs.x;
            float ys = lhs.y - rhs.y;
            return new Vector2D(xs, ys);
        }

        public static Vector2D operator *(Vector2D lhs, Vector2D rhs)
        {
            float xs = lhs.x * rhs.x;
            float ys = lhs.y * rhs.y;
            return new Vector2D(xs, ys);
        }

        public static Vector2D operator /(Vector2D lhs, Vector2D rhs)
        {
            float xs = lhs.x / rhs.x;
            float ys = lhs.y / rhs.y;
            return new Vector2D(xs, ys);
        }

        public static Vector2D operator *(Vector2D lhs, float rhs)
        {
            float xs = lhs.x - rhs;
            float ys = lhs.y - rhs;
            return new Vector2D(xs, ys);
        }


        //CONSTRUCTOR
        /// <summary>
        /// This constructor takes x and y as optional parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Vector2D(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;
        }

        //PUBLIC METHODS
        /// <summary>
        /// This methid return the values of x and y with the format (x,y) as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = $"({x},{y})";

            return outputString;
        }
        //PUBLIC STATIC METHODS
        public static Vector2D Zero()
        {
            return new  Vector2D(0.0f,0.0f);
        }

        public static Vector2D Up()
        {
            return  new Vector2D(0.0f,1.0f);
        }

        public static Vector2D Down()
        {
            return new Vector2D(0.0f, -1.0f);
        }
        public static Vector2D Right()
        {
            return new Vector2D(1.0f, -1.0f);
        }
        public static Vector2D Left()
        {
            return new Vector2D(-1.0f, -1.0f);
        }
    }

}
