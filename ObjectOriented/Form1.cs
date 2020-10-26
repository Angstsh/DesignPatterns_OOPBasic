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
        //声明泛型集合变量
        IList<Animal> arrayAnimal;

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
            //实例化List对象
            arrayAnimal = new List<Animal>();

            arrayAnimal.Add(new Cat("小花"));
            arrayAnimal.Add(new Dog("阿毛"));
            arrayAnimal.Add(new Dog("小黑"));
            arrayAnimal.Add(new Cat("娇娇"));
            arrayAnimal.Add(new Cat("咪咪"));

            MessageBox.Show(arrayAnimal.Count.ToString());
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
