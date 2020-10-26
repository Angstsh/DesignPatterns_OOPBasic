using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Monkey:Animal
    {
        //子类构造方法需要调用父类同样参数类型的构造方法，用base关键字代表父类
        public Monkey() : base()
        { }

        public Monkey(string name) : base(name)
        { }

        protected override string getShoutSound()
        {
            return "吱";
        }
    }
}
