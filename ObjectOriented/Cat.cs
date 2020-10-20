﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Cat:Animal
    {
        //子类构造方法需要调用父类同样参数类型的构造方法，用base关键字代表父类
        public Cat() : base()
        { }

        public Cat(string name) : base(name)
        { }

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
