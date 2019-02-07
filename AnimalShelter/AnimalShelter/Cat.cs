using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    // 클래스 상속은 "클래스 : 부모 클래스" 으로 작성 해준다.
    public class Cat : Pet
    {
        // 부모 클래스가 먼저 생성자를 호출하므로 부모 클래스의 생성자를 명시적으로 호출해준다.
        public Cat(int petId, string name, string color, string gender)
            : base(petId, name, color, gender)
        {
        }

        // override을 하면서 자식 클래스에서 가상메서드 재정의
        public override string MakeSound()
        {
            return "야옹";
        }

        // Cat의 고유 메서드
        public string Scratch()
        {
            return "할퀴기";
        }
    }
}
