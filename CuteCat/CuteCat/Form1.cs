using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteCat
{
    public partial class Form1 : Form
    {
        private Cat MyCat = new Cat("Nacho", 1); 
        // Cat 클래스로 MyCat이라는 Object를 만듬 new Cat()는 Method지만 생성을 할때만 사용되는 method라서 생성자라 불림
        // () 기본생성자는 해당 함수에 아무것도 없을때 사용 가능

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyCat.Play();
            CatSceen.Text = MyCat.Express();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            MyCat.Eat();
            CatSceen.Text = MyCat.Express();
        }
         
        private void CatTimer_Tick(object sender, EventArgs e)
        {
            MyCat.GetBored();
            CatSceen.Text = MyCat.Express();
        }
    }
}
