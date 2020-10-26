using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOriented
{
    public partial class Form1 : Form
    {
        //声明一个动物数组
        private Animal[] arrayAnimal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatShout_Click(object sender, EventArgs e)
        {
        }

        //“动物报名”的按钮事件
        private void btnSignup_Click(object sender, EventArgs e)
        {
            //实例化最多可报名5个的动物数组对象
            arrayAnimal = new Animal[5];
            arrayAnimal[0] = new Cat("小花");
            arrayAnimal[1] = new Dog("阿毛");
            arrayAnimal[2] = new Dog("小黑");
            arrayAnimal[3] = new Cat("娇娇");
            arrayAnimal[4] = new Cat("咪咪");
        }

        //“叫声比赛”的按钮事件
        private void btnMatch_Click(object sender, EventArgs e)
        {
            foreach (Animal item in arrayAnimal)
            {
                MessageBox.Show(item.Shout());
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MachineCat mcat = new MachineCat("叮当");
            StoneMonkey wukong = new StoneMonkey("孙悟空");

            IChange[] array = new IChange[2];
            array[0] = mcat;
            array[1] = wukong;

            //利用多态性，实现不同的ChangeThing
            MessageBox.Show(array[0].ChangeThing("各种各样的东西! "));
            MessageBox.Show(array[1].ChangeThing("各种各样的东西! "));
        }
    }
}
