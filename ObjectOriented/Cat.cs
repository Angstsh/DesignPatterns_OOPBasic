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

        /*猫叫次数*/
        //私有字段
        private int shoutNum = 3;
        //公有的对外属性,使用属性可以更好的控制字段的对外权限
        public int ShoutNum
        {
            get { return shoutNum; }
            set {
                if (value < 10)
                    shoutNum = value;
                else
                    shoutNum = 10;
            }
        }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵";
            }
            return "我的名字叫" + name + result;
        }
    }
}
