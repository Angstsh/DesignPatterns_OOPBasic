using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Cat
    {
        private string name = "";
        //创建带name参数的构造函数，让小猫在实例化时便可拥有名字
        public Cat(string name)
        {
            this.name = name;
        }
        //方法重载，允许实例化时没取名字
        public Cat()
        {
            this.name = "无名";
        }
        
        public string Shout()
        {
            return "我的名字叫"+name+" 喵";
        }
    }
}
