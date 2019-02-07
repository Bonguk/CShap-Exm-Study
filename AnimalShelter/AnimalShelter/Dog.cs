using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    // 열거형 데이터 타입 (새로운 데이터 타입을 만듬)
    public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire };

    public class Dog : Pet
    {
        public DogBreed Bredd;

        public Dog(int petId, string name, string color, string gender, DogBreed breed)
            : base(petId, name, color, gender)
        {
            Bredd = breed;
        }

        // override을 하면서 자식 클래스에서 가상메서드 재정의
        public override string MakeSound()
        {
            return "멍멍";
        }

        // Dog의 고유 메서드
        public string Bite()
        {
            return "물어뜯기";
        }
    }
}
