using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class StoneMonkey:Monkey,IChange
    {
        public StoneMonkey() : base()
        { }

        public StoneMonkey(string name) : base(name)
        { }

        public string ChangeThing(string thing)
        {
            return base.Shout() + " 我有百变猴毛，我可变出：" + thing;
        }
    }
}
