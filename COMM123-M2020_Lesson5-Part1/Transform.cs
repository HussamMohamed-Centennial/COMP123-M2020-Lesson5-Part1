using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMM123_M2020_Lesson5_Part1
{
    class Transform
    {
        //PUBLIC INTANCE VAR
        public Vector2D postion;
        public Vector2D rotation;
        public Vector2D scale;

        //CONSTRUCTOR
        public Transform()
        {
            m_intialize();
            
        }

        //PRIVATE METHODS
        private void m_intialize()
        {
            postion=new Vector2D();
            rotation=new Vector2D();
            scale=new Vector2D();
        }
        /// <summary>
        /// This method formats the trnasform to show it's componants in string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += $"Psotion: " + postion.ToString() + "\n";
            outputString += $"Rotation:" + rotation.ToString() + "\n";
            outputString += $"Scale   :" + scale.ToString() + "\n";

            return outputString;
        }
    }
}
