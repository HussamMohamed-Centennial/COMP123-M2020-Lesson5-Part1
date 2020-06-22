using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMM123_M2020_Lesson5_Part1
{
    class GameObject
    {

        //PRIVATE INSTANCE MEMBERS(FIELDS)
        private string m_name;
        //PUBLIC PROP
        public Transform Transform { get; set; }

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }
        //CONSTRUCTOR(S)
        public GameObject(string name)
        {
            Name = name;
        }

        //PRIVATE METHODS

        //PUBLIC METHODS

    }
}
