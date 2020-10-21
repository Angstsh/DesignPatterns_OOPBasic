using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Animal
    {
        protected string name = "";
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal()
        {
            this.name = "无名";
        }

        protected int shoutNum = 3;
        public int ShoutNum
        {
            get
            {
                return shoutNum;
            }
            set
            {
                shoutNum = value;
            }
        }

        //提供动物叫的虚方法，供派生类重写
        public virtual string Shout()
        {
            return "";
        }
    }
}
