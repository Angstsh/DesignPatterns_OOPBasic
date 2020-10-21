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
    }
}
