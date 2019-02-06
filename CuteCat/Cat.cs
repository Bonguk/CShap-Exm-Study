using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat // 툴 박스라 생각함
{
    public class Cat 
    // internal는 namespace안에서만 사용 가능 클래스도 public를 사용 하면 다른 곳에서도 사용 가능
    {
        // Private 클래스 내부에서만 사용 가능
        // Public 클래스 내부에서도 사용 가능하고, 다른곳 에서도 사용 가능함 
        // 기본적으로 private 값을 부여 하지만, 항상 명시적으로 적어는게 좋음 
        public string Name;
        public int Age;

        private int Happiness = 50;

        public Cat(string name, int age)
        {
            // this는 인스턴스를 가르키는 것
            this.Name = name; 
            this.Age = age;
        }

        public void GetBored()
        {
            Happiness = Happiness - 10;

            if (Happiness < 0)
                Happiness = 0;
        }

        public void Play()
        {
            Happiness = Happiness + 10;

            if (Happiness > 100)
                Happiness = 100;
        }

        public void Eat ()
        {
            Happiness = Happiness + 20;

            if (Happiness > 100)
                Happiness = 100;
        }

        public string Express()
        {
            string message = "";

            if (Happiness >= 80)
                message = "I'm very happy.";
            else if (Happiness >= 60)
                message = "I'm happy.";
            else if (Happiness >= 40)
                message = "I'm so so.";
            else if (Happiness >= 20)
                message = "I'm gloomy.";
            else
                message = "I'm sad.";

            return this.Name + ": " + message;
        }
    }
}
